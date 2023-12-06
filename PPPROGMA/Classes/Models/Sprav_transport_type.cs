using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Sprav_transport_type
    {
        [Key]
        public int idSprav_Transport_type { get; set; }
        public string Sprav_Transport_typecol { get; set; }
        public ICollection<Transport> transport { get; set; }
    }
}
