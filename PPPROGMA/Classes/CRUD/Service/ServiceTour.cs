using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
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

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
