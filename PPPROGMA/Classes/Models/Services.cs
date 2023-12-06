using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Services
    {
        [Key]
        public int idServices { get; set; }
        public string Service_name { get; set; }
        public decimal Service_cost { get; set; }
        public ICollection<Services_list> Services_list { get; set; }   
    }
}
