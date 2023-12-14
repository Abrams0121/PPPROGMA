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

        public List<T> UpdateList<T>(int IdDay) where T : class
        {
            return DB.Set<T>().Where(x => (int)x.GetType().GetProperty("idTour_days").GetValue(x) == IdDay).ToList();
        }

        public void Delete<T>(T ListEntry) where T : class
        {
            DB.Set<T>().Remove(ListEntry);
            DB.SaveChanges();
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
