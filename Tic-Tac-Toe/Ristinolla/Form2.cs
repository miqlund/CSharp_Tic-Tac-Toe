using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Form2 : Form
    {
        public Grafiikka moottori;
        public Ruudukko OikeaRuudukko;
        public static bool aiPeli = false;
        static string etunimi1, sukunimi1;
        static string etunimi2, sukunimi2;

        //Haetaan peli tietokonetta vastaan
        public static bool haeAIPeli()
        {
            return aiPeli;
        }

        public Form2()
        {
            InitializeComponent();
        }

        //Pelaajan 1 tiedot
        public static void pelaajan1Tiedot(string etu1, string suku1)
        {
            etunimi1 = etu1;
            sukunimi1 = suku1;
        }

        //Pelaajan 2 tiedot
        public static void pelaajan2Tiedot(string etu2, string suku2)
        {
            etunimi1 = etu2;
            sukunimi1 = suku2;
        }

        //Tehdään eventti piirrustuksille ja kutsutaan grafiikkaa ja sen komponentteja
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panel1.CreateGraphics();
            moottori = new Grafiikka(toPass);

            OikeaRuudukko = new Ruudukko();
            OikeaRuudukko.Ruudut();

            refreshlabel1();
        }

        //Tehdään eventti paneelin klikkauksille ja kutsutaan ruudukkoa ja sen komponentteja
        private void panel1_Click(object sender, EventArgs e)
        {
            // Klikkauksen paikka
            Point hiiri = Cursor.Position;
            hiiri = panel1.PointToClient(hiiri);

            //Etsii minne klikkaus meni
            OikeaRuudukko.Osuma(hiiri);

            // Päivitetään vuoro ja tilastot
            refreshlabel1();
        }

        //Kertoo kenen vuoro menossa ja montako voittoa pelaajilla on
            //
            //
            //
            // KORJAA
            //
            //
            //
        public void refreshlabel1()
        {
            string newText = "Vuorossa: ";
            if (OikeaRuudukko.kenenVuoro() == Ruudukko.X)
            {
                newText += "X";
            }
            else
            {
                newText += "O";
            }
            newText += "\nX on voittanut " + OikeaRuudukko.haePelaajan1Voitot() + " kertaa\nO on voittanut " + OikeaRuudukko.haePelaajan2Voitot() + " kertaa";

            label1.Text = newText;
        }

        //Tehdään valinnat pelinsisäiselle menulle
        private void toolmenuPoistu_Click(object sender, EventArgs e)
        {
            //Suljetaan sovellus
            Application.Exit();
        }
      
        private void toolmenuTietoja_Click(object sender, EventArgs e)
        {
            //Avataan tiedot pelissä
            MessageBox.Show("Tämän pelin teki Mikko kouluprojektia varten");
        }
       
        private void toolmenuTilastot_Click(object sender, EventArgs e)
        {
            //Avataan tilastot pelissä
            var avaaTilastot = new Form6();
            avaaTilastot.Show();
        }

        private void toolmenuUusiPeli_Click(object sender, EventArgs e)
        {
            //Aloitetaan uusi peli pelinsisäisessä menussa
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
