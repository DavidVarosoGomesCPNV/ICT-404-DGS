namespace ComboBox
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
            this.cbxhautgauche = new System.Windows.Forms.ComboBox();
            this.cbxbasgauche = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblEcolesSelectTXT = new System.Windows.Forms.Label();
            this.lblEcolesSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxhautgauche
            // 
            this.cbxhautgauche.FormattingEnabled = true;
            this.cbxhautgauche.Items.AddRange(new object[] {
            "Swisscom"});
            this.cbxhautgauche.Location = new System.Drawing.Point(22, 32);
            this.cbxhautgauche.Name = "cbxhautgauche";
            this.cbxhautgauche.Size = new System.Drawing.Size(121, 21);
            this.cbxhautgauche.TabIndex = 0;
            // 
            // cbxbasgauche
            // 
            this.cbxbasgauche.FormattingEnabled = true;
            this.cbxbasgauche.Location = new System.Drawing.Point(22, 341);
            this.cbxbasgauche.Name = "cbxbasgauche";
            this.cbxbasgauche.Size = new System.Drawing.Size(121, 21);
            this.cbxbasgauche.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 238);
            this.listBox1.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(197, 41);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 32);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(197, 133);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(106, 32);
            this.btnEffacer.TabIndex = 4;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(197, 244);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 32);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(197, 330);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(106, 32);
            this.btnquitter.TabIndex = 6;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(364, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 238);
            this.listBox2.TabIndex = 7;
            // 
            // lblEcolesSelectTXT
            // 
            this.lblEcolesSelectTXT.AutoSize = true;
            this.lblEcolesSelectTXT.Location = new System.Drawing.Point(364, 297);
            this.lblEcolesSelectTXT.Name = "lblEcolesSelectTXT";
            this.lblEcolesSelectTXT.Size = new System.Drawing.Size(106, 13);
            this.lblEcolesSelectTXT.TabIndex = 8;
            this.lblEcolesSelectTXT.Text = "écoles sélectionnées";
            // 
            // lblEcolesSelect
            // 
            this.lblEcolesSelect.AutoSize = true;
            this.lblEcolesSelect.Location = new System.Drawing.Point(404, 330);
            this.lblEcolesSelect.Name = "lblEcolesSelect";
            this.lblEcolesSelect.Size = new System.Drawing.Size(19, 13);
            this.lblEcolesSelect.TabIndex = 9;
            this.lblEcolesSelect.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEcolesSelect);
            this.Controls.Add(this.lblEcolesSelectTXT);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbxbasgauche);
            this.Controls.Add(this.cbxhautgauche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxhautgauche;
        private System.Windows.Forms.ComboBox cbxbasgauche;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblEcolesSelectTXT;
        private System.Windows.Forms.Label lblEcolesSelect;
    }
}

