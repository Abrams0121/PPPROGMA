using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    [Table("combinetion_of_tours")]
    internal class Combinetion_of_tours
    {
        [Key]
        public int idcombinetion_of_tours { get; set; }
        public string combinetion_of_tours_name { get; set; }
        public decimal combinetion_of_tours_price { get; set; }

        public ICollection<Combinetion_of_tours_list> combinetion_Of_Tours_List { get; set;}


        public void Insert()
        {
            Program.BD.combinetion_Of_Tours.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.combinetion_Of_Tours.Remove(this);
                return true;
            }
            return false;
        }

        public void Update()
        {
            Program.BD.SaveChanges();
        }

        public bool setName(string name)
        {
            if (name == combinetion_of_tours_name)
            {
                return true;
            }


            int count = Program.BD.combinetion_Of_Tours.Where(tv => tv.combinetion_of_tours_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            combinetion_of_tours_name = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.combinetion_Of_Tours_Lists.Include(v => v.idCombinetion_Of_Tours).Where(v => v.combinetion_Of_Tours == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
