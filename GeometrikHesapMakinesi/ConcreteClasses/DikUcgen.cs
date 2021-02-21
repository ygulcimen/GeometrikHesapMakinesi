using GeometrikHesapMakinesi.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.ConcreteClasses
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get; set; }
        public double Yükseklik { get; set; }
        public double AlanHesapla()
        {
            return TabanKenar * Yükseklik / 2;
        }

        public double CevreHesapla()
        {
            return Math.Round(TabanKenar + Yükseklik + Math.Sqrt(TabanKenar * TabanKenar + Yükseklik * Yükseklik),2);
        }
    }
}
