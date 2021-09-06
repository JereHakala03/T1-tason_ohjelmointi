using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroidenJarjestys

{
    public partial class Lukujenjarjestys : Form
    {
        List<int> jono = new List<int>();
        public Lukujenjarjestys()
        {
            InitializeComponent();
        }

        private void UusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (UusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] Taulukko = jono.ToArray();
                    Array.Sort(Taulukko);
                    foreach (var jasen in Taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;

                }
                else
                {
                    jono.Add(Int32.Parse(UusiLukuTB.Text));
                    UusiLukuTB.Text = "";
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }

        private void TyhjaaLomake()
        {
            UusiLukuTB.Text = "";
        }
    }
}

