using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT404_Exo_Bonjour_Qui
{
    public partial class lblBonjourQui : Form
    {
        public lblBonjourQui()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnBienvenu.Enabled = true;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Bienvenu_Click(object sender, EventArgs e)
        {
            txtNom.Text = "Bonjour " + cmdName.Text;
        }

        private void lblBonjourQui_Load(object sender, EventArgs e)
        {
            if (cmdName.Text == "")
                btnBienvenu.Enabled = false;
            else btnBienvenu.Enabled = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Voulez-vous vraiment quitter l'application ?",
            "FormClosing",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            Close();
        }
    }
}
