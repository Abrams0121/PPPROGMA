using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD
{
    internal class Read : IDisposable
    {
        

        DbConnection DB;
        public Read()
        {
            DB = new DbConnection();
        }

        public static List<Sprav_transport_type> UpdateTranportType()
        {
            using (Read read = new Read())
            {
                return read.DB.sprav_transport_type.ToList();
            }
        }

        public List<T> UpdateList<T>() where T : class
        {
            return DB.Set<T>().ToList();
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
