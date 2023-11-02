namespace WindowsDatabase.Windows
{
    partial class WindowUpdateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUpdateProduct));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imageBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxUnitChange = new System.Windows.Forms.ComboBox();
            this.txtBoxManufacturer = new System.Windows.Forms.TextBox();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblUnitChange = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtBoxSupplier = new System.Windows.Forms.TextBox();
            this.btnUpdateImage = new System.Windows.Forms.Button();
            this.imageBoxProduct = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fileDialogOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LimeGreen;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.imageBoxLogo);
            this.panelLogo.Controls.Add(this.lblNameCompany);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(681, 80);
            this.panelLogo.TabIndex = 9;
            // 
            // imageBoxLogo
            // 
            this.imageBoxLogo.Image = global::WindowsDatabase.Properties.Resources.logo;
            this.imageBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.imageBoxLogo.Name = "imageBoxLogo";
            this.imageBoxLogo.Size = new System.Drawing.Size(70, 70);
            this.imageBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxLogo.TabIndex = 7;
            this.imageBoxLogo.TabStop = false;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Location = new System.Drawing.Point(83, 27);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(303, 26);
            this.lblNameCompany.TabIndex = 6;
            this.lblNameCompany.Text = "ООО «Товары для животных»  ";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(364, 86);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(187, 34);
            this.txtBoxName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(210, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(148, 26);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Наименование";
            // 
            // cmbBoxCategory
            // 
            this.cmbBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCategory.FormattingEnabled = true;
            this.cmbBoxCategory.Location = new System.Drawing.Point(364, 126);
            this.cmbBoxCategory.Name = "cmbBoxCategory";
            this.cmbBoxCategory.Size = new System.Drawing.Size(187, 34);
            this.cmbBoxCategory.TabIndex = 12;
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(364, 166);
            this.numericCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(187, 34);
            this.numericCount.TabIndex = 13;
            // 
            // cmbBoxUnitChange
            // 
            this.cmbBoxUnitChange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUnitChange.FormattingEnabled = true;
            this.cmbBoxUnitChange.Location = new System.Drawing.Point(364, 206);
            this.cmbBoxUnitChange.Name = "cmbBoxUnitChange";
            this.cmbBoxUnitChange.Size = new System.Drawing.Size(187, 34);
            this.cmbBoxUnitChange.TabIndex = 14;
            // 
            // txtBoxManufacturer
            // 
            this.txtBoxManufacturer.Location = new System.Drawing.Point(365, 246);
            this.txtBoxManufacturer.Name = "txtBoxManufacturer";
            this.txtBoxManufacturer.Size = new System.Drawing.Size(187, 34);
            this.txtBoxManufacturer.TabIndex = 15;
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 3;
            this.numericPrice.Location = new System.Drawing.Point(364, 326);
            this.numericPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(186, 34);
            this.numericPrice.TabIndex = 16;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(364, 366);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescription.Size = new System.Drawing.Size(298, 83);
            this.txtBoxDescription.TabIndex = 17;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(210, 129);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(105, 26);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Категория";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(210, 168);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(119, 26);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "Количество";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(209, 327);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 26);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Стоимость";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(210, 248);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(154, 26);
            this.lblManufacturer.TabIndex = 21;
            this.lblManufacturer.Text = "Производитель";
            // 
            // lblUnitChange
            // 
            this.lblUnitChange.AutoSize = true;
            this.lblUnitChange.Location = new System.Drawing.Point(210, 209);
            this.lblUnitChange.Name = "lblUnitChange";
            this.lblUnitChange.Size = new System.Drawing.Size(142, 26);
            this.lblUnitChange.TabIndex = 20;
            this.lblUnitChange.Text = "Ед. измерения";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(209, 369);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 26);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "Описание";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(209, 288);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(115, 26);
            this.lblSupplier.TabIndex = 25;
            this.lblSupplier.Text = "Поставщик";
            // 
            // txtBoxSupplier
            // 
            this.txtBoxSupplier.Location = new System.Drawing.Point(364, 286);
            this.txtBoxSupplier.Name = "txtBoxSupplier";
            this.txtBoxSupplier.Size = new System.Drawing.Size(187, 34);
            this.txtBoxSupplier.TabIndex = 24;
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.Location = new System.Drawing.Point(28, 292);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(145, 61);
            this.btnUpdateImage.TabIndex = 26;
            this.btnUpdateImage.Text = "Установить изображение";
            this.btnUpdateImage.UseVisualStyleBackColor = true;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // imageBoxProduct
            // 
            this.imageBoxProduct.Image = global::WindowsDatabase.Properties.Resources.picture;
            this.imageBoxProduct.Location = new System.Drawing.Point(4, 86);
            this.imageBoxProduct.Name = "imageBoxProduct";
            this.imageBoxProduct.Size = new System.Drawing.Size(200, 200);
            this.imageBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxProduct.TabIndex = 0;
            this.imageBoxProduct.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(426, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 33);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fileDialogOpenImage
            // 
            this.fileDialogOpenImage.FileName = "fileDialog";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 33);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(426, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(115, 33);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // WindowUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 495);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdateImage);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtBoxSupplier);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblUnitChange);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.txtBoxManufacturer);
            this.Controls.Add(this.cmbBoxUnitChange);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.cmbBoxCategory);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.imageBoxProduct);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WindowUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProduct";
            this.SizeChanged += new System.EventHandler(this.WindowUpdateProduct_SizeChanged);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBoxProduct;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imageBoxLogo;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbBoxCategory;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.ComboBox cmbBoxUnitChange;
        private System.Windows.Forms.TextBox txtBoxManufacturer;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblUnitChange;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtBoxSupplier;
        private System.Windows.Forms.Button btnUpdateImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog fileDialogOpenImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
    }
}