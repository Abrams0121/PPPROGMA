using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    internal class ServiceGeneralServices
    {
        DbConnection DB;
        public ServiceGeneralServices()
        {
            DB = new DbConnection();
        }

        public void Insert(General_service general_Service)
        {
            DB.general_services.Add(general_Service);
            DB.SaveChanges();
        }

        public bool delete(General_service general_Service)
        {
            if (allowDel(general_Service))
            {
                DB.general_services.Remove(general_Service);
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name, General_service general_Service)
        {
            if (name == general_Service.general_Service_name)
            {
                return true;
            }


            int count = DB.general_services.Where(tv => tv.general_Service_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            general_Service.general_Service_name = name;
            return true;
        }

        public bool allowDel(General_service general_Service)
        {
            int countInRefTable = DB.general_service_list.Include(v => v.idGeneral_Service).Where(v => v.general_Service == general_Service).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
