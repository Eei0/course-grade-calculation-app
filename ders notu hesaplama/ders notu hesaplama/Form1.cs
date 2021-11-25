using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_notu_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstisim.Items.Clear();
            lstsoyisim.Items.Clear();
            lstnot1.Items.Clear();
            lstnot2.Items.Clear();
            lstort.Items.Clear();
            lstsnç.Items.Clear();

        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            double not1 = Convert.ToDouble(txtnot1.Text);
            double not2 = Convert.ToDouble(txtnot2.Text);

            double ort = (not1 + not2) / 2;
            lstisim.Items.Add(txtad.Text);
            lstsoyisim.Items.Add(txtsoyad.Text);
            lstnot1.Items.Add(txtnot1.Text);
            lstnot2.Items.Add(txtnot2.Text);
            lstort.Items.Add(ort);

            if (ort<50)
            {
                lstsnç.Items.Add("ORTALAMA: "+ort + " KALDINIZ");
            }
            else
            {
                lstsnç.Items.Add("ORTALAMA: " + ort+" GEÇTİNİZ");    
            }
            txtad.Clear();
            txtsoyad.Clear();
            txtnot1.Clear();
            txtnot2.Clear();
            
             
            

            
        }
    }
}
