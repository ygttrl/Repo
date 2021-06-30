using DorukProje.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.Entities.Concrete
{
    public class Emir :ITable
    {
        public int id { get; set; }
        public DateTime baslangic { get; set; }
        public DateTime bitis { get; set; }
        public List<DurusNedeni> durusNedeni { get; set; }
    }
}
