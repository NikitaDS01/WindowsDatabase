namespace WindowsDatabase
{
    partial class WindowEntrance
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowEntrance));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnEntrance = new System.Windows.Forms.Button();
            this.linkLblEntranceGuest = new System.Windows.Forms.LinkLabel();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(91, 93);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 26);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(91, 122);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(203, 34);
            this.txtBoxLogin.TabIndex = 1;
            this.txtBoxLogin.Text = "pixil59@gmail.com";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(91, 198);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(203, 34);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.Text = "2L6KZG";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(91, 169);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 26);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(138, 249);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(111, 33);
            this.btnEntrance.TabIndex = 4;
            this.btnEntrance.Text = "Войти";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // linkLblEntranceGuest
            // 
            this.linkLblEntranceGuest.AutoSize = true;
            this.linkLblEntranceGuest.Location = new System.Drawing.Point(115, 285);
            this.linkLblEntranceGuest.Name = "linkLblEntranceGuest";
            this.linkLblEntranceGuest.Size = new System.Drawing.Size(156, 26);
            this.linkLblEntranceGuest.TabIndex = 5;
            this.linkLblEntranceGuest.TabStop = true;
            this.linkLblEntranceGuest.Text = "Войти как гость";
            this.linkLblEntranceGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblEntranceGuest_LinkClicked);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imageBoxLogo);
            this.panel1.Controls.Add(this.lblNameCompany);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 78);
            this.panel1.TabIndex = 7;
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
            // WindowEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLblEntranceGuest);
            this.Controls.Add(this.btnEntrance);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lblLogin);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WindowEntrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.SizeChanged += new System.EventHandler(this.ChangeSizeForm);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.LinkLabel linkLblEntranceGuest;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageBoxLogo;
    }
}

