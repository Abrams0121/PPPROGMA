using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Transport_list
    {
        [Key]
        public int idTransport_list { get; set; }
        public int idTransport { get; set; }
        public Transport Transport { get; set; }
        [NotMapped]
        public string transportName => Transport.Transport_name;
        [NotMapped]
        public decimal transportPrice => Transport.Transport_price;
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; } 
    }
}
