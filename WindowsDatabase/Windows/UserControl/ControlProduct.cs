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
using WindowsDatabase.Classes.Database.Enum;
using WindowsDatabase.Classes.Database.Table;
using WindowsDatabase.Classes.FunctionWindow;

namespace WindowsDatabase.Windows
{
    public partial class ControlProduct : UserControl
    {
        private Product _product;

        public ControlProduct()
        {
            InitializeComponent();
        }

        public ControlProduct(Product product)
        {
            InitializeComponent();
            _product = product;
            SetInfo();
        }
        private void SetInfo()
        {
            lblName.Text += _product.Name;
            lblDescription.Text += _product.Description;
            lblManufacturer.Text += _product.Manufacturer;
            float currentPrice = _product.Price * (1f - _product.CurrentDiscount / 100f);
            lblPrice.Text += currentPrice.ToString() + "руб.";
            if (_product.CountStorage == 0)
                this.BackColor = Color.Gray;
            if(_product.Image  != null) 
                imageBoxProduct.Image = _product.Image;
            if (InfoSession.GetUser().Role != Role.Admin)
                btnDelete.Visible = false;
        }

        private void ControlProduct_DoubleClick(object sender, EventArgs e)
        {
            if (InfoSession.GetUser().Role == Role.Admin)
            {
                WindowUpdateProduct window = new WindowUpdateProduct(_product);
                window.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageInfoShow.ShowChoice("Вы уверены?", "Удалить файл") == DialogResult.Cancel)
                return;

            try
            {
                if (!Requests.IsProductOrder(_product))
                {
                    Requests.DeleteProduct(_product);
                    InfoSession.EventUpdateDB();
                }
                else
                {
                    MessageInfoShow.ShowError("Данный товар нельзя удалить. Он есть в заказах");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }
    }
}
