﻿namespace WindowsFormsApp1
{
    partial class Menu4
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
            this.uxJob = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxLogout = new System.Windows.Forms.Button();
            this.uxAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxJob
            // 
            this.uxJob.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxJob.Location = new System.Drawing.Point(216, 172);
            this.uxJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxJob.Name = "uxJob";
            this.uxJob.Size = new System.Drawing.Size(130, 56);
            this.uxJob.TabIndex = 12;
            this.uxJob.Text = "Add Weld";
            this.uxJob.UseVisualStyleBackColor = true;
            this.uxJob.Click += new System.EventHandler(this.uxJob_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdd.Location = new System.Drawing.Point(63, 172);
            this.uxAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(130, 56);
            this.uxAdd.TabIndex = 11;
            this.uxAdd.Text = "Add User";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxLogout
            // 
            this.uxLogout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLogout.Location = new System.Drawing.Point(141, 258);
            this.uxLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(130, 56);
            this.uxLogout.TabIndex = 10;
            this.uxLogout.Text = "Logout";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxLogout_Click);
            // 
            // uxAdmin
            // 
            this.uxAdmin.AutoSize = true;
            this.uxAdmin.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAdmin.Location = new System.Drawing.Point(101, 51);
            this.uxAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAdmin.Name = "uxAdmin";
            this.uxAdmin.Size = new System.Drawing.Size(214, 97);
            this.uxAdmin.TabIndex = 9;
            this.uxAdmin.Text = "Admin";
            // 
            // Menu4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(392, 366);
            this.Controls.Add(this.uxJob);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.uxAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu4";
            this.Text = "Admin Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxJob;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxLogout;
        private System.Windows.Forms.Label uxAdmin;
    }
}