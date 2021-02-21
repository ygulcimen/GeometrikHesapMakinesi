using GeometrikHesapMakinesi.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.ConcreteClasses
{
    class Kare : IDortgen
    {
        public double Uzunkenar { get; set; }

        public double AlanHesapla()
        {
            return Uzunkenar * Uzunkenar;
        }

        public double CevreHesapla()
        {
            return 4 * Uzunkenar;
        }
    }
}
