using DorukProje.Entities.Concrete;
using DorukProje.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.DataAccess.Interface
{
    public interface IEmirDal 
    {
        List<Emir> Rapor();
        List<Emir> EmirListele();
        List<DurusNedeni> DurusListele();
    }
}
