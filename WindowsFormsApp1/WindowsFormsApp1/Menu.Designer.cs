﻿namespace WindowsFormsApp1
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
            this.uxLogout = new System.Windows.Forms.Button();
            this.uxLogs = new System.Windows.Forms.Button();
            this.uxWelds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxManager
            // 
            this.uxManager.AutoSize = true;
            this.uxManager.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxManager.Location = new System.Drawing.Point(85, 40);
            this.uxManager.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxManager.Name = "uxManager";
            this.uxManager.Size = new System.Drawing.Size(274, 97);
            this.uxManager.TabIndex = 1;
            this.uxManager.Text = "Manager";
            // 
            // uxLogout
            // 
            this.uxLogout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogout.Location = new System.Drawing.Point(152, 246);
            this.uxLogout.Margin = new System.Windows.Forms.Padding(2);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(130, 56);
            this.uxLogout.TabIndex = 2;
            this.uxLogout.Text = "Logout";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxLogs
            // 
            this.uxLogs.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogs.Location = new System.Drawing.Point(229, 161);
            this.uxLogs.Margin = new System.Windows.Forms.Padding(2);
            this.uxLogs.Name = "uxLogs";
            this.uxLogs.Size = new System.Drawing.Size(130, 56);
            this.uxLogs.TabIndex = 4;
            this.uxLogs.Text = "View Logs";
            this.uxLogs.UseVisualStyleBackColor = true;
            this.uxLogs.Click += new System.EventHandler(this.uxLogs_Click);
            // 
            // uxWelds
            // 
            this.uxWelds.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelds.Location = new System.Drawing.Point(75, 161);
            this.uxWelds.Margin = new System.Windows.Forms.Padding(2);
            this.uxWelds.Name = "uxWelds";
            this.uxWelds.Size = new System.Drawing.Size(130, 56);
            this.uxWelds.TabIndex = 5;
            this.uxWelds.Text = "Add Welds";
            this.uxWelds.UseVisualStyleBackColor = true;
            this.uxWelds.Click += new System.EventHandler(this.uxWelds_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(430, 347);
            this.Controls.Add(this.uxWelds);
            this.Controls.Add(this.uxLogs);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.uxManager);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Manager Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxManager;
        private System.Windows.Forms.Button uxLogout;
        private System.Windows.Forms.Button uxLogs;
        private System.Windows.Forms.Button uxWelds;
    }
}