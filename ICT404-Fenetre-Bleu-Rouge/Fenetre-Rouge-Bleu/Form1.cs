using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenetre_Rouge_Bleu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Deplacements;
        double Couleurs;

        private void btnHautGauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            Deplacements++;
            
        }   
        private void btnBasGauche_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 485);
            Deplacements++;
        }

        private void btnHautDroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1400, 0);
            Deplacements++;
        }

        private void btnBasDroite_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1400, 485);
            Deplacements++;
        }

        private void btnRouge_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
            Couleurs++;

        }

        private void btnBleu_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
            Couleurs++;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Deplacements + " déplacement(s), " + Couleurs + " changements de couleur.");
        }
    }
}
