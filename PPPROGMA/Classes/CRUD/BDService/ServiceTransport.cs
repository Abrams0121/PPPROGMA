using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class ServiceTransport : IDisposable
    {

        DbConnection DB;
        public ServiceTransport()
        {
            DB = new DbConnection();
        }

        public void Insert(Transport transport)
        {
            DB.transports.Add(transport);
            DB.SaveChanges();
        }

        public bool delete(Transport transport)
        {
            if (allowDel(transport))
            {
                DB.transports.Remove(transport);
                DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name, Transport transport)
        {
            /*if (name == transport.Transport_name)
            {
                return true;
            }*/


            int count = DB.transports.Where(tv => tv.Transport_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            transport.Transport_name = name;
            return true;
        }

        public bool allowDel(Transport transport)
        {
            int countInRefTable = DB.transport_list.Include(v => v.idTransport).Where(v => v.Transport == transport).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }


        public Transport ForUpdateTransport(int id)
        {
            return DB.transports.SingleOrDefault(x => x.idTransport == id);
        }

        public static List<Transport> SearchSpecific(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.transports.Include(x => x.Sprav_Transport_type).Where(x => x.idTransport == id).ToList();
            }
        }

        public static Transport UpdateTransport(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.transports.SingleOrDefault(x => x.idTransport == id);
            }
        }

        public static List<Transport> UpdateTransport()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.transports.Include(x => x.Sprav_Transport_type).ToList();
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
