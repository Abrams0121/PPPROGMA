using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PPPROGMA
{
    internal class Autorisation
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public string User_FIO { get; set; }
        public string User_phone_number { get; set; }

        [NotMapped]
        internal static Autorisation AuthUser = null;

    }
}
