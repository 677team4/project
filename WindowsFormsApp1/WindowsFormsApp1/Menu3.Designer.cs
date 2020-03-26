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
            this.uxExit = new System.Windows.Forms.Button();
            this.uxView = new System.Windows.Forms.Button();
            this.uxInspections = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // uxInspector
            // 
            this.uxInspector.AutoSize = true;
            this.uxInspector.Font = new System.Drawing.Font("Algerian", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInspector.Location = new System.Drawing.Point(158, 7);
            this.uxInspector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxInspector.Name = "uxInspector";
            this.uxInspector.Size = new System.Drawing.Size(300, 60);
            this.uxInspector.TabIndex = 2;
            this.uxInspector.Text = "Inspector";
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(235, 300);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(130, 56);
            this.uxExit.TabIndex = 3;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxView
            // 
            this.uxView.Location = new System.Drawing.Point(236, 215);
            this.uxView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(130, 56);
            this.uxView.TabIndex = 7;
            this.uxView.Text = "View Information";
            this.uxView.UseVisualStyleBackColor = true;
            this.uxView.Click += new System.EventHandler(this.uxView_Click);
            // 
            // uxInspections
            // 
            this.uxInspections.FormattingEnabled = true;
            this.uxInspections.Items.AddRange(new object[] {
            "Inspection 1",
            "Inspection 2",
            "Inspection 3"});
            this.uxInspections.Location = new System.Drawing.Point(202, 95);
            this.uxInspections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxInspections.MultiColumn = true;
            this.uxInspections.Name = "uxInspections";
            this.uxInspections.Size = new System.Drawing.Size(197, 94);
            this.uxInspections.TabIndex = 6;
            // 
            // Menu3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uxView);
            this.Controls.Add(this.uxInspections);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxInspector);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu3";
            this.Text = "Menu3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInspector;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Button uxView;
        private System.Windows.Forms.CheckedListBox uxInspections;
    }
}