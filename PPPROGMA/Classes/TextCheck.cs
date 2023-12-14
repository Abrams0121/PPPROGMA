using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace PPPROGMA
{
    internal class TextCheck
    {
        private static List<char> engAlph = new List<char>(@"a b c d e f g h i j k l m n o p q r s t u v w x y z A B
                    C D E F G H I J K L M N O P Q R S T U V W X Y Z".Replace(" ",""));

        

        StringBuilder sb = new StringBuilder();

        private static List<char> numList  = new List<char>("1234567890");

        private static List<char> numListForCars = new List<char>("1234567890,.");

        private static List<char> punctMarkList = new List<char>(",./;:'\'\"[]{}|?#@$%^&*!_-+=~`\\");
        //"a b c d e f g h i j k l m n o p q r s t u v w x y z A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".ToCharArray();

        public static void KeyCheck(KeyPressEventArgs e)
        {
            foreach (Char c in engAlph)
            {
                if (e.KeyChar != c)
                {
                    continue;
                }
                e.Handled = true;
            }
            
        }

        public static void KeyCheckForNum(KeyPressEventArgs e) 
        {
            foreach(Char c in numList) 
            {
                if (e.KeyChar != c)
                {
                    continue;
                }
                e.Handled = true;
            }
        }

        public static void KeyCheckForNotNum(KeyPressEventArgs e)
        {
            bool exo = false;
            foreach (Char c in numList)
            {
                if (e.KeyChar == c)
                {
                    exo = true;
                }
                
            }
            if (e.KeyChar == 8)
                exo = true;
            if (!exo) e.Handled = true;
        }

        public static void KeyCheckForNotNumForCars(KeyPressEventArgs e)
        {
            bool exo = false;
            foreach (Char c in numListForCars)
            {
                if (e.KeyChar == c)
                {
                    exo = true;
                }

            }
            if (e.KeyChar == 8)
                exo = true;
            if (!exo) e.Handled = true;
        }

        public static void KeyCheckForPucntMark(KeyPressEventArgs e)
        {
            foreach (Char c in punctMarkList)
            {
                if (e.KeyChar != c)
                {
                    continue;
                }
                e.Handled = true;
            }
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        
    }
}
