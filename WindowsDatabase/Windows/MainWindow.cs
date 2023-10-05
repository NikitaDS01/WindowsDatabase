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

namespace WindowsDatabase.Windows
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            ControlProduct control = new ControlProduct(
                DatabaseTest.GetProduct("А112Т4"));
            control.Location = new System.Drawing.Point(12, 45);
            this.Controls.Add(control);
        }

        private void WindowLoad(object sender, EventArgs e)
        {
            lblInfoUser.Text = $"Пользователь: {InfoSession.GetUser().FullName}";
        }
    }
}
