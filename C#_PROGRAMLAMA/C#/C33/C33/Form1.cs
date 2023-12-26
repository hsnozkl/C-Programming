using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            int sembol3;

            Random can = new Random();
            int sayi1, sayi2, sayi3;
            sayi1 = can.Next(0, sembol1.Length);
            sayi2 = can.Next(0, sembol2.Length);
            sayi3 = can.Next(0, 20);

            label1.Text = sembol1[sayi1].ToString() + sembol2[sayi2].ToString() + sayi2;
        }
    }
}
