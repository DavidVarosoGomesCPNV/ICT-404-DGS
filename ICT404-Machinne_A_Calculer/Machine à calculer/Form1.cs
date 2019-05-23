using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_à_calculer
{
    public partial class frmMachineCalcul : Form
    {
        public frmMachineCalcul()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            float Nb1, Nb2, ReponsePlus;
            double RBrut;
            
            if (!double.TryParse(txtNb1.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb1.Focus();
                return;
            }

            if (!double.TryParse(txtNb2.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb2.Focus();
                return;
            }


            Nb1 = Convert.ToSingle(txtNb1.Text);
            Nb2 = Convert.ToSingle(txtNb2.Text);


            ReponsePlus = Nb1 + Nb2;
            Convert.ToString(ReponsePlus);

            txtReponseFinal.Text = "= " + ReponsePlus;

        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            float Nb1, Nb2, ReponseMoins;

            double RBrut;
            if (!double.TryParse(txtNb1.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb1.Focus();
                return;
            }

            if (!double.TryParse(txtNb2.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb2.Focus();
                return;
            }


            Nb1 = Convert.ToSingle(txtNb1.Text);
            Nb2 = Convert.ToSingle(txtNb2.Text);


            ReponseMoins = Nb1 - Nb2;
            Convert.ToString(ReponseMoins);

            txtReponseFinal.Text = "= " + ReponseMoins;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            float Nb1, Nb2, ReponseMultiplication;

            double RBrut;
            if (!double.TryParse(txtNb1.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb1.Focus();
                return;
            }

            if (!double.TryParse(txtNb2.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb2.Focus();
                return;
            }

            Nb1 = Convert.ToSingle(txtNb1.Text);
            Nb2 = Convert.ToSingle(txtNb2.Text);


            ReponseMultiplication = Nb1 * Nb2;
            Convert.ToString(ReponseMultiplication);

            txtReponseFinal.Text = "= " + ReponseMultiplication;
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {

            double RBrut;
            if (!double.TryParse(txtNb1.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb1.Focus();
                return;
            }

            if (!double.TryParse(txtNb2.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case correctement, sans lettres de préférence !",
                "Sécurité");
                txtNb2.Focus();
                return;
            }
            float Nb1, Nb2, ReponseDivision;

            Nb1 = Convert.ToSingle(txtNb1.Text);
            Nb2 = Convert.ToSingle(txtNb2.Text);


            ReponseDivision = Nb1 / Nb2;
            Convert.ToString(ReponseDivision);
            
            txtReponseFinal.Text = "= " + ReponseDivision;
        }

        
      
    }
}
