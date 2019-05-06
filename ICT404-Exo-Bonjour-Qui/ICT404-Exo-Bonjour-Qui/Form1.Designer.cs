namespace ICT404_Exo_Bonjour_Qui
{
    partial class lblBonjourQui
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnBienvenu = new System.Windows.Forms.Button();
            this.lblTexteNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.AccessibleName = "";
            this.txtboxName.Location = new System.Drawing.Point(153, 43);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(119, 20);
            this.txtboxName.TabIndex = 0;
            this.txtboxName.Tag = "";
            this.txtboxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBienvenu
            // 
            this.btnBienvenu.Enabled = false;
            this.btnBienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBienvenu.Location = new System.Drawing.Point(59, 145);
            this.btnBienvenu.Name = "btnBienvenu";
            this.btnBienvenu.Size = new System.Drawing.Size(150, 40);
            this.btnBienvenu.TabIndex = 1;
            this.btnBienvenu.Text = "Bienvenue";
            this.btnBienvenu.UseVisualStyleBackColor = true;
            this.btnBienvenu.Click += new System.EventHandler(this.Bienvenu_Click);
            // 
            // lblTexteNom
            // 
            this.lblTexteNom.AutoSize = true;
            this.lblTexteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexteNom.Location = new System.Drawing.Point(55, 43);
            this.lblTexteNom.Name = "lblTexteNom";
            this.lblTexteNom.Size = new System.Drawing.Size(92, 20);
            this.lblTexteNom.TabIndex = 2;
            this.lblTexteNom.Text = "Votre nom";
            this.lblTexteNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Location = new System.Drawing.Point(59, 106);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(22, 13);
            this.txtNom.TabIndex = 3;
            this.txtNom.Text = ". . .";
            this.txtNom.Click += new System.EventHandler(this.txtNom_Click);
            // 
            // lblBonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTexteNom);
            this.Controls.Add(this.btnBienvenu);
            this.Controls.Add(this.txtboxName);
            this.Name = "lblBonjourQui";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblBonjourQui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnBienvenu;
        private System.Windows.Forms.Label lblTexteNom;
        private System.Windows.Forms.Label txtNom;
    }
}

