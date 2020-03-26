namespace WindowsFormsApp1
{
    partial class Menu
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
            this.uxManager = new System.Windows.Forms.Label();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxJobs = new System.Windows.Forms.Button();
            this.uxLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxManager
            // 
            this.uxManager.AutoSize = true;
            this.uxManager.Font = new System.Drawing.Font("Algerian", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxManager.Location = new System.Drawing.Point(166, 7);
            this.uxManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxManager.Name = "uxManager";
            this.uxManager.Size = new System.Drawing.Size(283, 60);
            this.uxManager.TabIndex = 1;
            this.uxManager.Text = "Manager";
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(235, 300);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(130, 56);
            this.uxExit.TabIndex = 2;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxJobs
            // 
            this.uxJobs.Location = new System.Drawing.Point(235, 96);
            this.uxJobs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxJobs.Name = "uxJobs";
            this.uxJobs.Size = new System.Drawing.Size(130, 56);
            this.uxJobs.TabIndex = 3;
            this.uxJobs.Text = "Assign Jobs";
            this.uxJobs.UseVisualStyleBackColor = true;
            this.uxJobs.Click += new System.EventHandler(this.uxJobs_Click);
            // 
            // uxLogs
            // 
            this.uxLogs.Location = new System.Drawing.Point(235, 195);
            this.uxLogs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLogs.Name = "uxLogs";
            this.uxLogs.Size = new System.Drawing.Size(130, 56);
            this.uxLogs.TabIndex = 4;
            this.uxLogs.Text = "View Logs";
            this.uxLogs.UseVisualStyleBackColor = true;
            this.uxLogs.Click += new System.EventHandler(this.uxLogs_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uxLogs);
            this.Controls.Add(this.uxJobs);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxManager);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxManager;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Button uxJobs;
        private System.Windows.Forms.Button uxLogs;
    }
}