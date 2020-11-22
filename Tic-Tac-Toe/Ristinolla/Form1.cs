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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Toiminnot valikon näppäimille
        private void btnUusiPeli_Click(object sender, EventArgs e)
        {
            //Siirrytään valitsemaan pelaaja peliin, suljetaan menu
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    
        private void btnTilastot_Click(object sender, EventArgs e)
        {
            //Avataan tilastot-osio
            var avaaTilastot = new Form6();
            avaaTilastot.Show();
        }
    
        private void btnTietoja_Click(object sender, EventArgs e)
        {
            //Tietoja pelistä
            MessageBox.Show("Tämän pelin teki Mikko kouluprojektia varten");
        }
 
        private void btnPoistu_Click(object sender, EventArgs e)
        {
            //Suljetaan peli
            Application.Exit();
        }
    }
}
