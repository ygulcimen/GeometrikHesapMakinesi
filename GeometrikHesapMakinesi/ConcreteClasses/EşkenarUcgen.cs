using GeometrikHesapMakinesi.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.ConcreteClasses
{
    class EşkenarUcgen : IUcgen
    {
        public double TabanKenar { get; set; }

        public double AlanHesapla()
        {
            return Math.Round(TabanKenar*TabanKenar*Math.Sqrt(3)/4,2);
        }

        public double CevreHesapla()
        {
            return 3*TabanKenar;
        }
    }
}
