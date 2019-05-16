namespace Fenetre_Rouge_Bleu
{
    partial class Form1
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
            this.btnHautGauche = new System.Windows.Forms.Button();
            this.btnBasGauche = new System.Windows.Forms.Button();
            this.btnBasDroite = new System.Windows.Forms.Button();
            this.btnHautDroite = new System.Windows.Forms.Button();
            this.btnBleu = new System.Windows.Forms.Button();
            this.btnRouge = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHautGauche
            // 
            this.btnHautGauche.Location = new System.Drawing.Point(13, 13);
            this.btnHautGauche.Name = "btnHautGauche";
            this.btnHautGauche.Size = new System.Drawing.Size(91, 34);
            this.btnHautGauche.TabIndex = 0;
            this.btnHautGauche.Text = "Haut/Gauche";
            this.btnHautGauche.UseVisualStyleBackColor = true;
            this.btnHautGauche.Click += new System.EventHandler(this.btnHautGauche_Click);
            // 
            // btnBasGauche
            // 
            this.btnBasGauche.Location = new System.Drawing.Point(12, 470);
            this.btnBasGauche.Name = "btnBasGauche";
            this.btnBasGauche.Size = new System.Drawing.Size(91, 34);
            this.btnBasGauche.TabIndex = 1;
            this.btnBasGauche.Text = "Bas/Gauche";
            this.btnBasGauche.UseVisualStyleBackColor = true;
            this.btnBasGauche.Click += new System.EventHandler(this.btnBasGauche_Click);
            // 
            // btnBasDroite
            // 
            this.btnBasDroite.Location = new System.Drawing.Point(385, 470);
            this.btnBasDroite.Name = "btnBasDroite";
            this.btnBasDroite.Size = new System.Drawing.Size(91, 34);
            this.btnBasDroite.TabIndex = 2;
            this.btnBasDroite.Text = "Bas/Droite";
            this.btnBasDroite.UseVisualStyleBackColor = true;
            this.btnBasDroite.Click += new System.EventHandler(this.btnBasDroite_Click);
            // 
            // btnHautDroite
            // 
            this.btnHautDroite.Location = new System.Drawing.Point(385, 12);
            this.btnHautDroite.Name = "btnHautDroite";
            this.btnHautDroite.Size = new System.Drawing.Size(91, 34);
            this.btnHautDroite.TabIndex = 3;
            this.btnHautDroite.Text = "Haut/Droite";
            this.btnHautDroite.UseVisualStyleBackColor = true;
            this.btnHautDroite.Click += new System.EventHandler(this.btnHautDroite_Click);
            // 
            // btnBleu
            // 
            this.btnBleu.Location = new System.Drawing.Point(193, 139);
            this.btnBleu.Name = "btnBleu";
            this.btnBleu.Size = new System.Drawing.Size(91, 34);
            this.btnBleu.TabIndex = 4;
            this.btnBleu.Text = "Bleu";
            this.btnBleu.UseVisualStyleBackColor = true;
            this.btnBleu.Click += new System.EventHandler(this.btnBleu_Click);
            // 
            // btnRouge
            // 
            this.btnRouge.Location = new System.Drawing.Point(193, 179);
            this.btnRouge.Name = "btnRouge";
            this.btnRouge.Size = new System.Drawing.Size(91, 34);
            this.btnRouge.TabIndex = 5;
            this.btnRouge.Text = "Rouge";
            this.btnRouge.UseVisualStyleBackColor = true;
            this.btnRouge.Click += new System.EventHandler(this.btnRouge_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(193, 280);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(91, 34);
            this.btnStats.TabIndex = 6;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(193, 364);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(91, 34);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 516);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnRouge);
            this.Controls.Add(this.btnBleu);
            this.Controls.Add(this.btnHautDroite);
            this.Controls.Add(this.btnBasDroite);
            this.Controls.Add(this.btnBasGauche);
            this.Controls.Add(this.btnHautGauche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Fenêtre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHautGauche;
        private System.Windows.Forms.Button btnBasGauche;
        private System.Windows.Forms.Button btnBasDroite;
        private System.Windows.Forms.Button btnHautDroite;
        private System.Windows.Forms.Button btnBleu;
        private System.Windows.Forms.Button btnRouge;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnQuitter;
    }
}

