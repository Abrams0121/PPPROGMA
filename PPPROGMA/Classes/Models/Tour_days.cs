using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA.Classes.Models
{
    internal class Tour_days
    {
        [Key]
        public int idTour_days {  get; set; }
        public int Day_number { get; set; }
        public int idDays_list { get; set; }
        public Days_list Days_list { get; set; }
        public int idAccommodation { get; set; }
        public Accommodation Accommodation { get; set; }

        public ICollection<Food_list> Food_list { get; set; }
        public ICollection<General_service_list> General_service_list { get;set; }
        public ICollection<Transport_list> Transport_list { get; set;}
        public ICollection<Combinetion_of_tours_list> Combinetion_of_tours_list { get; set;}
        public ICollection<Services_list> Services_list { get; set;}
    }
}
