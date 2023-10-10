namespace WindowsDatabase.Windows
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblInfoUser = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imageBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPageLast = new System.Windows.Forms.Button();
            this.btnPageNext = new System.Windows.Forms.Button();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.cmbBoxCountPage = new System.Windows.Forms.ComboBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.AutoSize = true;
            this.lblInfoUser.Location = new System.Drawing.Point(830, 83);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(192, 26);
            this.lblInfoUser.TabIndex = 0;
            this.lblInfoUser.Text = "Пользователь: Test";
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.imageBoxLogo);
            this.panelLogo.Controls.Add(this.lblNameCompany);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1200, 80);
            this.panelLogo.TabIndex = 8;
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
            // panelProduct
            // 
            this.panelProduct.AutoScroll = true;
            this.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelProduct.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelProduct.Location = new System.Drawing.Point(4, 87);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(820, 662);
            this.panelProduct.TabIndex = 9;
            this.panelProduct.WrapContents = false;
            // 
            // btnPageLast
            // 
            this.btnPageLast.Location = new System.Drawing.Point(835, 719);
            this.btnPageLast.Name = "btnPageLast";
            this.btnPageLast.Size = new System.Drawing.Size(147, 30);
            this.btnPageLast.TabIndex = 10;
            this.btnPageLast.Text = "Предыдущая";
            this.btnPageLast.UseVisualStyleBackColor = true;
            this.btnPageLast.Click += new System.EventHandler(this.btnPageLast_Click);
            // 
            // btnPageNext
            // 
            this.btnPageNext.Location = new System.Drawing.Point(1015, 719);
            this.btnPageNext.Name = "btnPageNext";
            this.btnPageNext.Size = new System.Drawing.Size(147, 30);
            this.btnPageNext.TabIndex = 11;
            this.btnPageNext.Text = "Следующая";
            this.btnPageNext.UseVisualStyleBackColor = true;
            this.btnPageNext.Click += new System.EventHandler(this.btnPageNext_Click);
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(988, 719);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(21, 26);
            this.lblPageCount.TabIndex = 12;
            this.lblPageCount.Text = "1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(842, 690);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(205, 26);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Количество записей:";
            // 
            // cmbBoxCountPage
            // 
            this.cmbBoxCountPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCountPage.FormattingEnabled = true;
            this.cmbBoxCountPage.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.cmbBoxCountPage.Location = new System.Drawing.Point(1041, 682);
            this.cmbBoxCountPage.Name = "cmbBoxCountPage";
            this.cmbBoxCountPage.Size = new System.Drawing.Size(121, 34);
            this.cmbBoxCountPage.TabIndex = 15;
            this.cmbBoxCountPage.SelectedItem = "10";
            this.cmbBoxCountPage.SelectionChangeCommitted += new System.EventHandler(this.cmbBoxCountPage_SelectionChangeCommitted);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.cmbBoxCountPage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.btnPageNext);
            this.Controls.Add(this.btnPageLast);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.lblInfoUser);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.WindowLoad);
            this.SizeChanged += new System.EventHandler(this.ChangeSizeForm);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoUser;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imageBoxLogo;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.FlowLayoutPanel panelProduct;
        private System.Windows.Forms.Button btnPageLast;
        private System.Windows.Forms.Button btnPageNext;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ComboBox cmbBoxCountPage;
    }
}