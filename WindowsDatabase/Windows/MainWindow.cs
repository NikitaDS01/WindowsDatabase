using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDatabase.Classes.Database;
using WindowsDatabase.Classes.Database.Table;
using WindowsDatabase.Classes.FunctionWindow;

namespace WindowsDatabase.Windows
{
    public partial class MainWindow : Form
    {
        private int _width;
        private int _height;
        private int _countRows;
        private int _page;
        private int _maxCountRows;

        public MainWindow()
        {
            InitializeComponent();
            AdminRole();

            GetManufacturers();
            SetMaxCountRows();

            cmbBoxSorting.Text = cmbBoxSorting.Items[0].ToString();
            cmbBoxCountPage.Text = cmbBoxCountPage.Items[1].ToString();
            cmbBoxManufacturer.Text = cmbBoxManufacturer.Items[0].ToString();

            _countRows = Convert.ToInt32(cmbBoxCountPage.Text);
            _page = 0;

            UpdateUIPanel(GetProducts());

            _width = this.Width;
            _height = this.Height;
            
        }

        public int CurrentPage => _page + 1;

        private void AdminRole()
        {
            if (InfoSession.GetUser().Role != Role.Admin)
            {
                btnAddProduct.Visible = false;
            }
        }

        private void SetMaxCountRows()
        {
            try
            {
                _maxCountRows = Requests.GetCountProduct();
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }

        private void GetManufacturers()
        {
            try
            {
                List<string> manufacturers = Requests.GetManufacturer();
                manufacturers.Insert(0, "Все  производители");
                cmbBoxManufacturer.Items.AddRange(manufacturers.ToArray());
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }

        private List<Product> GetProducts()
        {
            try
            {
                string nameAttribute = cmbBoxSorting.Text;
                bool isAsc = radioBtnAsc.Checked;
                List<Product> products = Requests.GetProducts(nameAttribute, isAsc, 
                    cmbBoxManufacturer.Text, txtBoxSearch.Text, _countRows, _page);
                lblCountRows.Text = $"{products.Count} из {_maxCountRows}";
                return products;
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                lblCountRows.Text = "0 из 0";
                return new List<Product>();
            }
        }
        private void UpdateUIPanel(List<Product> products)
        {
            panelProduct.Controls.Clear();

            int index = 0;
            foreach (var product in products)
            {
                var control = new ControlProduct(product);
                control.Tag = index;
                panelProduct.Controls.Add(control);
                index++;
            }
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            lblInfoUser.Text = $"Пользователь:\n{InfoSession.GetUser().FullName}";
            InfoSession.OnUpdateDataBase += UIChange;
        }
        private void ChangeSizeForm(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }

        private void btnPageLast_Click(object sender, EventArgs e)
        {
            if(_page - 1 >= 0)
            {
                _page -= 1;
                UpdateUIPanel(GetProducts());
                lblPageCount.Text = CurrentPage.ToString();
            }
        }

        private void btnPageNext_Click(object sender, EventArgs e)
        {
            _page += 1;
            List<Product> products = GetProducts();
            if (products.Count == 0)
            {
                _page -= 1;
                return;
            }

            UpdateUIPanel(products);
            lblPageCount.Text = CurrentPage.ToString();
        }
        private void cmbBoxCountPage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int newCountRows = Convert.ToInt32(cmbBoxCountPage.SelectedItem.ToString());
            if (_countRows != newCountRows)
            {
                _countRows = newCountRows;
                SetOnePage();
                UpdateUIPanel(GetProducts());
            }
        }

        private void ChangeSorting(object sender, EventArgs e)
        {
            if (_countRows != 0)
            {
                SetOnePage();
                UpdateUIPanel(GetProducts());
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SetOnePage();
            UpdateUIPanel(GetProducts());
        }

        private void cmbBoxManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_countRows != 0)
            {
                SetOnePage();
                UpdateUIPanel(GetProducts());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetOnePage()
        {
            _page = 0;
            lblPageCount.Text = CurrentPage.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            WindowUpdateProduct window = new WindowUpdateProduct();
            window.ShowDialog();
        }
        public void UIChange()
        {
            int index = cmbBoxManufacturer.SelectedIndex;
            cmbBoxManufacturer.Items.Clear();
            GetManufacturers();
            cmbBoxManufacturer.SelectedIndex = index;
            UpdateUIPanel(GetProducts());
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            InfoSession.OnUpdateDataBase -= UIChange;
        }
    }
}
