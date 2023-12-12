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
    [Table("general_service")]
    internal class General_service
    {
        [Key]
        public int idgeneral_Service { get; set; }
        public string general_Service_name { get; set; }
        public decimal general_Service_price { get; set;}
        public ICollection<General_service_list> general_Service_List { get; set; }

        public void Insert()
        {
            Program.BD.general_services.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.general_services.Remove(this);
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
            if (name == general_Service_name)
            {
                return true;
            }


            int count = Program.BD.general_services.Where(tv => tv.general_Service_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            general_Service_name = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.general_service_list.Include(v => v.idGeneral_Service).Where(v => v.general_Service == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
