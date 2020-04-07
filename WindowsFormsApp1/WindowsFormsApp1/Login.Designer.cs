namespace WindowsFormsApp1
{
    partial class Login
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
            this.uxWildcat = new System.Windows.Forms.Label();
            this.uxUser = new System.Windows.Forms.Label();
            this.uxPass = new System.Windows.Forms.Label();
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxLogin = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApp1.databaseDataSet1();
            this.loginTableAdapter = new WindowsFormsApp1.databaseDataSet1TableAdapters.loginTableAdapter();
            this.assignment23DataSet = new WindowsFormsApp1.Assignment23DataSet();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter1 = new WindowsFormsApp1.Assignment23DataSetTableAdapters.LoginTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxWildcat
            // 
            this.uxWildcat.AutoSize = true;
            this.uxWildcat.Font = new System.Drawing.Font("BDP Birgula", 41.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWildcat.Location = new System.Drawing.Point(103, 43);
            this.uxWildcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxWildcat.Name = "uxWildcat";
            this.uxWildcat.Size = new System.Drawing.Size(445, 71);
            this.uxWildcat.TabIndex = 0;
            this.uxWildcat.Text = "Wildcat Refinery";
            // 
            // uxUser
            // 
            this.uxUser.AutoSize = true;
            this.uxUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUser.Location = new System.Drawing.Point(106, 138);
            this.uxUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxUser.Name = "uxUser";
            this.uxUser.Size = new System.Drawing.Size(100, 24);
            this.uxUser.TabIndex = 1;
            this.uxUser.Text = "Username:";
            // 
            // uxPass
            // 
            this.uxPass.AutoSize = true;
            this.uxPass.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPass.Location = new System.Drawing.Point(106, 207);
            this.uxPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPass.Name = "uxPass";
            this.uxPass.Size = new System.Drawing.Size(94, 24);
            this.uxPass.TabIndex = 2;
            this.uxPass.Text = "Password:";
            // 
            // uxUsername
            // 
            this.uxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(232, 134);
            this.uxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(312, 30);
            this.uxUsername.TabIndex = 3;
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(232, 203);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(312, 30);
            this.uxPassword.TabIndex = 4;
            // 
            // uxLogin
            // 
            this.uxLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogin.Location = new System.Drawing.Point(155, 288);
            this.uxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(130, 52);
            this.uxLogin.TabIndex = 5;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(365, 288);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(130, 52);
            this.uxExit.TabIndex = 6;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // assignment23DataSet
            // 
            this.assignment23DataSet.DataSetName = "Assignment23DataSet";
            this.assignment23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "Login";
            this.loginBindingSource1.DataSource = this.assignment23DataSet;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Login1TableAdapter = null;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter1;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Assignment23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(651, 385);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPass);
            this.Controls.Add(this.uxUser);
            this.Controls.Add(this.uxWildcat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWildcat;
        private System.Windows.Forms.Label uxUser;
        private System.Windows.Forms.Label uxPass;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Button uxLogin;
        private System.Windows.Forms.Button uxExit;
        private databaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private databaseDataSet1TableAdapters.loginTableAdapter loginTableAdapter;
        private Assignment23DataSet assignment23DataSet;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private Assignment23DataSetTableAdapters.LoginTableAdapter loginTableAdapter1;
        private Assignment23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

