namespace WindowsFormsApp1
{
    partial class Logs
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
            this.projectDataSet = new WindowsFormsApp1.ProjectDataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new WindowsFormsApp1.ProjectDataSetTableAdapters.LogsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.ProjectDataSetTableAdapters.TableAdapterManager();
            this.uxExit = new System.Windows.Forms.Button();
            this.assignment23DataSet = new WindowsFormsApp1.Assignment23DataSet();
            this.logsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter1 = new WindowsFormsApp1.Assignment23DataSetTableAdapters.LogsTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager();
            this.logsDataGridView = new System.Windows.Forms.DataGridView();
            this.logsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment23DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitManagerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift1or2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.welderSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorSignatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.projectDataSet;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = this.logsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(660, 496);
            this.uxExit.Margin = new System.Windows.Forms.Padding(4);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(197, 87);
            this.uxExit.TabIndex = 2;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // assignment23DataSet
            // 
            this.assignment23DataSet.DataSetName = "Assignment23DataSet";
            this.assignment23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource1
            // 
            this.logsBindingSource1.DataMember = "Logs";
            this.logsBindingSource1.DataSource = this.assignment23DataSet;
            // 
            // logsTableAdapter1
            // 
            this.logsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Login1TableAdapter = null;
            this.tableAdapterManager1.LoginTableAdapter = null;
            this.tableAdapterManager1.LogsTableAdapter = this.logsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // logsDataGridView
            // 
            this.logsDataGridView.AutoGenerateColumns = false;
            this.logsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.equipmentDataGridViewTextBoxColumn,
            this.unitManagerDataGridViewTextBoxColumn,
            this.welderDataGridViewTextBoxColumn,
            this.inspectorDataGridViewTextBoxColumn,
            this.shift1or2DataGridViewTextBoxColumn,
            this.welderSignatureDataGridViewTextBoxColumn,
            this.inspectorSignatureDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.logsDataGridView.DataSource = this.logsBindingSource3;
            this.logsDataGridView.Location = new System.Drawing.Point(2, 1);
            this.logsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.logsDataGridView.Name = "logsDataGridView";
            this.logsDataGridView.RowHeadersWidth = 51;
            this.logsDataGridView.Size = new System.Drawing.Size(1629, 464);
            this.logsDataGridView.TabIndex = 2;
            // 
            // logsBindingSource2
            // 
            this.logsBindingSource2.DataMember = "Logs";
            this.logsBindingSource2.DataSource = this.assignment23DataSet;
            // 
            // assignment23DataSetBindingSource
            // 
            this.assignment23DataSetBindingSource.DataSource = this.assignment23DataSet;
            this.assignment23DataSetBindingSource.Position = 0;
            // 
            // logsBindingSource3
            // 
            this.logsBindingSource3.DataMember = "Logs";
            this.logsBindingSource3.DataSource = this.assignment23DataSet;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 125;
            // 
            // equipmentDataGridViewTextBoxColumn
            // 
            this.equipmentDataGridViewTextBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.equipmentDataGridViewTextBoxColumn.Name = "equipmentDataGridViewTextBoxColumn";
            this.equipmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitManagerDataGridViewTextBoxColumn
            // 
            this.unitManagerDataGridViewTextBoxColumn.DataPropertyName = "UnitManager";
            this.unitManagerDataGridViewTextBoxColumn.HeaderText = "UnitManager";
            this.unitManagerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitManagerDataGridViewTextBoxColumn.Name = "unitManagerDataGridViewTextBoxColumn";
            this.unitManagerDataGridViewTextBoxColumn.Width = 125;
            // 
            // welderDataGridViewTextBoxColumn
            // 
            this.welderDataGridViewTextBoxColumn.DataPropertyName = "Welder";
            this.welderDataGridViewTextBoxColumn.HeaderText = "Welder";
            this.welderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.welderDataGridViewTextBoxColumn.Name = "welderDataGridViewTextBoxColumn";
            this.welderDataGridViewTextBoxColumn.Width = 125;
            // 
            // inspectorDataGridViewTextBoxColumn
            // 
            this.inspectorDataGridViewTextBoxColumn.DataPropertyName = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.HeaderText = "Inspector";
            this.inspectorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inspectorDataGridViewTextBoxColumn.Name = "inspectorDataGridViewTextBoxColumn";
            this.inspectorDataGridViewTextBoxColumn.Width = 125;
            // 
            // shift1or2DataGridViewTextBoxColumn
            // 
            this.shift1or2DataGridViewTextBoxColumn.DataPropertyName = "Shift1or2";
            this.shift1or2DataGridViewTextBoxColumn.HeaderText = "Shift1or2";
            this.shift1or2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shift1or2DataGridViewTextBoxColumn.Name = "shift1or2DataGridViewTextBoxColumn";
            this.shift1or2DataGridViewTextBoxColumn.Width = 125;
            // 
            // welderSignatureDataGridViewTextBoxColumn
            // 
            this.welderSignatureDataGridViewTextBoxColumn.DataPropertyName = "WelderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.HeaderText = "WelderSignature";
            this.welderSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.welderSignatureDataGridViewTextBoxColumn.Name = "welderSignatureDataGridViewTextBoxColumn";
            this.welderSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // inspectorSignatureDataGridViewTextBoxColumn
            // 
            this.inspectorSignatureDataGridViewTextBoxColumn.DataPropertyName = "InspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.HeaderText = "InspectorSignature";
            this.inspectorSignatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inspectorSignatureDataGridViewTextBoxColumn.Name = "inspectorSignatureDataGridViewTextBoxColumn";
            this.inspectorSignatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1728, 614);
            this.Controls.Add(this.logsDataGridView);
            this.Controls.Add(this.uxExit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Logs";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private ProjectDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button uxExit;
        private Assignment23DataSet assignment23DataSet;
        private System.Windows.Forms.BindingSource logsBindingSource1;
        private Assignment23DataSetTableAdapters.LogsTableAdapter logsTableAdapter1;
        private Assignment23DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView logsDataGridView;
        private System.Windows.Forms.BindingSource logsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitManagerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn welderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift1or2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn welderSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorSignatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource logsBindingSource3;
        private System.Windows.Forms.BindingSource assignment23DataSetBindingSource;
    }
}