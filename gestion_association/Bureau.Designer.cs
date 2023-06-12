namespace gestion_association
{
    partial class Bureau
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
            this.components = new System.ComponentModel.Container();
            this.btnretourbureau = new System.Windows.Forms.Button();
            this.bUREAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_ASSOCIATIONDataSet1 = new gestion_association.GESTION_ASSOCIATIONDataSet1();
            this.bUREAUTableAdapter = new gestion_association.GESTION_ASSOCIATIONDataSet1TableAdapters.BUREAUTableAdapter();
            this.label19 = new System.Windows.Forms.Label();
            this.btnsuppmembre = new System.Windows.Forms.Button();
            this.btnmodifiermembre = new System.Windows.Forms.Button();
            this.btnajoutermembre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bUREAUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aNNEEBUREAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDETUDIANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDBUREAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUREAUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_ASSOCIATIONDataSet2 = new gestion_association.GESTION_ASSOCIATIONDataSet2();
            this.bUREAUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bUREAUTableAdapter1 = new gestion_association.GESTION_ASSOCIATIONDataSet2TableAdapters.BUREAUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretourbureau
            // 
            this.btnretourbureau.Location = new System.Drawing.Point(35, 13);
            this.btnretourbureau.Name = "btnretourbureau";
            this.btnretourbureau.Size = new System.Drawing.Size(84, 32);
            this.btnretourbureau.TabIndex = 3;
            this.btnretourbureau.Text = "Retour";
            this.btnretourbureau.UseVisualStyleBackColor = true;
            this.btnretourbureau.Click += new System.EventHandler(this.btnretourbureau_Click);
            // 
            // bUREAUBindingSource
            // 
            this.bUREAUBindingSource.DataMember = "BUREAU";
            this.bUREAUBindingSource.DataSource = this.gESTION_ASSOCIATIONDataSet1;
            // 
            // gESTION_ASSOCIATIONDataSet1
            // 
            this.gESTION_ASSOCIATIONDataSet1.DataSetName = "GESTION_ASSOCIATIONDataSet1";
            this.gESTION_ASSOCIATIONDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUREAUTableAdapter
            // 
            this.bUREAUTableAdapter.ClearBeforeFill = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(257, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(293, 36);
            this.label19.TabIndex = 40;
            this.label19.Text = "Membres du bureau";
            // 
            // btnsuppmembre
            // 
            this.btnsuppmembre.BackColor = System.Drawing.Color.Red;
            this.btnsuppmembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuppmembre.Location = new System.Drawing.Point(509, 301);
            this.btnsuppmembre.Name = "btnsuppmembre";
            this.btnsuppmembre.Size = new System.Drawing.Size(143, 40);
            this.btnsuppmembre.TabIndex = 43;
            this.btnsuppmembre.Text = "Supprimer";
            this.btnsuppmembre.UseVisualStyleBackColor = false;
            this.btnsuppmembre.Click += new System.EventHandler(this.btnsuppmembre_Click);
            // 
            // btnmodifiermembre
            // 
            this.btnmodifiermembre.BackColor = System.Drawing.Color.Orange;
            this.btnmodifiermembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifiermembre.Location = new System.Drawing.Point(328, 301);
            this.btnmodifiermembre.Name = "btnmodifiermembre";
            this.btnmodifiermembre.Size = new System.Drawing.Size(143, 40);
            this.btnmodifiermembre.TabIndex = 42;
            this.btnmodifiermembre.Text = "Modifier";
            this.btnmodifiermembre.UseVisualStyleBackColor = false;
            this.btnmodifiermembre.Click += new System.EventHandler(this.btnmodifiermembre_Click);
            // 
            // btnajoutermembre
            // 
            this.btnajoutermembre.BackColor = System.Drawing.Color.Green;
            this.btnajoutermembre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajoutermembre.Location = new System.Drawing.Point(148, 301);
            this.btnajoutermembre.Name = "btnajoutermembre";
            this.btnajoutermembre.Size = new System.Drawing.Size(143, 40);
            this.btnajoutermembre.TabIndex = 41;
            this.btnajoutermembre.Text = "Ajouter";
            this.btnajoutermembre.UseVisualStyleBackColor = false;
            this.btnajoutermembre.Click += new System.EventHandler(this.btnajoutermembre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBUREAUDataGridViewTextBoxColumn,
            this.iDETUDIANTDataGridViewTextBoxColumn,
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn,
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn,
            this.aNNEEBUREAUDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bUREAUBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(128, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 175);
            this.dataGridView1.TabIndex = 44;
            // 
            // bUREAUBindingSource1
            // 
            this.bUREAUBindingSource1.DataMember = "BUREAU";
            this.bUREAUBindingSource1.DataSource = this.gESTION_ASSOCIATIONDataSet1;
            // 
            // aNNEEBUREAUDataGridViewTextBoxColumn
            // 
            this.aNNEEBUREAUDataGridViewTextBoxColumn.DataPropertyName = "ANNEEBUREAU";
            this.aNNEEBUREAUDataGridViewTextBoxColumn.HeaderText = "ANNEEBUREAU";
            this.aNNEEBUREAUDataGridViewTextBoxColumn.Name = "aNNEEBUREAUDataGridViewTextBoxColumn";
            this.aNNEEBUREAUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn
            // 
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn.DataPropertyName = "IDETUDIANT_ETRE_PRESIDENT";
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn.HeaderText = "IDETUDIANT_ETRE_PRESIDENT";
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn.Name = "iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn";
            this.iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn
            // 
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn.DataPropertyName = "IDETUDIANT_ETRE_SECRETAIRE";
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn.HeaderText = "IDETUDIANT_ETRE_SECRETAIRE";
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn.Name = "iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn";
            this.iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDETUDIANTDataGridViewTextBoxColumn
            // 
            this.iDETUDIANTDataGridViewTextBoxColumn.DataPropertyName = "IDETUDIANT";
            this.iDETUDIANTDataGridViewTextBoxColumn.HeaderText = "IDETUDIANT";
            this.iDETUDIANTDataGridViewTextBoxColumn.Name = "iDETUDIANTDataGridViewTextBoxColumn";
            this.iDETUDIANTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDBUREAUDataGridViewTextBoxColumn
            // 
            this.iDBUREAUDataGridViewTextBoxColumn.DataPropertyName = "IDBUREAU";
            this.iDBUREAUDataGridViewTextBoxColumn.HeaderText = "IDBUREAU";
            this.iDBUREAUDataGridViewTextBoxColumn.Name = "iDBUREAUDataGridViewTextBoxColumn";
            this.iDBUREAUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bUREAUBindingSource2
            // 
            this.bUREAUBindingSource2.DataMember = "BUREAU";
            this.bUREAUBindingSource2.DataSource = this.gESTION_ASSOCIATIONDataSet1;
            // 
            // gESTION_ASSOCIATIONDataSet2
            // 
            this.gESTION_ASSOCIATIONDataSet2.DataSetName = "GESTION_ASSOCIATIONDataSet2";
            this.gESTION_ASSOCIATIONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bUREAUBindingSource3
            // 
            this.bUREAUBindingSource3.DataMember = "BUREAU";
            this.bUREAUBindingSource3.DataSource = this.gESTION_ASSOCIATIONDataSet2;
            // 
            // bUREAUTableAdapter1
            // 
            this.bUREAUTableAdapter1.ClearBeforeFill = true;
            // 
            // Bureau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsuppmembre);
            this.Controls.Add(this.btnmodifiermembre);
            this.Controls.Add(this.btnajoutermembre);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnretourbureau);
            this.Name = "Bureau";
            this.Text = "Bureau";
            this.Load += new System.EventHandler(this.Bureau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUREAUBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretourbureau;
        private GESTION_ASSOCIATIONDataSet1 gESTION_ASSOCIATIONDataSet1;
        private System.Windows.Forms.BindingSource bUREAUBindingSource;
        private GESTION_ASSOCIATIONDataSet1TableAdapters.BUREAUTableAdapter bUREAUTableAdapter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnsuppmembre;
        private System.Windows.Forms.Button btnmodifiermembre;
        private System.Windows.Forms.Button btnajoutermembre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bUREAUBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBUREAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDETUDIANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDETUDIANTETRESECRETAIREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDETUDIANTETREPRESIDENTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNNEEBUREAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bUREAUBindingSource2;
        private GESTION_ASSOCIATIONDataSet2 gESTION_ASSOCIATIONDataSet2;
        private System.Windows.Forms.BindingSource bUREAUBindingSource3;
        private GESTION_ASSOCIATIONDataSet2TableAdapters.BUREAUTableAdapter bUREAUTableAdapter1;
    }
}