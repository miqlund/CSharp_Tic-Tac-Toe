using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Ristinolla
{
    public class Ruudukko

    //Tehdään oma classi ruudukon toiminalle
    {
        public int TehdytSiirrot = 0;
        public int pelaaja1Voitot = 0;
        public int pelaaja2Voitot = 0;

        private Valinta[,] valinnat = new Valinta[3, 3];

        public bool PeliKaynnissa = false;

        //static System.Windows.Forms.Timer Ajastin = new System.Windows.Forms.Timer();

        public const int X = 0;
        public const int O = 1;
        public const int B = 2;

        public int pelaajanVuoro = X;

        public Ruudukko uusiRuudukko;

        //Palautetaan kenen vuoro
        public int kenenVuoro()
        {
            return pelaajanVuoro;
        }

        //Palautetaan pelaajan 1 voitot
        public int haePelaajan1Voitot()
        {
            return pelaaja1Voitot;
        }

        //Palautetaan pelaajan 2 voitot
        public int haePelaajan2Voitot()
        {
            return pelaaja2Voitot;
        }

        public void Ruudut()
        {
            PeliKaynnissa = true;
            //Ajastinohjelma();
            //Tehdään painallukset joka ruudulle
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    valinnat[x, y] = new Valinta();
                    valinnat[x, y].ValitseArvo(B);
                    valinnat[x, y].ValitsePaikka(new Point(x, y));
                }
            }
        }
            
        //Asetetaan arvot ruutujen painallukselle, jotta X ja O menee oikeaan ruutuun
        public void Osuma(Point paikka)
        {
            if (paikka.X <= 595 && paikka.X >= 0 && paikka.Y <= 595 && paikka.Y >= 0)
            {
                int x = 0;
                int y = 0;

                //Pystyrivit
                if (paikka.X < 200 && paikka.X > 0)
                {
                    x = 0;
                }
                else if (paikka.X > 200 && paikka.X < 400)
                {
                    x = 1;
                }
                else if (paikka.X > 400 && paikka.X < 595)
                {
                    x = 2;
                }

                //Vaakarivit
                if (paikka.Y < 200 && paikka.Y > 0)
                {
                    y = 0;
                }
                else if (paikka.Y > 200 && paikka.Y < 400)
                {
                    y = 1;
                }
                else if (paikka.Y > 400 && paikka.Y < 595)
                {
                    y = 2;
                }

                //Pelaajan X vuoro
                if (TehdytSiirrot % 2 == X)
                {
                    //Tarkistetaan että paikalla ei ole jo mitään
                    if (valinnat[x, y].HaeArvo() != B)
                        return;

                    //Merkataan valittu paikka
                    Grafiikka.piirraX(new Point(x, y));
                    valinnat[x, y].ValitseArvo(X);

                    //Pelaajan voitto
                    if (OnkoVoitto())
                    {
                        PeliKaynnissa = false;
                        MessageBox.Show("Sinä voitit, X");
                        pelaaja1Voitot++;
                        ResetoiLauta();
                        Grafiikka.TeeRuudukko();                        
                    }
                    //Tasapeli
                    else if (onkoLautaTaysi())
                    {
                        TasaPeli();
                        //TehdytSiirrot++;
                    }

                    //Tietokone vastutaja
                    if (Form2.haeAIPeli() && !OnkoVoitto())
                    {
                        //Pieni viive ennen siirron tekemistä
                        System.Threading.Thread.Sleep(500);

                        Valinta aiLiiku = Tietokone.etsiJaValitsePaikka(valinnat);
                        Grafiikka.piirraO(aiLiiku.HaePaikka());
                        valinnat[aiLiiku.HaePaikka().X, aiLiiku.HaePaikka().Y].ValitseArvo(O);

                        //Tietokoneen voitto
                        if (OnkoVoitto())
                        {
                            PeliKaynnissa = false;
                            MessageBox.Show("Tietokone voitti!");
                            pelaaja2Voitot++;
                            ResetoiLauta();
                            Grafiikka.TeeRuudukko();
                        }
                        //Tasapeli
                        else if (onkoLautaTaysi())
                        {
                            TasaPeli();
                        }

                        TehdytSiirrot++;
                        pelaajanVuoro = X;
                    }

                    pelaajanVuoro = O;
                }
                else //Pelaajan O vuoro
                {
                    Grafiikka.piirraO(new Point(x, y));
                    valinnat[x, y].ValitseArvo(O);

                    //Pelaaja O Voitti
                    if (OnkoVoitto())
                    {
                        MessageBox.Show("Sinä voitit, O");
                        pelaaja2Voitot++;
                        ResetoiLauta();
                        Grafiikka.TeeRuudukko();
                    }
                    //Tasapeli
                    else if (onkoLautaTaysi())
                    {
                        TasaPeli();
                    }

                    pelaajanVuoro = X;
                }

                TehdytSiirrot++;
            }
        }

        /// <summary>
        /// Tarkistetaan onko jompikumpi voittanut
        /// </summary>
        /// <returns>palautetaan true jos on</returns>
        public bool OnkoVoitto()
        {
            bool onVoitto = false;

            for (int x = 0; x < 3; x++)
            {
                //Pystysarakkeiden voitot
                if (valinnat[x, 0].HaeArvo() == X && valinnat[x, 1].HaeArvo() == X && valinnat[x, 2].HaeArvo() == X)
                {
                    return true;
                }
                if (valinnat[x, 0].HaeArvo() == O && valinnat[x, 1].HaeArvo() == O && valinnat[x, 2].HaeArvo() == O)
                {
                    return true;
                }

                //Etsitään voittoa ristikulmista
                switch (x)
                {
                    case 0:
                        if (valinnat[x,0].HaeArvo() == X && valinnat[x+1, 1].HaeArvo() == X && valinnat[x+2,2].HaeArvo() == X)
                        {
                            return true;
                        }
                        if (valinnat[x, 0].HaeArvo() == O && valinnat[x + 1, 1].HaeArvo() == O && valinnat[x + 2, 2].HaeArvo() == O)
                        {
                            return true;
                        }

                        break;

                //Toisen ristikulman voitto
                    case 2:
                        if (valinnat[x,0].HaeArvo() == X && valinnat[x-1,1].HaeArvo() == X && valinnat[x-2,2].HaeArvo() == X)
                        {
                            return true;
                        }
                        if (valinnat[x, 0].HaeArvo() == O && valinnat[x - 1, 1].HaeArvo() == O && valinnat[x - 2, 2].HaeArvo() == O)
                        {
                            return true;
                        }

                        break;
                }
            }
                //Vaakarivien voitot
            for (int y = 0; y < 3; y++)
            {
                if(valinnat[0, y].HaeArvo() == X && valinnat[1, y].HaeArvo() == X && valinnat[2, y].HaeArvo() == X)
                {
                    return true;
                }
                if (valinnat[0, y].HaeArvo() == O && valinnat[1, y].HaeArvo() == O && valinnat[2, y].HaeArvo() == O)
                {
                    return true;
                }
            }
            return onVoitto;
        }

        /// <summary>
        /// Resetoidaan lauta
        /// </summary>
        public void ResetoiLauta()
        {
            valinnat = new Valinta[3, 3];
            Ruudut();
        }

        /// <summary>
        /// Tarkistetaan onko lauta täysi
        /// </summary>
        /// <returns>palautetaan true jos lauta on täynnä</returns>
        public bool onkoLautaTaysi()
        {
            bool taysi = true;

            foreach (Valinta r in valinnat)
            {
                if (r.HaeArvo() == Ruudukko.B)
                {
                    taysi = false;
                }
            }
            return taysi;
        }

        //Kutsutaan tätä tasapelitilanteissa
        public void TasaPeli()
        {
            PeliKaynnissa = false;
            if (MessageBox.Show("Tasapeli! Haluatko pelata uudestaan?", "Ristinolla", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetoiLauta();             //Resetoidaan lauta
                Grafiikka.TeeRuudukko();    //piirretään lauta
            }
            else
            {
                Application.Exit();
            }
        }

        //public void Ajastinohjelma()
        //{
        //    if (PeliKaynnissa)
        //    {
        //        Ajastin.Interval = 5000;
        //        Ajastin.Start();

        //    }
        //    else
        //    {
        //        Ajastin.Stop();
        //        List<Pelaaja> lista = DeserializeXML();
        //        foreach (Pelaaja pelaaja in lista)
        //        {
        //            if (pelaaja.Etunimi == Form3.Pelaaja1.Etunimi)
        //            {
        //                MessageBox.Show("Olet pelannut, " + Ajastin.ToString());
        //            }
        //        }
        //    }
        //}

        ////Tallennetaan tiedot
        //public void SerializeXML(List<Pelaaja> input)
        //{
        //    System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
        //    StreamWriter sw = new StreamWriter("c:\\temp\\pelaajat.xml");
        //    serializer.Serialize(sw, input);
        //    sw.Close();
        //}

        ////Tuodaan tiedot
        //public List<Pelaaja> DeserializeXML()
        //{
        //    if (File.Exists("c:\\temp\\pelaajat.xml"))
        //    {
        //        StreamReader stream = new StreamReader("c:\\temp\\pelaajat.xml");
        //        System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Pelaaja>));
        //        object obj = ser.Deserialize(stream);
        //        stream.Close();
        //        return (List<Pelaaja>)obj;
        //    }
        //    else
        //        return null;
        //}
    }
}
