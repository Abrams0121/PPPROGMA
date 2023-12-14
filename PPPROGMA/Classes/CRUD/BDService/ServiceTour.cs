using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    internal class ServiceTour
    {
        DbConnection DB;
        public ServiceTour()
        {
            DB = new DbConnection();
        }

        public void Insert(Tour tour)
        {
            DB.tours.Add(tour);
            DB.SaveChanges();
        }

        public void delete(Tour tour)
        {

            DB.tours.Remove(tour);
            DB.SaveChanges();
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public Tour ForUpdateTour(int id)
        {
            return DB.tours.SingleOrDefault(x => x.idTours == id);
        }

        public static Tour UpdateTour(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.tours.SingleOrDefault(x => x.idTours == id);
            }
        }

        public static List<Tour> UpdateTour()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.tours.ToList();
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
