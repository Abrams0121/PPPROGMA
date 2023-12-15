using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Food
    {
        [Key]
        public int idFood { get; set; }
        public decimal Food_price { get; set; }

    }
}
