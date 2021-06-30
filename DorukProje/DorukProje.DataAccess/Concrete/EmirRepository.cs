using DorukProje.DataAccess.Interface;
using DorukProje.Entities.Concrete;
using DorukProje.FakeDB;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.DataAccess.Concrete
{
    public class EmirRepository : IEmirDal
    {
        public readonly DB db;

        public EmirRepository()
        {
            if (db ==null)
            {
                db = new DB();
            }
        }
        public List<DurusNedeni> DurusListele()
        {
            List<DurusNedeni> durusNedeni = new List<DurusNedeni>();
            foreach (var item in db.emirList.ToList())
            {
                foreach (var i in item.durusNedeni)
                {
                    DurusNedeni dd = new DurusNedeni { id = i.id, emirId = i.emirId, durusTip = i.durusTip, durusBaslangic = i.durusBaslangic, durusBitis = i.durusBitis };
                    durusNedeni.Add(dd);
                }
            }
            return durusNedeni;
        }

        public List<Emir> EmirListele()
        {
            List<Emir> isEmri = new List<Emir>();

            foreach (var item in db.emirList)
            {
                isEmri.Add(new Emir { id = item.id, baslangic = item.baslangic, bitis = item.bitis });
            }

            return isEmri;
        }

        public List<Emir> Rapor()
        {
            List<Emir> emirler = new List<Emir>();
            foreach (var item in db.emirList)
            {
                Emir emir = new Emir {id=item.id,baslangic=item.baslangic,bitis=item.bitis };

                List<DurusNedeni> dNeden = new List<DurusNedeni>();
                foreach (var i in item.durusNedeni)
                {
                    DurusNedeni durusNedeni = new DurusNedeni { id=i.id,emirId=i.emirId,durusBaslangic=i.durusBaslangic,durusBitis=i.durusBitis,durusTip=i.durusTip};
                    dNeden.Add(durusNedeni);
                }
                emir.durusNedeni = dNeden;
                emirler.Add(emir);
            }
            return emirler;
        }
    }
}
