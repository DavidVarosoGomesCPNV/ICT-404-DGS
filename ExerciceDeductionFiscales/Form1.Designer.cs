namespace ExerciceDeductionFiscales
{
    partial class frmDeductionFiscale
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
            this.lblRevenuA = new System.Windows.Forms.Label();
            this.lblCoefficientFamilial = new System.Windows.Forms.Label();
            this.txtbxRevenuA = new System.Windows.Forms.TextBox();
            this.txtbxCoefFamilial = new System.Windows.Forms.TextBox();
            this.chkDeductionJeune = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkDeductionTransport = new System.Windows.Forms.CheckBox();
            this.txtbxDeductionJeune = new System.Windows.Forms.TextBox();
            this.txtbxDeductionTransport = new System.Windows.Forms.TextBox();
            this.txtbxDeductionfidel = new System.Windows.Forms.TextBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRevenuA
            // 
            this.lblRevenuA.AutoSize = true;
            this.lblRevenuA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblRevenuA.Location = new System.Drawing.Point(22, 35);
            this.lblRevenuA.Name = "lblRevenuA";
            this.lblRevenuA.Size = new System.Drawing.Size(123, 16);
            this.lblRevenuA.TabIndex = 0;
            this.lblRevenuA.Text = "Revenu annuel brut";
            // 
            // lblCoefficientFamilial
            // 
            this.lblCoefficientFamilial.AutoSize = true;
            this.lblCoefficientFamilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.lblCoefficientFamilial.Location = new System.Drawing.Point(22, 83);
            this.lblCoefficientFamilial.Name = "lblCoefficientFamilial";
            this.lblCoefficientFamilial.Size = new System.Drawing.Size(115, 16);
            this.lblCoefficientFamilial.TabIndex = 1;
            this.lblCoefficientFamilial.Text = "Coefficient familial";
            // 
            // txtbxRevenuA
            // 
            this.txtbxRevenuA.Location = new System.Drawing.Point(225, 35);
            this.txtbxRevenuA.Name = "txtbxRevenuA";
            this.txtbxRevenuA.Size = new System.Drawing.Size(105, 20);
            this.txtbxRevenuA.TabIndex = 2;
            // 
            // txtbxCoefFamilial
            // 
            this.txtbxCoefFamilial.Location = new System.Drawing.Point(280, 79);
            this.txtbxCoefFamilial.Name = "txtbxCoefFamilial";
            this.txtbxCoefFamilial.Size = new System.Drawing.Size(50, 20);
            this.txtbxCoefFamilial.TabIndex = 3;
            // 
            // chkDeductionJeune
            // 
            this.chkDeductionJeune.AutoSize = true;
            this.chkDeductionJeune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDeductionJeune.Location = new System.Drawing.Point(59, 143);
            this.chkDeductionJeune.Name = "chkDeductionJeune";
            this.chkDeductionJeune.Size = new System.Drawing.Size(130, 21);
            this.chkDeductionJeune.TabIndex = 4;
            this.chkDeductionJeune.Text = "Déduciton jeune";
            this.chkDeductionJeune.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBox1.Location = new System.Drawing.Point(59, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Déduciton fidélité (%)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkDeductionTransport
            // 
            this.chkDeductionTransport.AutoSize = true;
            this.chkDeductionTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDeductionTransport.Location = new System.Drawing.Point(59, 179);
            this.chkDeductionTransport.Name = "chkDeductionTransport";
            this.chkDeductionTransport.Size = new System.Drawing.Size(152, 21);
            this.chkDeductionTransport.TabIndex = 6;
            this.chkDeductionTransport.Text = "Déduciton transport";
            this.chkDeductionTransport.UseVisualStyleBackColor = true;
            // 
            // txtbxDeductionJeune
            // 
            this.txtbxDeductionJeune.Location = new System.Drawing.Point(280, 143);
            this.txtbxDeductionJeune.Name = "txtbxDeductionJeune";
            this.txtbxDeductionJeune.Size = new System.Drawing.Size(50, 20);
            this.txtbxDeductionJeune.TabIndex = 7;
            // 
            // txtbxDeductionTransport
            // 
            this.txtbxDeductionTransport.Location = new System.Drawing.Point(280, 179);
            this.txtbxDeductionTransport.Name = "txtbxDeductionTransport";
            this.txtbxDeductionTransport.Size = new System.Drawing.Size(50, 20);
            this.txtbxDeductionTransport.TabIndex = 8;
            // 
            // txtbxDeductionfidel
            // 
            this.txtbxDeductionfidel.Location = new System.Drawing.Point(280, 223);
            this.txtbxDeductionfidel.Name = "txtbxDeductionfidel";
            this.txtbxDeductionfidel.Size = new System.Drawing.Size(50, 20);
            this.txtbxDeductionfidel.TabIndex = 9;
            // 
            // btnCalcul
            // 
            this.btnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCalcul.Location = new System.Drawing.Point(128, 304);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(93, 31);
            this.btnCalcul.TabIndex = 10;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.UseVisualStyleBackColor = true;
            // 
            // frmDeductionFiscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 451);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.txtbxDeductionfidel);
            this.Controls.Add(this.txtbxDeductionTransport);
            this.Controls.Add(this.txtbxDeductionJeune);
            this.Controls.Add(this.chkDeductionTransport);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chkDeductionJeune);
            this.Controls.Add(this.txtbxCoefFamilial);
            this.Controls.Add(this.txtbxRevenuA);
            this.Controls.Add(this.lblCoefficientFamilial);
            this.Controls.Add(this.lblRevenuA);
            this.Name = "frmDeductionFiscale";
            this.Text = "Déductions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenuA;
        private System.Windows.Forms.Label lblCoefficientFamilial;
        private System.Windows.Forms.TextBox txtbxRevenuA;
        private System.Windows.Forms.TextBox txtbxCoefFamilial;
        private System.Windows.Forms.CheckBox chkDeductionJeune;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkDeductionTransport;
        private System.Windows.Forms.TextBox txtbxDeductionJeune;
        private System.Windows.Forms.TextBox txtbxDeductionTransport;
        private System.Windows.Forms.TextBox txtbxDeductionfidel;
        private System.Windows.Forms.Button btnCalcul;
    }
}

