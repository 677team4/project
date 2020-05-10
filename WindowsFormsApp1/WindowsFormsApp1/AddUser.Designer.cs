namespace WindowsFormsApp1
{
    partial class AddUser
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
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxPass = new System.Windows.Forms.Label();
            this.uxUser = new System.Windows.Forms.Label();
            this.uxWildcat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(157, 289);
            this.uxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(130, 52);
            this.uxAdd.TabIndex = 13;
            this.uxAdd.Text = "Add User";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(314, 289);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(130, 52);
            this.uxExit.TabIndex = 12;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(207, 205);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(312, 30);
            this.uxPassword.TabIndex = 11;
            // 
            // uxUsername
            // 
            this.uxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(207, 136);
            this.uxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(312, 30);
            this.uxUsername.TabIndex = 10;
            // 
            // uxPass
            // 
            this.uxPass.AutoSize = true;
            this.uxPass.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPass.Location = new System.Drawing.Point(81, 209);
            this.uxPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxPass.Name = "uxPass";
            this.uxPass.Size = new System.Drawing.Size(94, 24);
            this.uxPass.TabIndex = 9;
            this.uxPass.Text = "Password:";
            // 
            // uxUser
            // 
            this.uxUser.AutoSize = true;
            this.uxUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUser.Location = new System.Drawing.Point(81, 140);
            this.uxUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxUser.Name = "uxUser";
            this.uxUser.Size = new System.Drawing.Size(100, 24);
            this.uxUser.TabIndex = 8;
            this.uxUser.Text = "Username:";
            // 
            // uxWildcat
            // 
            this.uxWildcat.AutoSize = true;
            this.uxWildcat.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWildcat.Location = new System.Drawing.Point(147, 24);
            this.uxWildcat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxWildcat.Name = "uxWildcat";
            this.uxWildcat.Size = new System.Drawing.Size(280, 97);
            this.uxWildcat.TabIndex = 7;
            this.uxWildcat.Text = "Add User\r\n";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(600, 386);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPass);
            this.Controls.Add(this.uxUser);
            this.Controls.Add(this.uxWildcat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.Label uxPass;
        private System.Windows.Forms.Label uxUser;
        private System.Windows.Forms.Label uxWildcat;
    }
}