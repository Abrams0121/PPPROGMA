using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD.Service
{
    internal class Service_Combination_Of_Tours : IDisposable
    {
        DbConnection DB;
        public Service_Combination_Of_Tours()
        {
            DB = new DbConnection();
        }

        public void Insert(Combinetion_of_tours combinetion_Of_Tours)
        {
            DB.combinetion_Of_Tours.Add(combinetion_Of_Tours);
            DB.SaveChanges();
        }

        public bool delete(Combinetion_of_tours combinetion_Of_Tours)
        {
            if (allowDel(combinetion_Of_Tours))
            {
                DB.combinetion_Of_Tours.Remove(combinetion_Of_Tours);
                DB.SaveChanges();
                return true;
            }
            return false;
        }

        public void Update()
        {
            DB.SaveChanges();
        }

        public bool setName(string name, Combinetion_of_tours combinetion_Of_Tours)
        {
            /*if (name == combinetion_Of_Tours.combinetion_of_tours_name)
            {
                return true;
            }*/


            int count = DB.combinetion_Of_Tours.Where(tv => tv.combinetion_of_tours_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            combinetion_Of_Tours.combinetion_of_tours_name = name;
            return true;
        }

        public bool allowDel(Combinetion_of_tours combinetion_Of_Tours)
        {
            int countInRefTable = DB.combinetion_Of_Tours_Lists.Include(v => v.idCombinetion_Of_Tours).Where(v => v.combinetion_Of_Tours == combinetion_Of_Tours).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }

        public Combinetion_of_tours ForUpdateTransport(int id)
        {
            return DB.combinetion_Of_Tours.SingleOrDefault(x => x.idcombinetion_of_tours == id);
        }

        public static Combinetion_of_tours UpdateCombinetion_of_tours(int id)
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.combinetion_Of_Tours.SingleOrDefault(x => x.idcombinetion_of_tours == id);
            }
        }

        public static List<Combinetion_of_tours> UpdateCombinetion_of_tours()
        {
            using (DbConnection DB = new DbConnection())
            {
                return DB.combinetion_Of_Tours.ToList();
            }
        }

        public void Dispose()
        {
            DB.Dispose();
        }
    }
}
