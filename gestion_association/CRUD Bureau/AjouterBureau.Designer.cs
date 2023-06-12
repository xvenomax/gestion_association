namespace gestion_association.CRUD_Bureau
{
    partial class AjouterBureau
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
            this.RetourModifier = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAjouterEtudiant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDPresident = new System.Windows.Forms.TextBox();
            this.txtIDSecretaire = new System.Windows.Forms.TextBox();
            this.txtIDTresorier = new System.Windows.Forms.TextBox();
            this.txtIDBureau = new System.Windows.Forms.TextBox();
            this.dtpBureau = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // RetourModifier
            // 
            this.RetourModifier.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RetourModifier.Location = new System.Drawing.Point(39, 31);
            this.RetourModifier.Name = "RetourModifier";
            this.RetourModifier.Size = new System.Drawing.Size(75, 23);
            this.RetourModifier.TabIndex = 80;
            this.RetourModifier.Text = "Retour";
            this.RetourModifier.UseVisualStyleBackColor = true;
            this.RetourModifier.Click += new System.EventHandler(this.RetourModifier_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(167, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(412, 36);
            this.label19.TabIndex = 79;
            this.label19.Text = "Ajouter un nouveau membre";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnAjouterEtudiant
            // 
            this.btnAjouterEtudiant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAjouterEtudiant.Location = new System.Drawing.Point(323, 239);
            this.btnAjouterEtudiant.Name = "btnAjouterEtudiant";
            this.btnAjouterEtudiant.Size = new System.Drawing.Size(88, 32);
            this.btnAjouterEtudiant.TabIndex = 81;
            this.btnAjouterEtudiant.Text = "Ajouter";
            this.btnAjouterEtudiant.UseVisualStyleBackColor = true;
            this.btnAjouterEtudiant.Click += new System.EventHandler(this.btnAjouterEtudiant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Année Bureau :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Id Président :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Id Secrétaire :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Id Trésorier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Id Bureau :";
            // 
            // txtIDPresident
            // 
            this.txtIDPresident.Location = new System.Drawing.Point(323, 152);
            this.txtIDPresident.Name = "txtIDPresident";
            this.txtIDPresident.Size = new System.Drawing.Size(100, 20);
            this.txtIDPresident.TabIndex = 86;
            // 
            // txtIDSecretaire
            // 
            this.txtIDSecretaire.Location = new System.Drawing.Point(323, 126);
            this.txtIDSecretaire.Name = "txtIDSecretaire";
            this.txtIDSecretaire.Size = new System.Drawing.Size(100, 20);
            this.txtIDSecretaire.TabIndex = 84;
            // 
            // txtIDTresorier
            // 
            this.txtIDTresorier.Location = new System.Drawing.Point(323, 100);
            this.txtIDTresorier.Name = "txtIDTresorier";
            this.txtIDTresorier.Size = new System.Drawing.Size(100, 20);
            this.txtIDTresorier.TabIndex = 83;
            // 
            // txtIDBureau
            // 
            this.txtIDBureau.Location = new System.Drawing.Point(323, 74);
            this.txtIDBureau.Name = "txtIDBureau";
            this.txtIDBureau.Size = new System.Drawing.Size(100, 20);
            this.txtIDBureau.TabIndex = 82;
            // 
            // dtpBureau
            // 
            this.dtpBureau.Location = new System.Drawing.Point(304, 178);
            this.dtpBureau.Name = "dtpBureau";
            this.dtpBureau.Size = new System.Drawing.Size(200, 20);
            this.dtpBureau.TabIndex = 93;
            // 
            // AjouterBureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 298);
            this.Controls.Add(this.dtpBureau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDPresident);
            this.Controls.Add(this.txtIDSecretaire);
            this.Controls.Add(this.txtIDTresorier);
            this.Controls.Add(this.txtIDBureau);
            this.Controls.Add(this.btnAjouterEtudiant);
            this.Controls.Add(this.RetourModifier);
            this.Controls.Add(this.label19);
            this.Name = "AjouterBureau";
            this.Text = "AjouterBureau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RetourModifier;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAjouterEtudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDPresident;
        private System.Windows.Forms.TextBox txtIDSecretaire;
        private System.Windows.Forms.TextBox txtIDTresorier;
        private System.Windows.Forms.TextBox txtIDBureau;
        private System.Windows.Forms.DateTimePicker dtpBureau;
    }
}