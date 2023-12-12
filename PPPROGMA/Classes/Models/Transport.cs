using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    [Table("transport")]
    internal class Transport
    {
        [Key]
        public int idTransport { get; set; }
        public string Transport_name { get; set; }
        public decimal Transport_price { get; set; }
        public int idSprav_Transport_type { get; set; }
        public Sprav_transport_type Sprav_Transport_type { get; set; }

        [NotMapped]
        public string Sprav_Transport_type_name => Sprav_Transport_type.Sprav_Transport_typecol;
        [NotMapped]
        public ICollection<Transport_list> transport_List { get; set; }

        public void Insert()
        {
            Program.BD.transports.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.transports.Remove(this);
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
            if (name == Transport_name)
            {
                return true;
            }


            int count = Program.BD.transports.Where(tv => tv.Transport_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            Transport_name = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.transport_list.Include(v => v.idTransport).Where(v => v.Transport == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}
