using DorukProje.Entities.Enums;
using DorukProje.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;


namespace DorukProje.Entities.Concrete
{
    public class DurusNedeni : ITable
    {
        public int id { get; set; }
        public int emirId { get; set; }
        public DurusTip durusTip { get; set; }      
        public DateTime durusBaslangic { get; set; }
       public DateTime durusBitis { get; set; }

        private int _durusZamani;
        public int durusZamani
        {
            get 
            {
                var zaman = (durusBitis - durusBaslangic).TotalMinutes;
                return Convert.ToInt32(zaman);
            }

        }
    }
}
