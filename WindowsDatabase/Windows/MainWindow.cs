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

        public MainWindow()
        {
            InitializeComponent();

            _countRows = Convert.ToInt32(cmbBoxCountPage.SelectedItem.ToString());
            _page = 0;

            UpdateUIPanel(GetProducts());

            _width = this.Width;
            _height = this.Height;
            
        }

        public int CurrentPage => _page + 1;

        private List<Product> GetProducts()
        {
            try
            {
                string nameAttribute = cmbBoxSorting.SelectedItem.ToString();
                bool isAsc = radioBtnAsc.Checked;
                List<Product> products = Requests.GetProducts(nameAttribute, isAsc, txtBoxSearch.Text, _countRows, _page);
                return products;
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
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
                _page = 0;
                UpdateUIPanel(GetProducts());
                lblPageCount.Text = CurrentPage.ToString();
            }
        }

        private void ChangeSorting(object sender, EventArgs e)
        {
            _page = 0;
            UpdateUIPanel(GetProducts());
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateUIPanel(GetProducts());
        }
    }
}
