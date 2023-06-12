namespace gestion_association.CRUD_Membre
{
    partial class SupprimerMembre
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
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomSupp = new System.Windows.Forms.TextBox();
            this.RetourModifier = new System.Windows.Forms.Button();
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(117, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(325, 36);
            this.label19.TabIndex = 39;
            this.label19.Text = "Supprimer un membre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Nom du membre à supprimer : ";
            // 
            // txtNomSupp
            // 
            this.txtNomSupp.Location = new System.Drawing.Point(224, 86);
            this.txtNomSupp.Name = "txtNomSupp";
            this.txtNomSupp.Size = new System.Drawing.Size(100, 20);
            this.txtNomSupp.TabIndex = 75;
            // 
            // RetourModifier
            // 
            this.RetourModifier.Location = new System.Drawing.Point(12, 12);
            this.RetourModifier.Name = "RetourModifier";
            this.RetourModifier.Size = new System.Drawing.Size(75, 23);
            this.RetourModifier.TabIndex = 77;
            this.RetourModifier.Text = "Retour";
            this.RetourModifier.UseVisualStyleBackColor = true;
            this.RetourModifier.Click += new System.EventHandler(this.RetourModifier_Click_1);
            // 
            // btnSupprimerMembre
            // 
            this.btnSupprimerMembre.Location = new System.Drawing.Point(239, 125);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerMembre.TabIndex = 78;
            this.btnSupprimerMembre.Text = "Supprimer";
            this.btnSupprimerMembre.UseVisualStyleBackColor = true;
            this.btnSupprimerMembre.Click += new System.EventHandler(this.btnSupprimerMembre_Click);
            // 
            // SupprimerMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(542, 187);
            this.Controls.Add(this.btnSupprimerMembre);
            this.Controls.Add(this.RetourModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomSupp);
            this.Controls.Add(this.label19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SupprimerMembre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupprimerMembre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomSupp;
        private System.Windows.Forms.Button RetourModifier;
        private System.Windows.Forms.Button btnSupprimerMembre;
    }
}