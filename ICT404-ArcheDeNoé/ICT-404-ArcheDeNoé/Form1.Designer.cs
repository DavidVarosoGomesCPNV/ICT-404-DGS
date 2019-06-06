namespace ICT_404_ArcheDeNoé
{
    partial class frmArche
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
            this.lblTerre = new System.Windows.Forms.Label();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.txtBord = new System.Windows.Forms.Label();
            this.LBXGauche = new System.Windows.Forms.ListBox();
            this.LBXDroite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTerre
            // 
            this.lblTerre.AutoSize = true;
            this.lblTerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerre.Location = new System.Drawing.Point(13, 13);
            this.lblTerre.Name = "lblTerre";
            this.lblTerre.Size = new System.Drawing.Size(148, 25);
            this.lblTerre.TabIndex = 0;
            this.lblTerre.Text = "Encore à terre";
            // 
            // btnDroite
            // 
            this.btnDroite.Location = new System.Drawing.Point(276, 60);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(75, 23);
            this.btnDroite.TabIndex = 3;
            this.btnDroite.Text = "===>";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Location = new System.Drawing.Point(276, 142);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(75, 23);
            this.btnGauche.TabIndex = 4;
            this.btnGauche.Text = "<====";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // txtBord
            // 
            this.txtBord.AutoSize = true;
            this.txtBord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBord.Location = new System.Drawing.Point(398, 13);
            this.txtBord.Name = "txtBord";
            this.txtBord.Size = new System.Drawing.Size(76, 25);
            this.txtBord.TabIndex = 5;
            this.txtBord.Text = "A bord";
            // 
            // LBXGauche
            // 
            this.LBXGauche.FormattingEnabled = true;
            this.LBXGauche.Items.AddRange(new object[] {
            "Cheval",
            "Aigle",
            "Chien",
            "Dragon",
            "Griffon",
            "Tiger",
            "Loup",
            "Requin"});
            this.LBXGauche.Location = new System.Drawing.Point(18, 60);
            this.LBXGauche.Name = "LBXGauche";
            this.LBXGauche.Size = new System.Drawing.Size(212, 446);
            this.LBXGauche.TabIndex = 6;
            // 
            // LBXDroite
            // 
            this.LBXDroite.FormattingEnabled = true;
            this.LBXDroite.Location = new System.Drawing.Point(384, 60);
            this.LBXDroite.Name = "LBXDroite";
            this.LBXDroite.Size = new System.Drawing.Size(212, 446);
            this.LBXDroite.TabIndex = 7;
            // 
            // frmArche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 533);
            this.Controls.Add(this.LBXDroite);
            this.Controls.Add(this.LBXGauche);
            this.Controls.Add(this.txtBord);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.lblTerre);
            this.Name = "frmArche";
            this.Text = "Arche de Noé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerre;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Label txtBord;
        private System.Windows.Forms.ListBox LBXGauche;
        private System.Windows.Forms.ListBox LBXDroite;
    }
}

