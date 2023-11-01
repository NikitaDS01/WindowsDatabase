using SF2022User22Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDatabase
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Print();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WindowEntrance());
        }
        static void Print()
        {
            TimeSpan[] timeSpans =
            {
                new TimeSpan(10, 0, 0),
                new TimeSpan(11, 0, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(15, 30, 0),
                new TimeSpan(16, 50, 0)
            };
            int[] duration =
            {
                60,
                30,
                10,
                10,
                40
            };
            Calculations test = new Calculations();
            var result = test.AvailablePeriods(timeSpans, duration,
                new TimeSpan(8, 0, 0),
                new TimeSpan(18, 0, 0),
                30
                );
            Console.WriteLine( result );
        }
    }
}
