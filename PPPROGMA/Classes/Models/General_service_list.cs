using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [NotMapped]
        public string GeneralSerName => general_Service.general_Service_name;
        [NotMapped]
        public Decimal GeneralSerCost => general_Service.general_Service_price;
        public int idTour_days { get; set; }
        public Tour_days Tour_day { get; set; }

    }
}
