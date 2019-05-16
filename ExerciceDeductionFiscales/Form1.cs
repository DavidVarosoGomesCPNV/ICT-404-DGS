using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDeductionFiscales
{
    public partial class frmDeductionFiscale : Form
    {
        public frmDeductionFiscale()
        {
            InitializeComponent();
            lblRevenuImposable.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcul_Click(object sender, EventArgs e)
        {

            double RBrut;
            double CoefBrut;

            if (!double.TryParse(txtbxRevenuA.Text, out RBrut))
            {
                MessageBox.Show("Veuilez remplir la case revenu correctement !",
                "Sécurité");
                txtbxRevenuA.Focus();
                return;
            }

            if (!double.TryParse(txtbxCoefFamilial.Text, out CoefBrut))
            {
                MessageBox.Show("Veuilez remplir la case coefficient correctement !",
                "Sécurité");
                txtbxCoefFamilial.Focus();
                return;
            }


            float a, b, c, d, f, pourcents, reponse;

            a = Convert.ToSingle(txtbxRevenuA.Text);
            b = Convert.ToSingle(txtbxCoefFamilial.Text);
            c = Convert.ToSingle(txtbxDeductionJeune.Text);
            d = Convert.ToSingle(txtbxDeductionTransport.Text);
            f = Convert.ToSingle(txtbxDeductionfidel.Text);

            reponse = a / b;

           


            if (chkDeductionJeune.Checked == true)
            {

                reponse = reponse - c;

            }

            if (chkDeductionTransport.Checked == true)
            {
                reponse = reponse - d;
            }

            if (chkFidelite.Checked == true)
            {
                pourcents = f / 100;
                reponse = reponse - pourcents*100;
       
                           
            }


            lblRevenuImposable.Visible = true;
            lblRevenuImposable.Text = "Revenu imposable : " + reponse;


        }

        private void txtbxRevenuA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbxCoefFamilial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbxDeductionJeune_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbxDeductionTransport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbxDeductionfidel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbxRevenuA_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
