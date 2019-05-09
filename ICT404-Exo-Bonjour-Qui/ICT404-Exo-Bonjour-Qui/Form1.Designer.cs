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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lblBonjourQui));
            this.cmdName = new System.Windows.Forms.TextBox();
            this.btnBienvenu = new System.Windows.Forms.Button();
            this.lblTexteNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdName
            // 
            this.cmdName.AccessibleName = "";
            this.cmdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmdName.Location = new System.Drawing.Point(125, 43);
            this.cmdName.Name = "cmdName";
            this.cmdName.Size = new System.Drawing.Size(126, 26);
            this.cmdName.TabIndex = 0;
            this.cmdName.Tag = "";
            this.cmdName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBienvenu
            // 
            this.btnBienvenu.Enabled = false;
            this.btnBienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBienvenu.Location = new System.Drawing.Point(31, 136);
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
            this.lblTexteNom.Location = new System.Drawing.Point(27, 43);
            this.lblTexteNom.Name = "lblTexteNom";
            this.lblTexteNom.Size = new System.Drawing.Size(92, 20);
            this.lblTexteNom.TabIndex = 2;
            this.lblTexteNom.Text = "Votre nom";
            this.lblTexteNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNom
            // 
            this.txtNom.AutoSize = true;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNom.Location = new System.Drawing.Point(26, 86);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(37, 25);
            this.txtNom.TabIndex = 3;
            this.txtNom.Text = ". . .";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(258, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 53);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBonjourQui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblTexteNom);
            this.Controls.Add(this.btnBienvenu);
            this.Controls.Add(this.cmdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "lblBonjourQui";
            this.Text = "Bonjour CPNV";
            this.Load += new System.EventHandler(this.lblBonjourQui_Load);
            this.Resize += new System.EventHandler(this.lblBonjourQui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cmdName;
        private System.Windows.Forms.Button btnBienvenu;
        private System.Windows.Forms.Label lblTexteNom;
        private System.Windows.Forms.Label txtNom;
        private System.Windows.Forms.Button button1;
    }
}

