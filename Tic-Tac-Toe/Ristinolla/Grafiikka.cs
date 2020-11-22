using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Ristinolla
{
    public class Grafiikka

    //Tehdään oma classi piirrustuksille
    {
        private static Graphics piirros;

        public Grafiikka(Graphics g)
        {
            piirros = g;
            TeeRuudukko();
        }

        //Tehdään ruudukko pelille
        public static void TeeRuudukko()
        {
            Brush tausta = new SolidBrush(Color.Gray);
            Pen viivat = new Pen(Color.Black, 5);

            piirros.FillRectangle(tausta, new Rectangle(5, 5, 595, 595));

            //Pystyviivat
            piirros.DrawLine(viivat, new Point(4, 4), new Point(4, 600));
            piirros.DrawLine(viivat, new Point(200, 4), new Point(200, 600));
            piirros.DrawLine(viivat, new Point(400, 4), new Point(400, 600));
            piirros.DrawLine(viivat, new Point(600, 4), new Point(600, 600));

            //Vaakaviivat
            piirros.DrawLine(viivat, new Point(4, 4), new Point(600, 4));
            piirros.DrawLine(viivat, new Point(4, 200), new Point(600, 200));
            piirros.DrawLine(viivat, new Point(4, 400), new Point(600, 400));
            piirros.DrawLine(viivat, new Point(4, 600), new Point(600, 600));
        }

        //Piirretään X
        public static void piirraX(Point paikka)
        {
            Pen xPen = new Pen(Color.Red, 20);
            int xKoko = paikka.X * 200;
            int yKoko = paikka.Y * 200;

            piirros.DrawLine(xPen, xKoko + 40, yKoko + 40, xKoko + 158, yKoko + 158);
            piirros.DrawLine(xPen, xKoko + 158, yKoko + 40, xKoko + 40, yKoko + 158);
        }

        //Piirretään O
        public static void piirraO(Point paikka)
        {
            Pen oPen = new Pen(Color.Green, 20);
            int xKoko = paikka.X * 200;
            int yKoko = paikka.Y * 200;

            piirros.DrawEllipse(oPen, xKoko + 20, yKoko + 20, 158, 158);
        }
    }
}
