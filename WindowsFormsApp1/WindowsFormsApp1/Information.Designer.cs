namespace WindowsFormsApp1
{
    partial class Information
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
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label equipmentLabel;
            System.Windows.Forms.Label unitManagerLabel;
            System.Windows.Forms.Label welderLabel;
            System.Windows.Forms.Label inspectorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label welderSignatureLabel;
            System.Windows.Forms.Label inspectorSignatureLabel;
            this.uxPhoto = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.assignment23DataSet = new WindowsFormsApp1.Assignment23DataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new WindowsFormsApp1.Assignment23DataSetTableAdapters.LogsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager();
            this.logsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.equipmentTextBox = new System.Windows.Forms.TextBox();
            this.unitManagerTextBox = new System.Windows.Forms.TextBox();
            this.welderTextBox = new System.Windows.Forms.TextBox();
            this.inspectorTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.welderSignatureTextBox = new System.Windows.Forms.TextBox();
            this.inspectorSignatureTextBox = new System.Windows.Forms.TextBox();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            equipmentLabel = new System.Windows.Forms.Label();
            unitManagerLabel = new System.Windows.Forms.Label();
            welderLabel = new System.Windows.Forms.Label();
            inspectorLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            welderSignatureLabel = new System.Windows.Forms.Label();
            inspectorSignatureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingNavigator)).BeginInit();
            this.logsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(97, 71);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(76, 17);
            startDateLabel.TabIndex = 3;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(102, 115);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(71, 17);
            endDateLabel.TabIndex = 5;
            endDateLabel.Text = "End Date:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(102, 157);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(37, 17);
            unitLabel.TabIndex = 7;
            unitLabel.Text = "Unit:";
            // 
            // equipmentLabel
            // 
            equipmentLabel.AutoSize = true;
            equipmentLabel.Location = new System.Drawing.Point(105, 207);
            equipmentLabel.Name = "equipmentLabel";
            equipmentLabel.Size = new System.Drawing.Size(79, 17);
            equipmentLabel.TabIndex = 9;
            equipmentLabel.Text = "Equipment:";
            // 
            // unitManagerLabel
            // 
            unitManagerLabel.AutoSize = true;
            unitManagerLabel.Location = new System.Drawing.Point(110, 255);
            unitManagerLabel.Name = "unitManagerLabel";
            unitManagerLabel.Size = new System.Drawing.Size(97, 17);
            unitManagerLabel.TabIndex = 11;
            unitManagerLabel.Text = "Unit Manager:";
            // 
            // welderLabel
            // 
            welderLabel.AutoSize = true;
            welderLabel.Location = new System.Drawing.Point(119, 305);
            welderLabel.Name = "welderLabel";
            welderLabel.Size = new System.Drawing.Size(57, 17);
            welderLabel.TabIndex = 13;
            welderLabel.Text = "Welder:";
            // 
            // inspectorLabel
            // 
            inspectorLabel.AutoSize = true;
            inspectorLabel.Location = new System.Drawing.Point(119, 350);
            inspectorLabel.Name = "inspectorLabel";
            inspectorLabel.Size = new System.Drawing.Size(70, 17);
            inspectorLabel.TabIndex = 15;
            inspectorLabel.Text = "Inspector:";
            // 
            // uxPhoto
            // 
            this.uxPhoto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPhoto.Location = new System.Drawing.Point(382, 472);
            this.uxPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.uxPhoto.Name = "uxPhoto";
            this.uxPhoto.Size = new System.Drawing.Size(168, 63);
            this.uxPhoto.TabIndex = 0;
            this.uxPhoto.Text = "Photo";
            this.uxPhoto.UseVisualStyleBackColor = true;
            this.uxPhoto.Click += new System.EventHandler(this.uxPhoto_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(94, 472);
            this.uxExit.Margin = new System.Windows.Forms.Padding(4);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(168, 63);
            this.uxExit.TabIndex = 1;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // assignment23DataSet
            // 
            this.assignment23DataSet.DataSetName = "Assignment23DataSet";
            this.assignment23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.assignment23DataSet;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Login1TableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = this.logsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // logsBindingNavigator
            // 
            this.logsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.logsBindingNavigator.BindingSource = this.logsBindingSource;
            this.logsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.logsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.logsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.logsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.logsBindingNavigatorSaveItem});
            this.logsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.logsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.logsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.logsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.logsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.logsBindingNavigator.Name = "logsBindingNavigator";
            this.logsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.logsBindingNavigator.Size = new System.Drawing.Size(675, 27);
            this.logsBindingNavigator.TabIndex = 2;
            this.logsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // logsBindingNavigatorSaveItem
            // 
            this.logsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.logsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("logsBindingNavigatorSaveItem.Image")));
            this.logsBindingNavigatorSaveItem.Name = "logsBindingNavigatorSaveItem";
            this.logsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.logsBindingNavigatorSaveItem.Text = "Save Data";
            this.logsBindingNavigatorSaveItem.Click += new System.EventHandler(this.logsBindingNavigatorSaveItem_Click);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.logsBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(179, 67);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.startDateDateTimePicker.TabIndex = 4;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.logsBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(179, 111);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.endDateDateTimePicker.TabIndex = 6;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(145, 154);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(405, 22);
            this.unitTextBox.TabIndex = 8;
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "Equipment", true));
            this.equipmentTextBox.Location = new System.Drawing.Point(190, 204);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(100, 22);
            this.equipmentTextBox.TabIndex = 10;
            // 
            // unitManagerTextBox
            // 
            this.unitManagerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "UnitManager", true));
            this.unitManagerTextBox.Location = new System.Drawing.Point(213, 252);
            this.unitManagerTextBox.Name = "unitManagerTextBox";
            this.unitManagerTextBox.Size = new System.Drawing.Size(100, 22);
            this.unitManagerTextBox.TabIndex = 12;
            // 
            // welderTextBox
            // 
            this.welderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "Welder", true));
            this.welderTextBox.Location = new System.Drawing.Point(182, 302);
            this.welderTextBox.Name = "welderTextBox";
            this.welderTextBox.Size = new System.Drawing.Size(100, 22);
            this.welderTextBox.TabIndex = 14;
            // 
            // inspectorTextBox
            // 
            this.inspectorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "Inspector", true));
            this.inspectorTextBox.Location = new System.Drawing.Point(195, 347);
            this.inspectorTextBox.Name = "inspectorTextBox";
            this.inspectorTextBox.Size = new System.Drawing.Size(100, 22);
            this.inspectorTextBox.TabIndex = 16;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(102, 42);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 17;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(133, 39);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(311, 22);
            this.iDTextBox.TabIndex = 18;
            // 
            // welderSignatureLabel
            // 
            welderSignatureLabel.AutoSize = true;
            welderSignatureLabel.Location = new System.Drawing.Point(133, 386);
            welderSignatureLabel.Name = "welderSignatureLabel";
            welderSignatureLabel.Size = new System.Drawing.Size(122, 17);
            welderSignatureLabel.TabIndex = 19;
            welderSignatureLabel.Text = "Welder Signature:";
            // 
            // welderSignatureTextBox
            // 
            this.welderSignatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "WelderSignature", true));
            this.welderSignatureTextBox.Location = new System.Drawing.Point(261, 383);
            this.welderSignatureTextBox.Name = "welderSignatureTextBox";
            this.welderSignatureTextBox.Size = new System.Drawing.Size(100, 22);
            this.welderSignatureTextBox.TabIndex = 20;
            // 
            // inspectorSignatureLabel
            // 
            inspectorSignatureLabel.AutoSize = true;
            inspectorSignatureLabel.Location = new System.Drawing.Point(138, 431);
            inspectorSignatureLabel.Name = "inspectorSignatureLabel";
            inspectorSignatureLabel.Size = new System.Drawing.Size(135, 17);
            inspectorSignatureLabel.TabIndex = 21;
            inspectorSignatureLabel.Text = "Inspector Signature:";
            // 
            // inspectorSignatureTextBox
            // 
            this.inspectorSignatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logsBindingSource, "InspectorSignature", true));
            this.inspectorSignatureTextBox.Location = new System.Drawing.Point(279, 428);
            this.inspectorSignatureTextBox.Name = "inspectorSignatureTextBox";
            this.inspectorSignatureTextBox.Size = new System.Drawing.Size(100, 22);
            this.inspectorSignatureTextBox.TabIndex = 22;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(675, 566);
            this.Controls.Add(inspectorSignatureLabel);
            this.Controls.Add(this.inspectorSignatureTextBox);
            this.Controls.Add(welderSignatureLabel);
            this.Controls.Add(this.welderSignatureTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(inspectorLabel);
            this.Controls.Add(this.inspectorTextBox);
            this.Controls.Add(welderLabel);
            this.Controls.Add(this.welderTextBox);
            this.Controls.Add(unitManagerLabel);
            this.Controls.Add(this.unitManagerTextBox);
            this.Controls.Add(equipmentLabel);
            this.Controls.Add(this.equipmentTextBox);
            this.Controls.Add(unitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(endDateLabel);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.logsBindingNavigator);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxPhoto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Information";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingNavigator)).EndInit();
            this.logsBindingNavigator.ResumeLayout(false);
            this.logsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxPhoto;
        private System.Windows.Forms.Button uxExit;
        private Assignment23DataSet assignment23DataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private Assignment23DataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private Assignment23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator logsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton logsBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox equipmentTextBox;
        private System.Windows.Forms.TextBox unitManagerTextBox;
        private System.Windows.Forms.TextBox welderTextBox;
        private System.Windows.Forms.TextBox inspectorTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox welderSignatureTextBox;
        private System.Windows.Forms.TextBox inspectorSignatureTextBox;
    }
}