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
            // frmArche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 533);
            this.Controls.Add(this.lblTerre);
            this.Name = "frmArche";
            this.Text = "Arche de Noé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerre;
    }
}

