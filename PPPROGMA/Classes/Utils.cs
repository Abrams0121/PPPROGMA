using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPROGMA
{
    internal static class Utils
    {
        internal static void Warning(string text, string caption = "Предупреждение")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        internal static void Success(string text, string caption = "Успешно")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Error(string text, string caption = "Ошибка")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

         

        public static string DecimalToString(Decimal price)
        {
            string Price = price.ToString();
            for (int i = Price.Length; i < 9; i++)
            {
                Price = ' ' + Price;
            }

            return Price;
        }

        public static decimal StringToDecimal(string price)
        {
            price.Replace("₽", "").Trim(' ');
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char item in price)
            {
                if (char.IsSeparator(item) || item== '₽')
                {
                    continue;
                }
                stringBuilder.Append(item);
            }

            return decimal.Parse(stringBuilder.ToString(), NumberStyles.AllowDecimalPoint);
        }
    }
}
