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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet1 = new WindowsFormsApp1.databaseDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new WindowsFormsApp1.databaseDataSet1TableAdapters.loginTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxWildcat
            // 
            this.uxWildcat.AutoSize = true;
            this.uxWildcat.Font = new System.Drawing.Font("Algerian", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWildcat.Location = new System.Drawing.Point(78, 9);
            this.uxWildcat.Name = "uxWildcat";
            this.uxWildcat.Size = new System.Drawing.Size(645, 75);
            this.uxWildcat.TabIndex = 0;
            this.uxWildcat.Text = "Wildcat Refinery";
            // 
            // uxUser
            // 
            this.uxUser.AutoSize = true;
            this.uxUser.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUser.Location = new System.Drawing.Point(110, 169);
            this.uxUser.Name = "uxUser";
            this.uxUser.Size = new System.Drawing.Size(141, 28);
            this.uxUser.TabIndex = 1;
            this.uxUser.Text = "Username";
            // 
            // uxPass
            // 
            this.uxPass.AutoSize = true;
            this.uxPass.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPass.Location = new System.Drawing.Point(110, 254);
            this.uxPass.Name = "uxPass";
            this.uxPass.Size = new System.Drawing.Size(141, 28);
            this.uxPass.TabIndex = 2;
            this.uxPass.Text = "Password";
            // 
            // uxUsername
            // 
            this.uxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(277, 164);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(414, 36);
            this.uxUsername.TabIndex = 3;
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(277, 249);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(414, 36);
            this.uxPassword.TabIndex = 4;
            // 
            // uxLogin
            // 
            this.uxLogin.Location = new System.Drawing.Point(517, 336);
            this.uxLogin.Name = "uxLogin";
            this.uxLogin.Size = new System.Drawing.Size(174, 64);
            this.uxLogin.TabIndex = 5;
            this.uxLogin.Text = "Login";
            this.uxLogin.UseVisualStyleBackColor = true;
            this.uxLogin.Click += new System.EventHandler(this.uxLogin_Click);
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(115, 336);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(174, 64);
            this.uxExit.TabIndex = 6;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(857, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "databaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.databaseDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxLogin);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPass);
            this.Controls.Add(this.uxUser);
            this.Controls.Add(this.uxWildcat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private databaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private databaseDataSet1TableAdapters.loginTableAdapter loginTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}

