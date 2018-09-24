using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace III_10
{
    public partial class hiteltorlesztes : Form
    {
        public hiteltorlesztes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double K = double.Parse(textBox1.Text);
                double P = double.Parse(textBox2.Text);
                double n = double.Parse(textBox3.Text);

                double q = 1 + P / 100;
                label9.Text = String.Format("{0:0.###}", q);

                double ET = K * Math.Pow(q, n) * ((q - 1) / (Math.Pow(q, n) - 1));
                label10.Text = String.Format("{0:# ### ##0}", ET);

                double HT = ET / (12 + (13 * P) / 200);
                label11.Text = String.Format("{0:# ### ##0}", HT);

                double eves = n * ET;
                label12.Text = String.Format("{0:# ### ##0}", eves);

                double havi = 12 * n * HT;
                label13.Text = String.Format("{0:# ### ##0}", havi);


            }
            catch (Exception)
            {
                MessageBox.Show("Hibás adatmegadás, vagy üres szövegdoboz,");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = label9.Text = label10.Text = label11.Text = label12.Text = label13.Text = "";
        }
    }
}
