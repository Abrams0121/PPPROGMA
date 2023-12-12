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
    [Table("services")]
    internal class Service
    {
        [Key]
        public int idServices { get; set; }
        public string Service_name { get; set; }
        public decimal Service_cost { get; set; }
        public ICollection<Services_list> Services_list { get; set; }

        public void Insert()
        {
            Program.BD.services.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.services.Remove(this);
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
            if (name == Service_name)
            {
                return true;
            }


            int count = Program.BD.services.Where(tv => tv.Service_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            Service_name = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.services_list.Include(v => v.idServices).Where(v => v.Services == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
