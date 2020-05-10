namespace WindowsFormsApp1
{
    partial class Menu3
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
            this.uxInspector = new System.Windows.Forms.Label();
            this.uxLogout = new System.Windows.Forms.Button();
            this.uxView = new System.Windows.Forms.Button();
            this.uxJob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxInspector
            // 
            this.uxInspector.AutoSize = true;
            this.uxInspector.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInspector.Location = new System.Drawing.Point(74, 29);
            this.uxInspector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxInspector.Name = "uxInspector";
            this.uxInspector.Size = new System.Drawing.Size(283, 97);
            this.uxInspector.TabIndex = 2;
            this.uxInspector.Text = "Inspector";
            // 
            // uxLogout
            // 
            this.uxLogout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogout.Location = new System.Drawing.Point(143, 236);
            this.uxLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(130, 56);
            this.uxLogout.TabIndex = 3;
            this.uxLogout.Text = "Logout";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxView
            // 
            this.uxView.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxView.Location = new System.Drawing.Point(65, 150);
            this.uxView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(130, 56);
            this.uxView.TabIndex = 7;
            this.uxView.Text = "View Information";
            this.uxView.UseVisualStyleBackColor = true;
            this.uxView.Click += new System.EventHandler(this.uxView_Click);
            // 
            // uxJob
            // 
            this.uxJob.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxJob.Location = new System.Drawing.Point(218, 150);
            this.uxJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxJob.Name = "uxJob";
            this.uxJob.Size = new System.Drawing.Size(130, 56);
            this.uxJob.TabIndex = 8;
            this.uxJob.Text = "Complete Job";
            this.uxJob.UseVisualStyleBackColor = true;
            this.uxJob.Click += new System.EventHandler(this.uxJob_Click);
            // 
            // Menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(422, 332);
            this.Controls.Add(this.uxJob);
            this.Controls.Add(this.uxView);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.uxInspector);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu3";
            this.Text = "Inspector Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInspector;
        private System.Windows.Forms.Button uxLogout;
        private System.Windows.Forms.Button uxView;
        private System.Windows.Forms.Button uxJob;
    }
}