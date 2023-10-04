using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDatabase.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            lblInfoUser.Text = $"Пользователь: {InfoSession.GetUser().FullName}";
        }
    }
}
