using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Services_list
    {
        [Key]
        public int idServices_list { get; set; }
        public int idServices { get; set; }
        public Service Service { get; set; }
        [NotMapped]
        public string ServiceName => Service.Service_name;
        [NotMapped]
        public decimal ServicePrice => Service.Service_cost;
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; }
    }
}
