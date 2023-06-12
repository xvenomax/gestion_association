namespace gestion_association.CRUD_Bureau
{
    partial class SupprimerBureau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.RetourModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomSupp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSupprimerMembre
            // 
            this.btnSupprimerMembre.Location = new System.Drawing.Point(379, 171);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerMembre.TabIndex = 83;
            this.btnSupprimerMembre.Text = "Supprimer";
            this.btnSupprimerMembre.UseVisualStyleBackColor = true;
            // 
            // RetourModifier
            // 
            this.RetourModifier.Location = new System.Drawing.Point(152, 58);
            this.RetourModifier.Name = "RetourModifier";
            this.RetourModifier.Size = new System.Drawing.Size(75, 23);
            this.RetourModifier.TabIndex = 82;
            this.RetourModifier.Text = "Retour";
            this.RetourModifier.UseVisualStyleBackColor = true;
            this.RetourModifier.Click += new System.EventHandler(this.RetourModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(208, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nom du membre à supprimer : ";
            // 
            // txtNomSupp
            // 
            this.txtNomSupp.Location = new System.Drawing.Point(364, 132);
            this.txtNomSupp.Name = "txtNomSupp";
            this.txtNomSupp.Size = new System.Drawing.Size(100, 20);
            this.txtNomSupp.TabIndex = 80;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(257, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(325, 36);
            this.label19.TabIndex = 79;
            this.label19.Text = "Supprimer un membre";
            // 
            // SupprimerBureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimerMembre);
            this.Controls.Add(this.RetourModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomSupp);
            this.Controls.Add(this.label19);
            this.Name = "SupprimerBureau";
            this.Text = "SupprimerBureau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerMembre;
        private System.Windows.Forms.Button RetourModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomSupp;
        private System.Windows.Forms.Label label19;
    }
}