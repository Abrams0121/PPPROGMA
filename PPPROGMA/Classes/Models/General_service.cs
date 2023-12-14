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
    [Table("general_service")]
    internal class General_service
    {
        [Key]
        public int idgeneral_Service { get; set; }
        public string general_Service_name { get; set; }
        public decimal general_Service_price { get; set;}
        public ICollection<General_service_list> general_Service_List { get; set; }

        
    }
}
