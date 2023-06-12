namespace gestion_association
{
    partial class Membre
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
            this.btnretourmembre = new System.Windows.Forms.Button();
            this.dataMembre = new System.Windows.Forms.DataGridView();
            this.eTUDIANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gESTION_ASSOCIATIONDataSet = new gestion_association.GESTION_ASSOCIATIONDataSet();
            this.eTUDIANTTableAdapter = new gestion_association.GESTION_ASSOCIATIONDataSetTableAdapters.ETUDIANTTableAdapter();
            this.btnajouteretudiant = new System.Windows.Forms.Button();
            this.iDETUDIANTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFORMATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDINTERVENTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRENCONTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRENOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEPHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATENAISSANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lYCEEORIGINEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bACCALAUREATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPECIALITEBACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEENTREEBTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATESORTIEBTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPECIALITEBTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnmodifieretudiant = new System.Windows.Forms.Button();
            this.btnsuppetudiant = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTUDIANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretourmembre
            // 
            this.btnretourmembre.Location = new System.Drawing.Point(12, 22);
            this.btnretourmembre.Name = "btnretourmembre";
            this.btnretourmembre.Size = new System.Drawing.Size(94, 32);
            this.btnretourmembre.TabIndex = 2;
            this.btnretourmembre.Text = "Retour";
            this.btnretourmembre.UseVisualStyleBackColor = true;
            this.btnretourmembre.Click += new System.EventHandler(this.btnretourmembre_Click);
            // 
            // dataMembre
            // 
            this.dataMembre.AllowUserToAddRows = false;
            this.dataMembre.AllowUserToDeleteRows = false;
            this.dataMembre.AutoGenerateColumns = false;
            this.dataMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMembre.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMembre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDETUDIANTDataGridViewTextBoxColumn,
            this.iDFORMATIONDataGridViewTextBoxColumn,
            this.iDINTERVENTIONDataGridViewTextBoxColumn,
            this.iDRENCONTREDataGridViewTextBoxColumn,
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pRENOMDataGridViewTextBoxColumn,
            this.tELEPHONEDataGridViewTextBoxColumn,
            this.dATENAISSANCEDataGridViewTextBoxColumn,
            this.lYCEEORIGINEDataGridViewTextBoxColumn,
            this.bACCALAUREATDataGridViewTextBoxColumn,
            this.sPECIALITEBACDataGridViewTextBoxColumn,
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn,
            this.dATEENTREEBTSDataGridViewTextBoxColumn,
            this.dATESORTIEBTSDataGridViewTextBoxColumn,
            this.sPECIALITEBTSDataGridViewTextBoxColumn,
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn,
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn});
            this.dataMembre.DataSource = this.eTUDIANTBindingSource;
            this.dataMembre.Location = new System.Drawing.Point(12, 83);
            this.dataMembre.Name = "dataMembre";
            this.dataMembre.ReadOnly = true;
            this.dataMembre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMembre.Size = new System.Drawing.Size(972, 172);
            this.dataMembre.TabIndex = 3;
            this.dataMembre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMembre_CellContentClick);
            // 
            // eTUDIANTBindingSource
            // 
            this.eTUDIANTBindingSource.DataMember = "ETUDIANT";
            this.eTUDIANTBindingSource.DataSource = this.gESTION_ASSOCIATIONDataSet;
            // 
            // gESTION_ASSOCIATIONDataSet
            // 
            this.gESTION_ASSOCIATIONDataSet.DataSetName = "GESTION_ASSOCIATIONDataSet";
            this.gESTION_ASSOCIATIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eTUDIANTTableAdapter
            // 
            this.eTUDIANTTableAdapter.ClearBeforeFill = true;
            // 
            // btnajouteretudiant
            // 
            this.btnajouteretudiant.BackColor = System.Drawing.Color.Green;
            this.btnajouteretudiant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnajouteretudiant.Location = new System.Drawing.Point(241, 318);
            this.btnajouteretudiant.Name = "btnajouteretudiant";
            this.btnajouteretudiant.Size = new System.Drawing.Size(143, 40);
            this.btnajouteretudiant.TabIndex = 4;
            this.btnajouteretudiant.Text = "Ajouter";
            this.btnajouteretudiant.UseVisualStyleBackColor = false;
            this.btnajouteretudiant.Click += new System.EventHandler(this.btnajouteretudiant_Click);
            // 
            // iDETUDIANTDataGridViewTextBoxColumn
            // 
            this.iDETUDIANTDataGridViewTextBoxColumn.DataPropertyName = "IDETUDIANT";
            this.iDETUDIANTDataGridViewTextBoxColumn.HeaderText = "IDETUDIANT";
            this.iDETUDIANTDataGridViewTextBoxColumn.Name = "iDETUDIANTDataGridViewTextBoxColumn";
            this.iDETUDIANTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDETUDIANTDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDFORMATIONDataGridViewTextBoxColumn
            // 
            this.iDFORMATIONDataGridViewTextBoxColumn.DataPropertyName = "IDFORMATION";
            this.iDFORMATIONDataGridViewTextBoxColumn.HeaderText = "IDFORMATION";
            this.iDFORMATIONDataGridViewTextBoxColumn.Name = "iDFORMATIONDataGridViewTextBoxColumn";
            this.iDFORMATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFORMATIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDINTERVENTIONDataGridViewTextBoxColumn
            // 
            this.iDINTERVENTIONDataGridViewTextBoxColumn.DataPropertyName = "IDINTERVENTION";
            this.iDINTERVENTIONDataGridViewTextBoxColumn.HeaderText = "IDINTERVENTION";
            this.iDINTERVENTIONDataGridViewTextBoxColumn.Name = "iDINTERVENTIONDataGridViewTextBoxColumn";
            this.iDINTERVENTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDINTERVENTIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRENCONTREDataGridViewTextBoxColumn
            // 
            this.iDRENCONTREDataGridViewTextBoxColumn.DataPropertyName = "IDRENCONTRE";
            this.iDRENCONTREDataGridViewTextBoxColumn.HeaderText = "IDRENCONTRE";
            this.iDRENCONTREDataGridViewTextBoxColumn.Name = "iDRENCONTREDataGridViewTextBoxColumn";
            this.iDRENCONTREDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRENCONTREDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDSECTEURACTIVITEDataGridViewTextBoxColumn
            // 
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn.DataPropertyName = "IDSECTEURACTIVITE";
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn.HeaderText = "IDSECTEURACTIVITE";
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn.Name = "iDSECTEURACTIVITEDataGridViewTextBoxColumn";
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSECTEURACTIVITEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMDataGridViewTextBoxColumn
            // 
            this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
            this.nOMDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
            this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRENOMDataGridViewTextBoxColumn
            // 
            this.pRENOMDataGridViewTextBoxColumn.DataPropertyName = "PRENOM";
            this.pRENOMDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.pRENOMDataGridViewTextBoxColumn.Name = "pRENOMDataGridViewTextBoxColumn";
            this.pRENOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEPHONEDataGridViewTextBoxColumn
            // 
            this.tELEPHONEDataGridViewTextBoxColumn.DataPropertyName = "TELEPHONE";
            this.tELEPHONEDataGridViewTextBoxColumn.HeaderText = "Téléphone";
            this.tELEPHONEDataGridViewTextBoxColumn.Name = "tELEPHONEDataGridViewTextBoxColumn";
            this.tELEPHONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATENAISSANCEDataGridViewTextBoxColumn
            // 
            this.dATENAISSANCEDataGridViewTextBoxColumn.DataPropertyName = "DATENAISSANCE";
            this.dATENAISSANCEDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
            this.dATENAISSANCEDataGridViewTextBoxColumn.Name = "dATENAISSANCEDataGridViewTextBoxColumn";
            this.dATENAISSANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lYCEEORIGINEDataGridViewTextBoxColumn
            // 
            this.lYCEEORIGINEDataGridViewTextBoxColumn.DataPropertyName = "LYCEEORIGINE";
            this.lYCEEORIGINEDataGridViewTextBoxColumn.HeaderText = "Lycée";
            this.lYCEEORIGINEDataGridViewTextBoxColumn.Name = "lYCEEORIGINEDataGridViewTextBoxColumn";
            this.lYCEEORIGINEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bACCALAUREATDataGridViewTextBoxColumn
            // 
            this.bACCALAUREATDataGridViewTextBoxColumn.DataPropertyName = "BACCALAUREAT";
            this.bACCALAUREATDataGridViewTextBoxColumn.HeaderText = "Baccalauréat";
            this.bACCALAUREATDataGridViewTextBoxColumn.Name = "bACCALAUREATDataGridViewTextBoxColumn";
            this.bACCALAUREATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPECIALITEBACDataGridViewTextBoxColumn
            // 
            this.sPECIALITEBACDataGridViewTextBoxColumn.DataPropertyName = "SPECIALITEBAC";
            this.sPECIALITEBACDataGridViewTextBoxColumn.HeaderText = "Spécialité Bac";
            this.sPECIALITEBACDataGridViewTextBoxColumn.Name = "sPECIALITEBACDataGridViewTextBoxColumn";
            this.sPECIALITEBACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aNNEEOBTENTIONBACDataGridViewTextBoxColumn
            // 
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn.DataPropertyName = "ANNEEOBTENTIONBAC";
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn.HeaderText = "Année Bac";
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn.Name = "aNNEEOBTENTIONBACDataGridViewTextBoxColumn";
            this.aNNEEOBTENTIONBACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEENTREEBTSDataGridViewTextBoxColumn
            // 
            this.dATEENTREEBTSDataGridViewTextBoxColumn.DataPropertyName = "DATEENTREEBTS";
            this.dATEENTREEBTSDataGridViewTextBoxColumn.HeaderText = "Entrée BTS";
            this.dATEENTREEBTSDataGridViewTextBoxColumn.Name = "dATEENTREEBTSDataGridViewTextBoxColumn";
            this.dATEENTREEBTSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATESORTIEBTSDataGridViewTextBoxColumn
            // 
            this.dATESORTIEBTSDataGridViewTextBoxColumn.DataPropertyName = "DATESORTIEBTS";
            this.dATESORTIEBTSDataGridViewTextBoxColumn.HeaderText = "Sortie BTS";
            this.dATESORTIEBTSDataGridViewTextBoxColumn.Name = "dATESORTIEBTSDataGridViewTextBoxColumn";
            this.dATESORTIEBTSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPECIALITEBTSDataGridViewTextBoxColumn
            // 
            this.sPECIALITEBTSDataGridViewTextBoxColumn.DataPropertyName = "SPECIALITEBTS";
            this.sPECIALITEBTSDataGridViewTextBoxColumn.HeaderText = "Spécialité BTS";
            this.sPECIALITEBTSDataGridViewTextBoxColumn.Name = "sPECIALITEBTSDataGridViewTextBoxColumn";
            this.sPECIALITEBTSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn
            // 
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn.DataPropertyName = "DATEOBTENTIONDIPLOME";
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn.HeaderText = "Obtention BTS";
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn.Name = "dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn";
            this.dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn
            // 
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn.DataPropertyName = "DATEENTREEMONDEPROFESSIONNEL";
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn.HeaderText = "Entrée monde professionnel";
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn.Name = "dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn";
            this.dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnmodifieretudiant
            // 
            this.btnmodifieretudiant.BackColor = System.Drawing.Color.Orange;
            this.btnmodifieretudiant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmodifieretudiant.Location = new System.Drawing.Point(421, 318);
            this.btnmodifieretudiant.Name = "btnmodifieretudiant";
            this.btnmodifieretudiant.Size = new System.Drawing.Size(143, 40);
            this.btnmodifieretudiant.TabIndex = 5;
            this.btnmodifieretudiant.Text = "Modifier";
            this.btnmodifieretudiant.UseVisualStyleBackColor = false;
            this.btnmodifieretudiant.Click += new System.EventHandler(this.btnmodifieretudiant_Click);
            // 
            // btnsuppetudiant
            // 
            this.btnsuppetudiant.BackColor = System.Drawing.Color.Red;
            this.btnsuppetudiant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuppetudiant.Location = new System.Drawing.Point(602, 318);
            this.btnsuppetudiant.Name = "btnsuppetudiant";
            this.btnsuppetudiant.Size = new System.Drawing.Size(143, 40);
            this.btnsuppetudiant.TabIndex = 6;
            this.btnsuppetudiant.Text = "Supprimer";
            this.btnsuppetudiant.UseVisualStyleBackColor = false;
            this.btnsuppetudiant.Click += new System.EventHandler(this.btnsuppetudiant_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(323, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(363, 36);
            this.label19.TabIndex = 39;
            this.label19.Text = "Membres de l\'association";
            // 
            // Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnsuppetudiant);
            this.Controls.Add(this.btnmodifieretudiant);
            this.Controls.Add(this.btnajouteretudiant);
            this.Controls.Add(this.dataMembre);
            this.Controls.Add(this.btnretourmembre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Membre";
            this.Text = "Membre";
            this.Load += new System.EventHandler(this.Membre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eTUDIANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gESTION_ASSOCIATIONDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnretourmembre;
        private System.Windows.Forms.DataGridView dataMembre;
        private GESTION_ASSOCIATIONDataSet gESTION_ASSOCIATIONDataSet;
        private System.Windows.Forms.BindingSource eTUDIANTBindingSource;
        private GESTION_ASSOCIATIONDataSetTableAdapters.ETUDIANTTableAdapter eTUDIANTTableAdapter;
        private System.Windows.Forms.Button btnajouteretudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDETUDIANTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFORMATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDINTERVENTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRENCONTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSECTEURACTIVITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRENOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEPHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATENAISSANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lYCEEORIGINEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bACCALAUREATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIALITEBACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNNEEOBTENTIONBACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEENTREEBTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATESORTIEBTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPECIALITEBTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEOBTENTIONDIPLOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEENTREEMONDEPROFESSIONNELDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnmodifieretudiant;
        private System.Windows.Forms.Button btnsuppetudiant;
        private System.Windows.Forms.Label label19;
    }
}