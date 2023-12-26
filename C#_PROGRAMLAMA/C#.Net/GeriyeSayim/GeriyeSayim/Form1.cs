using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriyeSayim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private int saniye = 100;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(saniye > 0) 
            {
                saniye--;
                progressBar2.Value++;
                label4.Text = saniye + " saniye kaldı";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Süre Doldu");
            }
        }
    }
}
