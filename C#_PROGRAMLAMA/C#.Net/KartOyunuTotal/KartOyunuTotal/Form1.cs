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

namespace KartOyunuTotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox kart1 = new PictureBox();
        PictureBox kart2 = new PictureBox();
        string[] kartListe = Directory.GetFiles(@"");//kartların yolunu ver
        string[] kartdizi1 = new string[26];
        string[] kartdizi2 = new string[26];

        int sayi = 0;
        int skor = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(kartdizi1[sayi][26] == kartdizi2[sayi][26])
            {
                skor++;
                label2.Text = skor.ToString();
            }
            kart1.ImageLocation = kartdizi1[sayi];
            kart1.Location = new Point(250, 40);
            kart1.Size = new Size(100, 100);
            kart1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(kart1);

            kart2.ImageLocation = kartdizi2[sayi];
            kart2.Location = new Point(350, 240);
            kart2.Size = new Size(100, 100);
            kart2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(kart2);
            sayi++;
            if(sayi == 25)
            {
                MessageBox.Show("Oyun Bitti");
                sayi = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kartListe = Karistir(kartListe);
            kartIkiyeBol(kartListe);
        }

        private void kartIkiyeBol(string[] dizi)
        {
            for (int i = 0; i < kartListe.Length/2; i++)
            {
                kartdizi1[i] = dizi[i];
            }
            int x = 0;
            for (int i = 26; i < kartListe.Length; i++)
            {
                kartdizi2[x] = dizi[i];
                x++;
            }
        }

        private string[] Karistir(string[] x)
        {
            string[] CekilenKart = new string[x.Length];
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++) 
            {
                string kart = x[rnd.Next(0, x.Length)];
                if(!CekilenKart.Contains(kart))
                {
                    CekilenKart[i] = kart;
                }
                else
                {
                    i--;
                    continue;
                }
            }
            return CekilenKart;
        }
    }
}
