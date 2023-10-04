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
            this.btnEntranceGuest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(12, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 26);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(12, 59);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(203, 34);
            this.txtBoxLogin.TabIndex = 1;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(12, 135);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(203, 34);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 106);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 26);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Пароль";
            // 
            // btnEntrance
            // 
            this.btnEntrance.Location = new System.Drawing.Point(59, 186);
            this.btnEntrance.Name = "btnEntrance";
            this.btnEntrance.Size = new System.Drawing.Size(111, 33);
            this.btnEntrance.TabIndex = 4;
            this.btnEntrance.Text = "Войти";
            this.btnEntrance.UseVisualStyleBackColor = true;
            this.btnEntrance.Click += new System.EventHandler(this.btnEntrance_Click);
            // 
            // btnEntranceGuest
            // 
            this.btnEntranceGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntranceGuest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntranceGuest.Location = new System.Drawing.Point(3, 237);
            this.btnEntranceGuest.Name = "btnEntranceGuest";
            this.btnEntranceGuest.Size = new System.Drawing.Size(229, 35);
            this.btnEntranceGuest.TabIndex = 5;
            this.btnEntranceGuest.Text = "Войти как гость";
            this.btnEntranceGuest.UseVisualStyleBackColor = true;
            this.btnEntranceGuest.Click += new System.EventHandler(this.btnEntranceGuest_Click);
            // 
            // WindowEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 294);
            this.Controls.Add(this.btnEntranceGuest);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnEntrance;
        private System.Windows.Forms.Button btnEntranceGuest;
    }
}

