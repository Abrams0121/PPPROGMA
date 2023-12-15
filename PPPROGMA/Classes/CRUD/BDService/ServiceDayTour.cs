using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class ServiceDayTour : IDisposable
    {
        private DbConnection DB;
        public ServiceDayTour()
        {
            DB = new DbConnection();
        }

        public void Insert(Tour_days tour_days)
        {
            DB.tour_Days.Add(tour_days);
            DB.SaveChanges();
        }

        public bool delete(Tour_days tour_days)
        {
            DB.tour_Days.Remove(tour_days);
            DB.SaveChanges();
            return true;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public static int Max(int idTour)
        {
            try
            {
                using (DbConnection DB = new DbConnection())
                {
                    return DB.tour_Days.Where(x => x.idTour == idTour).Max(x => x.Day_number);
                }
            }
            catch (Exception)
            {
                
                Utils.Error("Ошибка отбора максимального числа");
                return 0;
            }
        }

        public Tour_days ForUpdateServicet(int id)
        {
            return DB.tour_Days.SingleOrDefault(x => x.idTour_days == id);
        }

        public static Tour_days UpdateService(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.tour_Days.SingleOrDefault(x => x.idTour_days == id);
            }
        }

        public static List<Tour_days> UpdateService()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.tour_Days.ToList();
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
