using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class WindowUpdateProduct : Form
    {
        private int _width;
        private int _height;
        private string _index;
        private string _pathImage;
        private Product _product;

        public WindowUpdateProduct()
        {
            InitializeComponent();
            _product = null;
            _pathImage = string.Empty;

            string newIndex;
            do
                newIndex = GenerationString.NewIndex();
            while (Requests.IsThereIndex(newIndex));
            _index = newIndex;

            btnUpdate.Visible = false;

            Init();
        }
        public WindowUpdateProduct(Product product)
        {
            InitializeComponent();
            _product = product;

            txtBoxName.Text = product.Name;
            txtBoxManufacturer.Text = product.Manufacturer;
            txtBoxSupplier.Text = product.Supplier;
            txtBoxDescription.Text = product.Description;
            numericCount.Value = product.CountStorage;
            numericPrice.Value = (decimal)product.Price;
            if(product.Image!= null) 
                imageBoxProduct.Image = product.Image;

            btnAdd.Visible = false;

            Init();

            cmbBoxCategory.SelectedItem = product.Category;
            cmbBoxUnitChange.SelectedItem = ConvertEnum.FromUnitChangeToString(product.UnitChange);
        }
        private void Init()
        {
            _width = this.Width;
            _height = this.Height;
            fileDialogOpenImage.Filter = "Image (*.png)|*.png|All files(*.*)|*.*";
            try
            {
                List<string> category = Requests.GetCategory();
                cmbBoxCategory.Items.AddRange(category.ToArray());
                cmbBoxUnitChange.Items.AddRange(new object[]
                {
                    ConvertEnum.FromUnitChangeToString(UnitChange.Piece),
                    ConvertEnum.FromUnitChangeToString(UnitChange.Kilogram)
                });
            }
            catch(Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }
        private void Copy(string lastPath, string newPath)
        {
            if (File.Exists(newPath))
                File.Delete(newPath);
            File.Copy(
                lastPath,
                newPath
                );
        }
       
        private void WindowUpdateProduct_SizeChanged(object sender, EventArgs e)
        {
            this.Width = _width;
            this.Height = _height;
        }
        private void btnUpdateImage_Click(object sender, EventArgs e)
        {
            if (fileDialogOpenImage.ShowDialog() == DialogResult.Cancel)
                return;
            _pathImage = fileDialogOpenImage.FileName;
            imageBoxProduct.ImageLocation = _pathImage;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = null;
            if (!string.IsNullOrEmpty(_pathImage))
            {
                if (!File.Exists(_pathImage))
                {
                    MessageInfoShow.ShowError("Изображения нет в пути назначения");
                    return;
                }
                string format = new ImageFormatConverter().ConvertToString(Image.FromFile(_pathImage).RawFormat);
                path = Product.NewPath(_index, format);
                Copy(_pathImage, Product.PATH+path);
            }

            _product = new Product(_index, txtBoxName.Text, 
                ConvertEnum.FromStringToUnitChange(cmbBoxUnitChange.Text),
                Convert.ToInt32(numericPrice.Value), 0, txtBoxManufacturer.Text, txtBoxSupplier.Text,
                cmbBoxCategory.Text, 0, Convert.ToInt32(numericCount.Value), txtBoxDescription.Text,
                path);

            try
            {
                Requests.InsertProduct(_product);
                InfoSession.EventUpdateDB();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = _product.PathImage;
            if (!string.IsNullOrEmpty(_pathImage))
            {
                if (!File.Exists(_pathImage))
                {
                    MessageInfoShow.ShowError("Изображения нет в пути назначения");
                    return;
                }
                string format = new ImageFormatConverter().ConvertToString(Image.FromFile(_pathImage).RawFormat);
                path = Product.NewPath(_product.Id, format);
                Copy(_pathImage, Product.PATH + path);
            }

            _product = new Product(_product.Id, txtBoxName.Text,
                ConvertEnum.FromStringToUnitChange(cmbBoxUnitChange.Text),
                Convert.ToInt32(numericPrice.Value), 0, txtBoxManufacturer.Text, txtBoxSupplier.Text,
                cmbBoxCategory.Text, 0, Convert.ToInt32(numericCount.Value), txtBoxDescription.Text,
                path);
            try
            {
                Requests.UpdateProduct(_product);
                InfoSession.EventUpdateDB();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }
        private void btnExit_Click(object sender, EventArgs e) =>
            this.Close();
    }
}
