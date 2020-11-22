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
    public partial class Form6 : Form
    {
        private List<global::Pelaaja> listaPelaajista;

        public static global::Pelaaja Pelaaja1;

        int valittuRivi = -1;

        public Form6()
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            valittuRivi = dataGridView1.CurrentRow.Index;
        }

        //Suljetaan tilastot
        private void btnSeuraava_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
