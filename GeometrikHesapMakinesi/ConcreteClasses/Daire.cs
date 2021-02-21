using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrikHesapMakinesi.ConcreteClasses
{
    class Daire
    {
        public double YarıCap { get; set; }

        public double AlanHesapla()
        {
            return Math.Round(Math.PI * YarıCap * YarıCap,2);
        }
        public double CevreHesapla()
        {
            return Math.Round(2 * Math.PI * YarıCap,2);
        }

    }
}
