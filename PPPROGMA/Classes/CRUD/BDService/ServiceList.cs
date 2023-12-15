using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class ServiceList : IDisposable
    {
        DbConnection DB;
        public ServiceList()
        {
            DB = new DbConnection();
        }

        public void Insert<T>(T ListEntry) where T : class 
        {
            DB.Set<T>().Add(ListEntry);
            DB.SaveChanges();
        }

        public static List<T> UpdateList<T>(int IdDay) where T : class
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.Set<T>().Where(x => (int)x.GetType().GetProperty("idTour_days").GetValue(x) == IdDay).ToList();
            }
        }

        public static List<Combinetion_of_tours_list> UpdateCombinetion_of_tours_List(int IdDay)
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.combinetion_Of_Tours_Lists.Include(x => x.combinetion_Of_Tours).Where(x => x.idTour_days == IdDay).ToList();
            }
        }
        public static List<Food_list> Updatefood_Lists(int IdDay)
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.food_Lists.Where(x => x.idTour_days == IdDay).ToList();
            }
        }
        public static List<General_service_list> UpdateGeneral_service_List(int IdDay)
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.general_service_list.Include(x => x.general_Service).Where(x => x.idTour_days == IdDay).ToList();
            }
        }
        public static List<Services_list> UpdateServices_list(int IdDay)
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.services_list.Include(x => x.Service).Where(x => x.idTour_days == IdDay).ToList();
            }
        }

        public static List<Transport_list> UpdateTransport_list(int IdDay)
        {
            using (DbConnection DBWORK = new DbConnection())
            {
                return DBWORK.transport_list.Include(x => x.Transport).Where(x => x.idTour_days == IdDay).ToList();
            }
        }

        public T GetEntity<T>(int Id) where T : class
        {
            return DB.Set<T>().Find(Id);
        }
        public void Delete<T>(T ListEntry) where T : class
        {
            DB.Set<T>().Remove(ListEntry);
            DB.SaveChanges();
        }

        

         public List<Tour_days> UpdateAccomodation(int IdDay)
        {
            return DB.tour_Days.Include(x => x.Accommodation).Where(x => x.idTour_days == IdDay).ToList();
        }

        public List<Tour_days> UpdateAccomodationForOutput(int idTour)
        {
            return DB.tour_Days.Include(x => x.Accommodation).Where(x => x.idTour == idTour).ToList();
        }

        public List<Tour_days> UpdateDaysListWithTour(int idTour)
        {
            return DB.tour_Days.Where(x => x.idTour == idTour).ToList();
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
