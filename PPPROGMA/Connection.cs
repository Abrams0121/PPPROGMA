using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPPROGMA
{
    internal class Connection
    {
        
        private static string connectionString = "Database=tourconstractorbd;Data Source=localhost;User Id=root;Password=qwerty;SSL mode=None";
        protected static MySqlConnection connection;
        protected static MySqlCommand command;

        static public MySqlDataAdapter dataAdapter;


        static bool EstablishConnection()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                command = new MySqlCommand("", connection);
                dataAdapter = new MySqlDataAdapter(command);

                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void Close() 
        {
            connection.Close();
            connection = null;
            command = null;
        }

        
    }
}
