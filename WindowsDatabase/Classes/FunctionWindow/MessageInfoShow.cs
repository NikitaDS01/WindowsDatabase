using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDatabase.Classes.FunctionWindow
{
    public static class MessageInfoShow
    {
        public static void ShowError(string message, string caption = "Ошибка") =>
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        public static void ShowWarning(string message, string caption = "Предупреждение") =>
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        public static DialogResult ShowChoice(string message, string caption) =>
            MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
    }
}
