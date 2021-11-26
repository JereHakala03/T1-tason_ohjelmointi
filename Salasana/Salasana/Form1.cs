using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salasana
{
    public partial class SalasanaFrom : Form
    {
        public SalasanaFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
        
        }

        private void TarkistaBT_Click_1(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Jyri" && SalasanaTB.Text == "Ja@kk0Ku1lta")
            {
                salasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheviestiLB.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
