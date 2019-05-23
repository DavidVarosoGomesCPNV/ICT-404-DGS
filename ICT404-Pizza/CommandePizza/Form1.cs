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
            lblListeCommandes.Visible = false;
        }

           
        private void btnCommander_Click(object sender, EventArgs e)
        {
            
            float t, nbtables;
            
            t = Convert.ToSingle(txtTables.Text);
            nbtables = t;

            
            lblListeCommandes.Visible = true;
            lblListeCommandes.Text = "Pour la " + nbtables +" :";
            

            if (rdbExtraFine.Checked)
            {
                lblCommande.Text = "Pour la " + nbtables + " : Extrafine, ";
            }

            if (rdbFine.Checked)
            {
                lblCommande.Text = "Pour la " + nbtables + " : Fine, ";
            }

            if (rdbNormale.Checked)
            {
                lblCommande.Text = "Pour la " + nbtables + " : Normale, ";
            }

            if (rdbEpaise.Checked)
            {
                lblCommande.Text = "Pour la " + nbtables + " : Epaisse, ";
            }

    









        }
    }
}

