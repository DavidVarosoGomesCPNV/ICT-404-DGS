namespace Machine_à_calculer
{
    partial class frmMachineCalcul
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
            this.lblNb1 = new System.Windows.Forms.Label();
            this.lblNb2 = new System.Windows.Forms.Label();
            this.txtNb1 = new System.Windows.Forms.TextBox();
            this.txtNb2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMoins = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.txtReponseFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNb1
            // 
            this.lblNb1.AutoSize = true;
            this.lblNb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNb1.Location = new System.Drawing.Point(36, 30);
            this.lblNb1.Name = "lblNb1";
            this.lblNb1.Size = new System.Drawing.Size(97, 25);
            this.lblNb1.TabIndex = 0;
            this.lblNb1.Text = "Nombre 1";
            // 
            // lblNb2
            // 
            this.lblNb2.AutoSize = true;
            this.lblNb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNb2.Location = new System.Drawing.Point(36, 101);
            this.lblNb2.Name = "lblNb2";
            this.lblNb2.Size = new System.Drawing.Size(97, 25);
            this.lblNb2.TabIndex = 1;
            this.lblNb2.Text = "Nombre 2";
            // 
            // txtNb1
            // 
            this.txtNb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNb1.Location = new System.Drawing.Point(186, 27);
            this.txtNb1.Name = "txtNb1";
            this.txtNb1.Size = new System.Drawing.Size(100, 30);
            this.txtNb1.TabIndex = 2;
            // 
            // txtNb2
            // 
            this.txtNb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNb2.Location = new System.Drawing.Point(186, 96);
            this.txtNb2.Name = "txtNb2";
            this.txtNb2.Size = new System.Drawing.Size(100, 30);
            this.txtNb2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnPlus.Location = new System.Drawing.Point(12, 218);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(62, 59);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMoins
            // 
            this.btnMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnMoins.Location = new System.Drawing.Point(100, 218);
            this.btnMoins.Name = "btnMoins";
            this.btnMoins.Size = new System.Drawing.Size(62, 59);
            this.btnMoins.TabIndex = 5;
            this.btnMoins.Text = "-";
            this.btnMoins.UseVisualStyleBackColor = true;
            this.btnMoins.Click += new System.EventHandler(this.btnMoins_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.btnMultiplication.Location = new System.Drawing.Point(186, 218);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(62, 59);
            this.btnMultiplication.TabIndex = 6;
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.BtnDivision.Location = new System.Drawing.Point(267, 218);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(62, 59);
            this.BtnDivision.TabIndex = 7;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // txtReponseFinal
            // 
            this.txtReponseFinal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtReponseFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReponseFinal.ForeColor = System.Drawing.Color.Chocolate;
            this.txtReponseFinal.Location = new System.Drawing.Point(12, 308);
            this.txtReponseFinal.Name = "txtReponseFinal";
            this.txtReponseFinal.Size = new System.Drawing.Size(317, 61);
            this.txtReponseFinal.TabIndex = 8;
            this.txtReponseFinal.Text = "=";
            // 
            // frmMachineCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 389);
            this.Controls.Add(this.txtReponseFinal);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMoins);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNb2);
            this.Controls.Add(this.txtNb1);
            this.Controls.Add(this.lblNb2);
            this.Controls.Add(this.lblNb1);
            this.Name = "frmMachineCalcul";
            this.Text = "Machine à calculer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNb1;
        private System.Windows.Forms.Label lblNb2;
        private System.Windows.Forms.TextBox txtNb1;
        private System.Windows.Forms.TextBox txtNb2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMoins;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.TextBox txtReponseFinal;
    }
}

