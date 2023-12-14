using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class Service_sprav_transport_type : IDisposable
    {
        DbConnection DB;
        public Service_sprav_transport_type() 
        {
            DB = new DbConnection();
        }

        public void Insert(Sprav_transport_type type)
        {
            DB.sprav_transport_type.Add(type);
            DB.SaveChanges();
        }

        public bool delete(Sprav_transport_type type)
        {
            if (allowDel(type))
            {
                DB.sprav_transport_type.Remove(type);
                DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name,Sprav_transport_type type)
        {
            /*if (name == type.Sprav_Transport_typecol)
            {
                return true;
            }*/


            int count = DB.sprav_transport_type.Where(tv => tv.Sprav_Transport_typecol == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            return true;
        }

        public bool allowDel(Sprav_transport_type type)
        {
            int countInRefTable = DB.transports.Include(v => v.Sprav_Transport_type).Where(v => v.Sprav_Transport_type == type).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }

        public Sprav_transport_type ForUpdateTransport(int id)
        {
            return DB.sprav_transport_type.SingleOrDefault(x => x.idSprav_Transport_type == id);
        }

        public static Sprav_transport_type UpdateTransport(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.sprav_transport_type.SingleOrDefault(x => x.idSprav_Transport_type == id);
            }
        }

        public static List<Sprav_transport_type> UpdateTransport()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.sprav_transport_type.ToList();
            }
        }


        public void Dispose() 
        {
            DB.Dispose();
        }   
    }
}
