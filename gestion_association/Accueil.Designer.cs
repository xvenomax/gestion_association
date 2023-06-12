namespace gestion_association
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.btnmembre = new System.Windows.Forms.Button();
            this.btnintervention = new System.Windows.Forms.Button();
            this.btnpromotion = new System.Windows.Forms.Button();
            this.btnbureau = new System.Windows.Forms.Button();
            this.btnfermer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmembre
            // 
            this.btnmembre.BackColor = System.Drawing.Color.White;
            this.btnmembre.ForeColor = System.Drawing.Color.Black;
            this.btnmembre.Location = new System.Drawing.Point(33, 164);
            this.btnmembre.Name = "btnmembre";
            this.btnmembre.Size = new System.Drawing.Size(114, 42);
            this.btnmembre.TabIndex = 10;
            this.btnmembre.Text = "Gérer les membres";
            this.btnmembre.UseVisualStyleBackColor = false;
            this.btnmembre.Click += new System.EventHandler(this.btnmembre_Click);
            // 
            // btnintervention
            // 
            this.btnintervention.BackColor = System.Drawing.Color.White;
            this.btnintervention.Location = new System.Drawing.Point(672, 164);
            this.btnintervention.Name = "btnintervention";
            this.btnintervention.Size = new System.Drawing.Size(114, 42);
            this.btnintervention.TabIndex = 8;
            this.btnintervention.Text = "Interventions";
            this.btnintervention.UseVisualStyleBackColor = false;
            this.btnintervention.Click += new System.EventHandler(this.btnintervention_Click);
            // 
            // btnpromotion
            // 
            this.btnpromotion.BackColor = System.Drawing.Color.White;
            this.btnpromotion.Location = new System.Drawing.Point(464, 164);
            this.btnpromotion.Name = "btnpromotion";
            this.btnpromotion.Size = new System.Drawing.Size(114, 42);
            this.btnpromotion.TabIndex = 7;
            this.btnpromotion.Text = "Promotions";
            this.btnpromotion.UseVisualStyleBackColor = false;
            this.btnpromotion.Click += new System.EventHandler(this.btnpromotion_Click);
            // 
            // btnbureau
            // 
            this.btnbureau.BackColor = System.Drawing.Color.White;
            this.btnbureau.Location = new System.Drawing.Point(246, 164);
            this.btnbureau.Name = "btnbureau";
            this.btnbureau.Size = new System.Drawing.Size(114, 42);
            this.btnbureau.TabIndex = 6;
            this.btnbureau.Text = "Gérer le bureau";
            this.btnbureau.UseVisualStyleBackColor = false;
            this.btnbureau.Click += new System.EventHandler(this.btnbureau_Click);
            // 
            // btnfermer
            // 
            this.btnfermer.BackColor = System.Drawing.Color.White;
            this.btnfermer.Location = new System.Drawing.Point(351, 310);
            this.btnfermer.Name = "btnfermer";
            this.btnfermer.Size = new System.Drawing.Size(114, 42);
            this.btnfermer.TabIndex = 11;
            this.btnfermer.Text = "Fermer";
            this.btnfermer.UseVisualStyleBackColor = false;
            this.btnfermer.Click += new System.EventHandler(this.btnfermer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(112, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(591, 31);
            this.label19.TabIndex = 41;
            this.label19.Text = "Gestion de l\'association du BTS SIO Marie-Curie";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnfermer);
            this.Controls.Add(this.btnmembre);
            this.Controls.Add(this.btnintervention);
            this.Controls.Add(this.btnpromotion);
            this.Controls.Add(this.btnbureau);
            this.Name = "Accueil";
            this.Text = "GererMembre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmembre;
        private System.Windows.Forms.Button btnintervention;
        private System.Windows.Forms.Button btnpromotion;
        private System.Windows.Forms.Button btnbureau;
        private System.Windows.Forms.Button btnfermer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label19;
    }
}