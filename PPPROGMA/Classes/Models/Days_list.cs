using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Days_list
    {
        [Key]
        public int idDays_list { get; set; }
        public int idTour { get; set; }
        public Tours tour { get; set; }
        public ICollection<Tour_days> tour_Days {  get; set; }  
    }
}
