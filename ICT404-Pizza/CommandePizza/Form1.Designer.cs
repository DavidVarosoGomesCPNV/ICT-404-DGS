namespace CommandePizza
{
    partial class frmPizza
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
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTables = new System.Windows.Forms.TextBox();
            this.GrpBoxPâtes = new System.Windows.Forms.GroupBox();
            this.rdbEpaise = new System.Windows.Forms.RadioButton();
            this.rdbNormale = new System.Windows.Forms.RadioButton();
            this.rdbFine = new System.Windows.Forms.RadioButton();
            this.rdbExtraFine = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.btnCommander = new System.Windows.Forms.Button();
            this.lblCommande = new System.Windows.Forms.Label();
            this.lblListeCommandes = new System.Windows.Forms.Label();
            this.GrpBoxPâtes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTable.Location = new System.Drawing.Point(32, 20);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(44, 18);
            this.lblTable.TabIndex = 0;
            this.lblTable.Text = "Table";
            // 
            // txtTables
            // 
            this.txtTables.Location = new System.Drawing.Point(82, 18);
            this.txtTables.Name = "txtTables";
            this.txtTables.Size = new System.Drawing.Size(32, 20);
            this.txtTables.TabIndex = 1;
            // 
            // GrpBoxPâtes
            // 
            this.GrpBoxPâtes.Controls.Add(this.rdbEpaise);
            this.GrpBoxPâtes.Controls.Add(this.rdbNormale);
            this.GrpBoxPâtes.Controls.Add(this.rdbFine);
            this.GrpBoxPâtes.Controls.Add(this.rdbExtraFine);
            this.GrpBoxPâtes.Location = new System.Drawing.Point(35, 75);
            this.GrpBoxPâtes.Name = "GrpBoxPâtes";
            this.GrpBoxPâtes.Size = new System.Drawing.Size(89, 127);
            this.GrpBoxPâtes.TabIndex = 2;
            this.GrpBoxPâtes.TabStop = false;
            this.GrpBoxPâtes.Text = "Pâtes";
            // 
            // rdbEpaise
            // 
            this.rdbEpaise.AutoSize = true;
            this.rdbEpaise.Location = new System.Drawing.Point(10, 97);
            this.rdbEpaise.Name = "rdbEpaise";
            this.rdbEpaise.Size = new System.Drawing.Size(62, 17);
            this.rdbEpaise.TabIndex = 3;
            this.rdbEpaise.TabStop = true;
            this.rdbEpaise.Text = "Epaisse";
            this.rdbEpaise.UseVisualStyleBackColor = true;
            // 
            // rdbNormale
            // 
            this.rdbNormale.AutoSize = true;
            this.rdbNormale.Location = new System.Drawing.Point(10, 74);
            this.rdbNormale.Name = "rdbNormale";
            this.rdbNormale.Size = new System.Drawing.Size(64, 17);
            this.rdbNormale.TabIndex = 2;
            this.rdbNormale.TabStop = true;
            this.rdbNormale.Text = "Normale";
            this.rdbNormale.UseVisualStyleBackColor = true;
            // 
            // rdbFine
            // 
            this.rdbFine.AutoSize = true;
            this.rdbFine.Location = new System.Drawing.Point(10, 51);
            this.rdbFine.Name = "rdbFine";
            this.rdbFine.Size = new System.Drawing.Size(45, 17);
            this.rdbFine.TabIndex = 1;
            this.rdbFine.TabStop = true;
            this.rdbFine.Text = "Fine";
            this.rdbFine.UseVisualStyleBackColor = true;
            // 
            // rdbExtraFine
            // 
            this.rdbExtraFine.AutoSize = true;
            this.rdbExtraFine.Location = new System.Drawing.Point(10, 28);
            this.rdbExtraFine.Name = "rdbExtraFine";
            this.rdbExtraFine.Size = new System.Drawing.Size(69, 17);
            this.rdbExtraFine.TabIndex = 0;
            this.rdbExtraFine.TabStop = true;
            this.rdbExtraFine.Text = "Extra-fine";
            this.rdbExtraFine.UseVisualStyleBackColor = true;
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(166, 103);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 3;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(166, 126);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 4;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(166, 149);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 5;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(166, 172);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 6;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Location = new System.Drawing.Point(188, 211);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(95, 33);
            this.btnCommander.TabIndex = 7;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(35, 260);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(60, 13);
            this.lblCommande.TabIndex = 8;
            this.lblCommande.Text = "Commande";
            // 
            // lblListeCommandes
            // 
            this.lblListeCommandes.AutoSize = true;
            this.lblListeCommandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblListeCommandes.Location = new System.Drawing.Point(38, 303);
            this.lblListeCommandes.Name = "lblListeCommandes";
            this.lblListeCommandes.Size = new System.Drawing.Size(0, 25);
            this.lblListeCommandes.TabIndex = 9;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.lblListeCommandes);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.GrpBoxPâtes);
            this.Controls.Add(this.txtTables);
            this.Controls.Add(this.lblTable);
            this.Name = "frmPizza";
            this.Text = "Pizzeria d\'Esteban";
            this.GrpBoxPâtes.ResumeLayout(false);
            this.GrpBoxPâtes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTables;
        private System.Windows.Forms.GroupBox GrpBoxPâtes;
        private System.Windows.Forms.RadioButton rdbExtraFine;
        private System.Windows.Forms.RadioButton rdbEpaise;
        private System.Windows.Forms.RadioButton rdbNormale;
        private System.Windows.Forms.RadioButton rdbFine;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Label lblListeCommandes;
    }
}

