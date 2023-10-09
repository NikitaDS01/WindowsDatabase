using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public MainWindow()
        {
            InitializeComponent();
            AddProductsPanel();

            _width = this.Width;
            _height = this.Height;
        }
        private void AddProductsPanel()
        {
            try 
            { 
                List<Product> products = Requests.GetProducts();
                int index = 0;
                foreach(var product in products)
                {
                    ControlProduct control = new ControlProduct(product);
                    control.Tag = index;
                    panelProduct.Controls.Add(control);
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }
        private void WindowLoad(object sender, EventArgs e)
        {
            lblInfoUser.Text = $"Пользователь: {InfoSession.GetUser().FullName}";
        }
        private void ChangeSizeForm(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }
    }
}
