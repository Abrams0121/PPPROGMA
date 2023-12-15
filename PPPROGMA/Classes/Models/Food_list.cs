using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    [Table("food_list")]
    internal class Food_list
    {
        [Key]
        [Column("idfood_list")]
        public int idfood_list {  get; set; }
        [Column("Food_price")]
        public decimal Food_price { get; set; }
        [Column("idTour_days")]
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; }
    }
}
