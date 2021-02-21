using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.Abstract_Classes
{
    interface IDortgen
    {
        double Uzunkenar { get; set; }
        double AlanHesapla();
        double CevreHesapla();
    }
}
