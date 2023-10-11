namespace WindowsDatabase.Windows
{
    partial class ControlProduct
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlProduct));
            this.imageBoxProduct = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBoxProduct
            // 
            this.imageBoxProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageBoxProduct.Image")));
            this.imageBoxProduct.InitialImage = null;
            this.imageBoxProduct.Location = new System.Drawing.Point(3, 10);
            this.imageBoxProduct.Name = "imageBoxProduct";
            this.imageBoxProduct.Size = new System.Drawing.Size(130, 130);
            this.imageBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxProduct.TabIndex = 0;
            this.imageBoxProduct.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(139, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 26);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Название:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(139, 88);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(602, 85);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Описание:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(139, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 26);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(139, 36);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(160, 26);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(679, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imageBoxProduct);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ControlProduct";
            this.Size = new System.Drawing.Size(780, 173);
            this.DoubleClick += new System.EventHandler(this.ControlProduct_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBoxProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Button btnDelete;
    }
}
