using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvila
{
    public partial class ruokalistaForm : Form
    {
        public ruokalistaForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void meistaPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ruokalistaForm_Load(object sender, EventArgs e)
        {
            meistaLB.Text = "keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            meistaLB.Text += "9:00 - 14:30 joka päivä maanantaista torstaisiin ja perjantaisin \n";
            meistaLB.Text += "9:00 - 12:30. \n\n keudan oppilaskunnan kahvilasta lämpimien \n";
            meistaLB.Text += "juomien lisäksi virvokkeita ja lisäksi pientä purtavaa sekä makeista \n";
            meistaLB.Text += "Tervetuloa tutustumaan!";
            meistaLB.Font = new Font("Arial", 12);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MeistäBT_Click(object sender, EventArgs e)
        {

        }

        private void ruoatBT_Click(object sender, EventArgs e)
        {

        }

        private void juomatBT_Click(object sender, EventArgs e)
        {

        }

        private void herkutBT_Click(object sender, EventArgs e)
        {

        }
    }
}
