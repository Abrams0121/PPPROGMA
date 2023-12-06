using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class General_service_list
    {
        [Key]
        public int idgeneral_service_list {  get; set; }
        public int idGeneral_Service { get; set; }
        public General_service general_Service { get; set; }
        public int general_service_listcol_count { get; set; }
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; }

    }
}
