using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOrnek
{
    abstract class Banka
    {
        public int para { get; set; }
        abstract public void ode();
    }
    class Banka1 : Banka
    {
        public override void ode()
        {
            MessageBox.Show(para.ToString());
        }
    }
    class Banka2 : Banka
    {
        public override void ode()
        {
            MessageBox.Show(para.ToString());
        }
    }
}
