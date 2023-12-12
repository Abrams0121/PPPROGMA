using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Food_list
    {
        [Key]
        public int idfood_list {  get; set; }
        public decimal Food_price { get; set; }
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; }
    }
}
