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
    [Table("services")]
    internal class Service
    {
        [Key]
        public int idServices { get; set; }
        public string Service_name { get; set; }
        public decimal Service_cost { get; set; }
        public ICollection<Services_list> Services_list { get; set; }

        
    }
}
