using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT_404_ArcheDeNoé
{
    public partial class frmArche : Form
    {
        public frmArche()
        {
            InitializeComponent();



        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            string Item;

            int compteur1 = LBXGauche.Items.Count;
            int compteur2 = LBXDroite.Items.Count;

            Item = LBXGauche.SelectedItem.ToString();
            LBXGauche.Items.Remove(Item);
            LBXDroite.Items.Add(Item);
            compteur2++;
            compteur1--;
            

            if (compteur2 >= 7)
            {
                btnDroite.Enabled = false;
                btnGauche.Enabled = true;
          
            }
            else
            {
                btnDroite.Enabled = true;
                btnGauche.Enabled = true;
            }



        }

        private void btnGauche_Click(object sender, EventArgs e)
        {
            string Item;

            int compteur1 = LBXGauche.Items.Count;
            int compteur2 = LBXDroite.Items.Count;

            Item = LBXDroite.SelectedItem.ToString();
            LBXDroite.Items.Remove(Item);
            LBXGauche.Items.Add(Item);

            compteur2--;
            compteur1++;

            if (compteur1 >= 7)
            {
                btnDroite.Enabled = true;
                btnGauche.Enabled = false;
            }
            else
            {
                btnDroite.Enabled = true;
                btnGauche.Enabled = true;
            }
        }

        



    }
}
