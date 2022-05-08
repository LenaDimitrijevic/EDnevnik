using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDnevnik
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void Glavna2FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Raspodela frm_raspodela = new Raspodela();
            frm_raspodela.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Ocena frm_ocena = new Ocena();
            frm_ocena.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Upisnica frm_upisnica = new Upisnica();
            frm_upisnica.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Smer");
            frm_smer.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Skolska_godina");
            frm_smer.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Sifarnik frm_smer = new Sifarnik("Predmet");
            frm_smer.Show();
        }

        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
