using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class ServiceAccomodation : IDisposable
    {
        DbConnection DB;
        public ServiceAccomodation()
        {
            DB = new DbConnection();
        }

        public void Insert(Accommodation accommodation)
        {
            DB.accommodations.Add(accommodation);
            DB.SaveChanges();
        }

        public bool delete(Accommodation accommodation)
        {
            if (allowDel(accommodation))
            {
                DB.accommodations.Remove(accommodation);
                DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name, Accommodation accommodation)
        {
            /*if (name == accommodation.Accommodation_name)
            {
                return true;
            }*/


            int count = DB.accommodations.Where(tv => tv.Accommodation_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            accommodation.Accommodation_name = name;
            return true;
        }

        public bool allowDel(Accommodation accommodation)
        {
            int countInRefTable = DB.tour_Days.Include(v => v.Accommodation).Where(v => v.Accommodation == accommodation).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }

        public Accommodation ForUpdateAccommodation(int id)
        {
            return DB.accommodations.SingleOrDefault(x => x.idAccommodation == id);
        }

        public static Accommodation UpdateAccommodation(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.accommodations.SingleOrDefault(x => x.idAccommodation == id);
            }
        }

        public static List<Accommodation> UpdateAccommodation()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.accommodations.ToList();
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
