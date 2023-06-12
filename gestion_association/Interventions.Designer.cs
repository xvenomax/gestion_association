namespace gestion_association
{
    partial class Interventions
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
            this.btnretourinterventions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretourinterventions
            // 
            this.btnretourinterventions.Location = new System.Drawing.Point(306, 307);
            this.btnretourinterventions.Name = "btnretourinterventions";
            this.btnretourinterventions.Size = new System.Drawing.Size(143, 40);
            this.btnretourinterventions.TabIndex = 3;
            this.btnretourinterventions.Text = "Retour";
            this.btnretourinterventions.UseVisualStyleBackColor = true;
            this.btnretourinterventions.Click += new System.EventHandler(this.btnretourinterventions_Click);
            // 
            // Interventions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnretourinterventions);
            this.Name = "Interventions";
            this.Text = "Interventions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretourinterventions;
    }
}