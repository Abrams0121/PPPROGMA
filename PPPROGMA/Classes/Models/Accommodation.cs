using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    [Table("accommodation")]
    internal class Accommodation
    {
        [Key]
        public int idAccommodation { get; set; }
        public string Accommodation_name { get; set; }
        public decimal Price_for_one_person { get; set; }

        public ICollection<Tour_days> tour_Days { get; set; }


        
    }
}
