using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ristinolla
{
        public class Valinta
        {
            private Point paikka;
            private int arvo = Ruudukko.B;

            public void ValitsePaikka(Point p)
            {
                paikka = p;
            }
            public Point HaePaikka()
            {
                return paikka;
            }

            public void ValitseArvo(int i)
            {
                arvo = i;
            }

            public int HaeArvo()
            {
                return arvo;
            }
        }
}
