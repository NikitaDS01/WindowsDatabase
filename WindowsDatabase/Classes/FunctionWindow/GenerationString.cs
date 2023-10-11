using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDatabase.Classes.FunctionWindow
{
    public class GenerationString
    {
        public static char RandomNewCharAZ(long value)
        {
            Random random = new Random((int)value);
            return (char)random.Next('A', 'Z');
        }
        public static char RandomNewChar09(long value)
        {
            Random random = new Random((int)value);
            return (char)random.Next('0', '9');
        }
        public static string NewIndex()
        {
            StringBuilder builder = new StringBuilder();
            long second = DateTime.Now.Ticks;
            builder.Append(RandomNewCharAZ(second));
            builder.Append(RandomNewChar09(second*2));
            builder.Append(RandomNewChar09(second*3));
            builder.Append(RandomNewChar09(second*4));
            builder.Append(RandomNewCharAZ(second*5));
            builder.Append(RandomNewChar09(second*6));
            return builder.ToString();
        }
    }
}
