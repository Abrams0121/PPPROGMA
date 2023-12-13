using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    internal class CrudService : IDisposable
    {
        DbConnection DB;
        public CrudService()
        {
            DB = new DbConnection();
        }

        public void Insert(Service service)
        {
            DB.services.Add(service);
            DB.SaveChanges();
        }

        public bool delete(Service service)
        {
            if (allowDel(service))
            {
                DB.services.Remove(service);
                DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name, Service service)
        {
            if (name == service.Service_name)
            {
                return true;
            }


            int count = DB.services.Where(tv => tv.Service_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            service.Service_name = name;
            return true;
        }

        public bool allowDel(Service service)
        {
            int countInRefTable = DB.services_list.Include(v => v.idServices).Where(v => v.Service == service).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}

