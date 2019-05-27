using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandePizza
{



    public partial class frmPizza : Form
    {


        public frmPizza()
        {
            InitializeComponent();
        }

           
       

        private void btnCommander_Click_1(object sender, EventArgs e)
        {
            string reponse;

            reponse = "Pour la " + txtTables.Text + ": ";


            if (rdbExtraFine.Checked == true)
            {
                reponse = reponse + "Extra- fine ";
            }

            if (rdbFine.Checked)
            {
                reponse = reponse  + " : Fine, ";
            }

            if (rdbNormale.Checked)
            {
                reponse = reponse + " : Normale, ";
            }

            if (rdbEpaise.Checked)
            {
                reponse = reponse + " : Epaisse, ";
            }


            if (chkAnchois.Checked)
            {
                reponse = reponse + " Anchois, ";
            }


            if (chkCapres.Checked)
            {
                reponse = reponse + " Câpres, ";
            }


            if (chkJambon.Checked)
            {
                reponse = reponse + " Jambon, ";
            }


            if (chkCrevettes.Checked)
            {
                reponse = reponse + " Crevettes, ";
            }


            lblReponse.Text = Convert.ToString(reponse);






        }
    }
}

