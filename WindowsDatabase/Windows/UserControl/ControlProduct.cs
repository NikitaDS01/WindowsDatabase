using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDatabase.Classes.Database.Enum;
using WindowsDatabase.Classes.Database.Table;

namespace WindowsDatabase.Windows
{
    public partial class ControlProduct : UserControl
    {
        private Product _product;

        public ControlProduct(Product product)
        {
            InitializeComponent();
            _product = product;
            SetInfo();
        }
        private void SetInfo()
        {
            lblId.Text += _product.Id.ToString();
            lblName.Text += _product.Name;
            lblDescription.Text += _product.Description;
            lblCategory.Text += _product.Category;
            lblManufacturer.Text += _product.Manufacturer;
            float currentPrice = _product.Price * (1f - _product.CurrentDiscount / 100f);
            lblPrice.Text += currentPrice.ToString();
            lblPrice.Text += $"/{ConvertEnum.FromUnitChangeToString(_product.UnitChange)}";
            imageBoxProduct.Image = _product.Image;
        }
    }
}
