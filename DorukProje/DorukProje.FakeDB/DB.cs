using DorukProje.Entities.Concrete;
using DorukProje.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.FakeDB
{
    public class DB
    {
        public List<Emir> emirList;
        public DB()
        {
            emirList = new List<Emir>();

            emirList.Add(new Emir
            {
                id = 100,
                baslangic = DateTime.Now.AddHours(-5),
                bitis = DateTime.Now.AddHours(-1),
                durusNedeni = new List<DurusNedeni>
                {
                    new DurusNedeni { id=1,durusTip=DurusTip.Arge,emirId=100,durusBaslangic= DateTime.Now.AddHours(-4),durusBitis= DateTime.Now.AddHours(-3) },
                    new DurusNedeni { id=2,durusTip=DurusTip.Arıza,emirId=100,durusBaslangic= DateTime.Now.AddHours(-3),durusBitis= DateTime.Now.AddHours(-2) },
                    new DurusNedeni { id=3,durusTip=DurusTip.Mola,emirId=100,durusBaslangic= DateTime.Now.AddHours(-2),durusBitis= DateTime.Now.AddHours(-1) }
                }
            });

            emirList.Add(new Emir
            {
                id = 101,
                baslangic = DateTime.Now.AddHours(-6),
                bitis = DateTime.Now.AddHours(-2),
                durusNedeni = new List<DurusNedeni>
                {
                    new DurusNedeni { id=4,durusTip=DurusTip.Arge,emirId=101,durusBaslangic= DateTime.Now.AddHours(-5),durusBitis= DateTime.Now.AddHours(-4) },
                    new DurusNedeni { id=5,durusTip=DurusTip.Arıza,emirId=101,durusBaslangic= DateTime.Now.AddHours(-4),durusBitis= DateTime.Now.AddHours(-3) },
                    new DurusNedeni { id=6,durusTip=DurusTip.Mola,emirId=101,durusBaslangic= DateTime.Now.AddHours(-3),durusBitis= DateTime.Now.AddHours(-2) }
                }
            });

            emirList.Add(new Emir
            {
                id = 102,
                baslangic = DateTime.Now.AddHours(-7),
                bitis = DateTime.Now.AddHours(-1),
                durusNedeni = new List<DurusNedeni>
                {
                    new DurusNedeni { id=7,durusTip=DurusTip.Arge,emirId=102,durusBaslangic= DateTime.Now.AddHours(-6),durusBitis= DateTime.Now.AddHours(-4) },
                    new DurusNedeni { id=8,durusTip=DurusTip.Arıza,emirId=102,durusBaslangic= DateTime.Now.AddHours(-5),durusBitis= DateTime.Now.AddHours(-2) },
                    new DurusNedeni { id=9,durusTip=DurusTip.Mola,emirId=102,durusBaslangic= DateTime.Now.AddHours(-3),durusBitis= DateTime.Now.AddHours(-1) }
                }
            });




        }
    }
}
