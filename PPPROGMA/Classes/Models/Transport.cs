using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    [Table("transport")]
    internal class Transport
    {
        [Key]
        public int idTransport { get; set; }
        public string Transport_name { get; set; }
        public decimal Transport_price { get; set; }
        public int idSprav_Transport_type { get; set; }
        public Sprav_transport_type Sprav_Transport_type { get; set; }

        [NotMapped]
        public string Sprav_Transport_type_name => Sprav_Transport_type.Sprav_Transport_typecol;
        [NotMapped]
        public ICollection<Transport_list> transport_List { get; set; }

        
    }
}
