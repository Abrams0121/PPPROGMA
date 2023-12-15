using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class ServiceAvtorisation : IDisposable
    {
        DbConnection DB;
        public ServiceAvtorisation()
        {
            DB = new DbConnection();
        }

        public bool auth(string login, string password)
        {
            Autorisation user = DB.Autorisation
                .Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();

            if (user == null)
            {
                return false;
            }
            Program.User = user;
            return true;

        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
