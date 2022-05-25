using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamostalniPRojekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zaposleniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaposleni Sta = new Zaposleni();
            Sta.Show();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvod staGod = new Proizvod("Proizvod");
            staGod.Show();
        }

        private void kupciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvod staGod = new Proizvod("Kupac");
            staGod.Show();
        }
    }
}
