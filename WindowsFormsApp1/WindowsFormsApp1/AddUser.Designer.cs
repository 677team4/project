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
            this.uxAdd.Location = new System.Drawing.Point(465, 356);
            this.uxAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(173, 64);
            this.uxAdd.TabIndex = 13;
            this.uxAdd.Text = "Add User";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(185, 356);
            this.uxExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(173, 64);
            this.uxExit.TabIndex = 12;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxPassword
            // 
            this.uxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPassword.Location = new System.Drawing.Point(287, 252);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.PasswordChar = '*';
            this.uxPassword.Size = new System.Drawing.Size(415, 36);
            this.uxPassword.TabIndex = 11;
            // 
            // uxUsername
            // 
            this.uxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUsername.Location = new System.Drawing.Point(287, 167);
            this.uxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(415, 36);
            this.uxUsername.TabIndex = 10;
            // 
            // uxPass
            // 
            this.uxPass.AutoSize = true;
            this.uxPass.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPass.Location = new System.Drawing.Point(119, 257);
            this.uxPass.Name = "uxPass";
            this.uxPass.Size = new System.Drawing.Size(118, 31);
            this.uxPass.TabIndex = 9;
            this.uxPass.Text = "Password:";
            // 
            // uxUser
            // 
            this.uxUser.AutoSize = true;
            this.uxUser.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUser.Location = new System.Drawing.Point(119, 172);
            this.uxUser.Name = "uxUser";
            this.uxUser.Size = new System.Drawing.Size(125, 31);
            this.uxUser.TabIndex = 8;
            this.uxUser.Text = "Username:";
            // 
            // uxWildcat
            // 
            this.uxWildcat.AutoSize = true;
            this.uxWildcat.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWildcat.Location = new System.Drawing.Point(207, 29);
            this.uxWildcat.Name = "uxWildcat";
            this.uxWildcat.Size = new System.Drawing.Size(418, 123);
            this.uxWildcat.TabIndex = 7;
            this.uxWildcat.Text = "Add A User\r\n";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.uxPass);
            this.Controls.Add(this.uxUser);
            this.Controls.Add(this.uxWildcat);
            this.Name = "AddUser";
            this.Text = "AddUser";
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