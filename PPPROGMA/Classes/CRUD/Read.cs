using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.CRUD
{
    internal static class Read
    {
        public static List<Sprav_transport_type> TransportTypeUpdate()
        {
            return Program.BD.sprav_transport_type.ToList();
        }
    }
}
