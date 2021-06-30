using DorukProje.Business.Interface;
using DorukProje.DataAccess.Interface;
using DorukProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.Business.Concrete
{
    public class EmirManager : IEmirService
    {
        private IEmirDal _emirDal;
        public EmirManager(IEmirDal emirDal)
        {
            _emirDal = emirDal;
        }
        public List<DurusNedeni> DurusListele()
        {
            return _emirDal.DurusListele();
        }

        public List<Emir> EmirListele()
        {
            return _emirDal.EmirListele();
        }

        public List<Emir> Rapor()
        {
            return _emirDal.Rapor();
        }
    }
}
