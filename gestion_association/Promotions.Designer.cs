namespace gestion_association
{
    partial class Promotions
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
            this.btnretourpromotions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnretourpromotions
            // 
            this.btnretourpromotions.Location = new System.Drawing.Point(333, 302);
            this.btnretourpromotions.Name = "btnretourpromotions";
            this.btnretourpromotions.Size = new System.Drawing.Size(143, 40);
            this.btnretourpromotions.TabIndex = 3;
            this.btnretourpromotions.Text = "Retour";
            this.btnretourpromotions.UseVisualStyleBackColor = true;
            this.btnretourpromotions.Click += new System.EventHandler(this.btnretourpromotions_Click);
            // 
            // Promotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnretourpromotions);
            this.Name = "Promotions";
            this.Text = "Promotions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnretourpromotions;
    }
}