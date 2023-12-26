using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Banka1")
            {
                Banka can = new Banka1();
                can.para = 50;
                can.ode();
            }
            else
            {
                Banka hop = new Banka2();
                hop.para = 60;
                hop.ode();
            }
        }
    }
}
