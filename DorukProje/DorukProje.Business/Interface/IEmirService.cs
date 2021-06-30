using DorukProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DorukProje.Business.Interface
{
    public interface IEmirService
    {
        List<Emir> Rapor();
        List<Emir> EmirListele();
        List<DurusNedeni> DurusListele();
    }
}
