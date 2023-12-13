using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    internal class Tour
    {
        [Key]
        public int idTours {  get; set; } 
        public string Tour_Name { get; set; }
        public decimal Tour_Cost_No_Marja { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Tour_start_date { get; set; }
        public decimal Tour_Cost_marja {  get; set; }
        public decimal Tour_cost_For_one_person { get; set; }
        public decimal Tour_Profit {  get; set; }

        public ICollection<Tour_days> tour_Days { get; set; }

    }
}
