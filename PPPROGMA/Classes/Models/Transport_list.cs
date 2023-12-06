using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Transport_list
    {
        [Key]
        public int idTransport_list {  get; set; }
        public int idTransport { get; set; }
        public Transport Transport { get; set; }
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; } 
    }
}
