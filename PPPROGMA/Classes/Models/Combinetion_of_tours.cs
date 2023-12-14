using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    [Table("combinetion_of_tours")]
    internal class Combinetion_of_tours
    {
        [Key]
        public int idcombinetion_of_tours { get; set; }
        public string combinetion_of_tours_name { get; set; }
        public decimal combinetion_of_tours_price { get; set; }

        public ICollection<Combinetion_of_tours_list> combinetion_Of_Tours_List { get; set;}


        
    }
}
