using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Combinetion_of_tours_list
    {
        [Key]
        public int idcombinetion_of_tours_list { get; set; }

        public int idCombinetion_Of_Tours { get; set; }
        public Combinetion_of_tours combinetion_Of_Tours { get; set; }

        public int idTour_days { get; set; }
        public Tour_days Tour_days { get; set; }
    }
}
