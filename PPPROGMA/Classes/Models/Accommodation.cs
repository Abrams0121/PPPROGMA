﻿using Microsoft.EntityFrameworkCore;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPROGMA
{
    [Table("accommodation")]
    internal class Accommodation
    {
        [Key]
        public int idAccommodation { get; set; }
        public string Accommodation_name { get; set; }
        public decimal Price_for_one_person { get; set; }

        public ICollection<Tour_days> tour_Days { get; set; }


        public void Insert()
        {
            Program.BD.accommodations.Add(this);
            Program.BD.SaveChanges();
        }

        public bool delete()
        {
            if (allowDel())
            {
                Program.BD.accommodations.Remove(this);
                return true;
            }
            return false;
        }

        public void Update()
        {
            Program.BD.SaveChanges();
        }

        public bool setName(string name)
        {
            if (name == Accommodation_name)
            {
                return true;
            }


            int count = Program.BD.accommodations.Where(tv => tv.Accommodation_name == name).Count();
            if (count > 0)
            {
                Utils.Warning("Дублирование значения");
                return false;
            }

            Accommodation_name = name;
            return true;
        }

        public bool allowDel()
        {
            int countInRefTable = Program.BD.tour_Days.Include(v => v.idAccommodation).Where(v => v.Accommodation == this).Count();

            if (countInRefTable > 0)
            {
                Utils.Warning("Удаление записи приведет к потере данных", "Нельзя удалить запись");
            }

            return countInRefTable == 0;
        }
    }
}