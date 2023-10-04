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
using WindowsDatabase.Windows;

namespace WindowsDatabase
{
    public partial class WindowEntrance : Form
    {
        public WindowEntrance()
        {
            InitializeComponent();
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLogin.Text))
                MessageInfoShow.ShowWarning("Введите логин");
            if (string.IsNullOrEmpty(txtBoxPassword.Text))
                MessageInfoShow.ShowWarning("Введите пароль");

            try
            {
                User user = Requests.GetUser(txtBoxLogin.Text, txtBoxPassword.Text);
                InfoSession.SetUser(user);
                NewOpenWindow();
            }
            catch (Exception ex)
            {
                MessageInfoShow.ShowError(ex.Message);
                return;
            }
        }

        private void linkLblEntranceGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InfoSession.SetUser(User.DefaultUser);
            NewOpenWindow();
        }

        private void NewOpenWindow()
        {
            this.Hide();
            MainWindow window = new MainWindow();
            window.ShowDialog();

            InfoSession.SetUser(null);
            this.Show();
        }

        
    }
}
