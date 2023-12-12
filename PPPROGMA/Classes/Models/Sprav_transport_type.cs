using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPPROGMA.Classes.Models
{
    internal class Sprav_transport_type
    {
        [Key]
        public int idSprav_Transport_type { get; set; }
        public string Sprav_Transport_typecol { get; set; }
        public ICollection<Transport> transport { get; set; }


        public void Insert()
        { 
            Program.BD.sprav_transport_type.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.sprav_transport_type.Remove(this);
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
            if (name == Sprav_Transport_typecol)
            {
                return true;
            }


            int count = Program.BD.sprav_transport_type.Where(tv => tv.Sprav_Transport_typecol == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            Sprav_Transport_typecol = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.transports.Include(v => v.idSprav_Transport_type).Where(v => v.Sprav_Transport_type == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
