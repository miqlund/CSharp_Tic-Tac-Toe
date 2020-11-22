using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Ristinolla
{
    class Tietokone
    {
        public static Valinta etsiJaValitsePaikka(Valinta[,] ruutu)
        {
            //Hyökkäys

            //Etsitään paikka tietokoneen siirroille, aloitetaan keskusruudusta
            Valinta liiku = new Valinta();
            liiku.ValitseArvo(Ruudukko.O);

            if (ruutu[1, 1].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(1, 1));
                return liiku;
            }

            //Etsitään onko O kahden suoria pystyriveissä
            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.O && ruutu[x, 1].HaeArvo() == Ruudukko.O && ruutu[x, 2].HaeArvo() == Ruudukko.B)
                {
                    liiku.ValitsePaikka(new Point(x, 2));
                    return liiku;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.B && ruutu[x, 1].HaeArvo() == Ruudukko.O && ruutu[x, 2].HaeArvo() == Ruudukko.O)
                {
                    liiku.ValitsePaikka(new Point(x, 0));
                    return liiku;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.O && ruutu[x, 1].HaeArvo() == Ruudukko.B && ruutu[x, 2].HaeArvo() == Ruudukko.O)
                {
                    liiku.ValitsePaikka(new Point(x, 1));
                    return liiku;
                }
            }

            //Etsitään onko O kahden suoria vaakariveissä
            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0,y].HaeArvo() == Ruudukko.O && ruutu[1,y].HaeArvo() == Ruudukko.O && ruutu[2,y].HaeArvo() == Ruudukko.B)
                {
                    liiku.ValitsePaikka(new Point(2, y));
                    return liiku;
                }
            }

            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0, y].HaeArvo() == Ruudukko.B && ruutu[1, y].HaeArvo() == Ruudukko.O && ruutu[2, y].HaeArvo() == Ruudukko.O)
                {
                    liiku.ValitsePaikka(new Point(0, y));
                    return liiku;
                }
            }

            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0, y].HaeArvo() == Ruudukko.O && ruutu[1, y].HaeArvo() == Ruudukko.B && ruutu[2, y].HaeArvo() == Ruudukko.O)
                {
                    liiku.ValitsePaikka(new Point(1, y));
                    return liiku;
                }
            }

            //Etsitään onko O kahden suoria kulmasta kulmaan
            if (ruutu[0,0].HaeArvo() == Ruudukko.O && ruutu[1,1].HaeArvo() == Ruudukko.O && ruutu[2,2].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(2, 2));
                return liiku;
            }
            else if (ruutu[2, 0].HaeArvo() == Ruudukko.O && ruutu[1, 1].HaeArvo() == Ruudukko.O && ruutu[0, 2].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(0, 2));
                return liiku;
            }

            if (ruutu[0, 2].HaeArvo() == Ruudukko.O && ruutu[1, 1].HaeArvo() == Ruudukko.O && ruutu[2, 0].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(2, 0));
                return liiku;
            }
            else if (ruutu[2, 2].HaeArvo() == Ruudukko.O && ruutu[1, 1].HaeArvo() == Ruudukko.O && ruutu[0, 0].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(0, 0));
                return liiku;
            }

            //Tarkastetaan onko keskipaikka vapaana
            if (ruutu[0, 0].HaeArvo() == Ruudukko.O && ruutu[1, 1].HaeArvo() == Ruudukko.B && ruutu[2, 2].HaeArvo() == Ruudukko.O)
            {
                liiku.ValitsePaikka(new Point(1, 1));
                return liiku;
            }

            else if (ruutu[0, 2].HaeArvo() == Ruudukko.O && ruutu[1, 1].HaeArvo() == Ruudukko.B && ruutu[2, 0].HaeArvo() == Ruudukko.O)
            {
                liiku.ValitsePaikka(new Point(1, 1));
                return liiku;
            }

            //Puolustus

            //Etsitään onko X kahden rivejä pystyriveissä
            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.X && ruutu[x, 1].HaeArvo() == Ruudukko.X && ruutu[x, 2].HaeArvo() == Ruudukko.B)
                {
                    liiku.ValitsePaikka(new Point(x, 2));
                    return liiku;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.B && ruutu[x, 1].HaeArvo() == Ruudukko.X && ruutu[x, 2].HaeArvo() == Ruudukko.X)
                {
                    liiku.ValitsePaikka(new Point(x, 0));
                    return liiku;
                }
            }

            for (int x = 0; x < 3; x++)
            {
                if (ruutu[x, 0].HaeArvo() == Ruudukko.X && ruutu[x, 1].HaeArvo() == Ruudukko.B && ruutu[x, 2].HaeArvo() == Ruudukko.X)
                {
                    liiku.ValitsePaikka(new Point(x, 1));
                    return liiku;
                }
            }

            //Etsitään onko X kahden rivejä vaakariveissä
            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0, y].HaeArvo() == Ruudukko.X && ruutu[1, y].HaeArvo() == Ruudukko.X && ruutu[2, y].HaeArvo() == Ruudukko.B)
                {
                    liiku.ValitsePaikka(new Point(2, y));
                    return liiku;
                }
            }

            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0, y].HaeArvo() == Ruudukko.B && ruutu[1, y].HaeArvo() == Ruudukko.X && ruutu[2, y].HaeArvo() == Ruudukko.X)
                {
                    liiku.ValitsePaikka(new Point(0, y));
                    return liiku;
                }
            }

            for (int y = 0; y < 3; y++)
            {
                if (ruutu[0, y].HaeArvo() == Ruudukko.X && ruutu[1, y].HaeArvo() == Ruudukko.B && ruutu[2, y].HaeArvo() == Ruudukko.X)
                {
                    liiku.ValitsePaikka(new Point(1, y));
                    return liiku;
                }
            }

            //Etsitään onko X kahden rivejä kulmasta kulmaan
            if (ruutu[0, 0].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.X && ruutu[2, 2].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(2, 2));
                return liiku;
            }

            else if (ruutu[2, 0].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.X && ruutu[0, 2].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(0, 2));
                return liiku;
            }

            if (ruutu[0, 2].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.X && ruutu[2, 0].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(2,0));
                return liiku;
            }

            else if (ruutu[2, 2].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.X && ruutu[0, 0].HaeArvo() == Ruudukko.B)
            {
                liiku.ValitsePaikka(new Point(0, 0));
                return liiku;
            }

            //Tarkastetaan onko keskipaikka vapaana
            if (ruutu[0, 0].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.B && ruutu[2, 2].HaeArvo() == Ruudukko.X)
            {
                liiku.ValitsePaikka(new Point(1, 1));
                return liiku;
            }

            else if (ruutu[0, 2].HaeArvo() == Ruudukko.X && ruutu[1, 1].HaeArvo() == Ruudukko.B && ruutu[2, 0].HaeArvo() == Ruudukko.X)
            {
                liiku.ValitsePaikka(new Point(1, 1));
                return liiku;
            }

            //Lisätään O minne tahansa, jos ei ole suoria
            List<Valinta> tyhjatRuudut = new List<Valinta>();

            foreach (Valinta v in ruutu)
            {
                if (v.HaeArvo() == Ruudukko.B)
                {
                    tyhjatRuudut.Add(v);
                }
            }

            liiku.ValitsePaikka(tyhjatRuudut.ToArray()[0].HaePaikka());

            return liiku;
        }
    }
}
