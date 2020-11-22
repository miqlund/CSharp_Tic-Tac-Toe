using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class Form3 : Form
    {
        private List<global::Pelaaja> listaPelaajista;

        public static global::Pelaaja Pelaaja1;

        

        int valittuRivi = -1;
        bool muokkaus = false;

        public Form3()
        {
            InitializeComponent();

            //Tarkistetaan onko tallennustiedosto olemassa
            if (File.Exists("c:\\temp\\pelaajat.xml"))
            {
                listaPelaajista = DeserializeXML();
                dataGridView1.DataSource = listaPelaajista;
            }
            else
            {
                listaPelaajista = new List<global::Pelaaja>();
            }
        }

        //Tyhjennetään laatikot, jotta uusi pelaaja voidaan lisätä
        void Tyhjenna()
        {
            txtEtu.Text = "";
            txtSuku.Text = "";
            txtSP.Text = "";
            txtSK.Text = "";
            txtSV.Text = "";
        }

        //Tallennetaan tiedot
        public void SerializeXML(List<global::Pelaaja> input)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(input.GetType());
            StreamWriter sw = new StreamWriter("c:\\temp\\pelaajat.xml");
            serializer.Serialize(sw, input);
            sw.Close();
        }

        //Tuodaan tiedot
        public List<global::Pelaaja> DeserializeXML()
        {
            if (File.Exists("c:\\temp\\pelaajat.xml"))
            {
                StreamReader stream = new StreamReader("c:\\temp\\pelaajat.xml");
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<global::Pelaaja>));
                object obj = ser.Deserialize(stream);
                stream.Close();
                return (List<global::Pelaaja>)obj;
            }
            else
                return null;
        }

        //Näyttää valitun rivin
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            valittuRivi = dataGridView1.CurrentRow.Index;
        }

        //Lisää-nappi siirtää suoraan Uusi Pelaaja-tabiin
        private void btnLisaa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            muokkaus = false;
            Tyhjenna();
        }

        //Muokkaa-nappi muuttaa tietoja tarvittaessa
        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            Pelaaja pelaaja = listaPelaajista[valittuRivi];
            txtEtu.Text = pelaaja.Etunimi;
            txtSuku.Text = pelaaja.Sukunimi;

            tabControl1.SelectedIndex = 1;
            muokkaus = true;
            //
            //
            //
            // KORJAA
            //
            //
            //
        }

        //Poistaa valitun pelaajan
        private void btnPoista_Click(object sender, EventArgs e)
        {
            valittuRivi = dataGridView1.CurrentRow.Index;

            if (valittuRivi >= 0)
            {
                if (MessageBox.Show("Halutko varmasti poistaa pelaajan " + txtEtu.Text + "?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listaPelaajista.RemoveAt(valittuRivi);
                    SerializeXML(listaPelaajista);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listaPelaajista;
                }
            }
        }

        //Tallennetaan uusi pelaaja
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            Form2.pelaajan1Tiedot(txtEtu.Text, txtSuku.Text);

            global::Pelaaja pelaaja = new global::Pelaaja();

            try
            {
                //Otetaan tiedot talteen
                pelaaja.Etunimi = txtEtu.Text;
                pelaaja.Sukunimi = txtSuku.Text;
                pelaaja.Syntymaaika = txtSP.Text + "." + txtSK.Text + "." + txtSV.Text;

                //Kutsutaan tarkistus-fuktioita
                TarkistaEtunimi();
                TarkistaSukunimi();
                TarkistaPvm();

                if (muokkaus == false)
                {
                    //Lisätään listaan pelaaja
                    listaPelaajista.Add(pelaaja);
                }
                else
                {
                    listaPelaajista[valittuRivi] = pelaaja;
                }
                SerializeXML(listaPelaajista);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaPelaajista;
                muokkaus = false;
                tabControl1.SelectedIndex = 0;
                Tyhjenna();
            }
            //Annetaan virheilmoitus, jos jokin menee pieleen
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Virhe", MessageBoxButtons.OK);
            }
            Pelaaja1 = pelaaja;
        }

        //Jatketaan eteenpäin pelissä, kun haluttu pelaaja on valittu
        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haluatko pelata tietokonetta vastaan?", "Ristinolla", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Käynnistetään peli tietokonetta vastaan
                Form2.aiPeli = true;
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }

            else
            {
                //Valitaan toinen pelaaja listasta tai lisätään uusi
                Form4 f4 = new Form4();
                this.Hide();
                f4.ShowDialog();
                this.Close();
            }
        }

        //Tarkistetaan etunimi
        public void TarkistaEtunimi()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEtu.Text, "^[a-öA-Ö]+$"))
            {
                txtEtu.Text = "";
                throw new Exception("Syötä vain kirjaimia");
            }
        }

        //Tarkistetaan sukunimi
        public void TarkistaSukunimi()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSuku.Text, "^[a-öA-Ö]+$"))
            {
                txtSuku.Text = "";
                throw new Exception("Syötä vain kirjaimia");
            }
        }

        //Tarkistetaan päivämäärä
        public void TarkistaPvm()
        {
            int pp, kk, vvvv;

            //Tyhjät laatikot
            if (int.TryParse(txtSP.Text, out pp) == false ||
                int.TryParse(txtSK.Text, out kk) == false ||
                int.TryParse(txtSV.Text, out vvvv) == false)
            {
                throw new Exception("Päivämäärässä outoa tekstiä");
            }

            //Päivä tai kuukausi alle yhden
            if (pp < 1 || kk < 1)
            {
                throw new Exception("Päivät tai kuukaudet alle 1");
            }

            //Tutkitaan erikuukausien pituuksia
            switch (kk)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (pp > 31)
                    {
                        throw new Exception("Päivät yli 31");
                    }
                    break;
                case 2:
                    if (pp > 28)
                    {
                        throw new Exception("Päivät yli 28");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (pp > 30)
                    {
                        throw new Exception("Päivät yli 30");
                    }
                    break;
            }

            //Kuukausi yli 12
            if (kk > 12)
            {
                throw new Exception("Kuukaudet yli 12");
            }

            //Vuosi suurempi kuin menossa oleva
            if (vvvv > 2020)
            {
                throw new Exception("Olet syntynyt tulevaisuudessa");
            }

            //Vuosi liian vanha
            if (vvvv < 1880)
            {
                throw new Exception("Olet yli 140-vuotias");
            }
        }
    }
}
