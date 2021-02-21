using GeometrikHesapMakinesi.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.ConcreteClasses
{
    class Dikdörtgen : IDortgen
    {
        public double Uzunkenar { get; set ; }
        public double Kısakenar { get; set; }

        public double AlanHesapla()
        {
            return Uzunkenar * Kısakenar;
        }

        public double CevreHesapla()
        {
            return (Uzunkenar + Kısakenar) * 2;
        }
    }
}
