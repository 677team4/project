namespace WindowsFormsApp1
{
    partial class Menu2
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
            this.uxWelder = new System.Windows.Forms.Label();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxWelds = new System.Windows.Forms.CheckedListBox();
            this.uxView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxWelder
            // 
            this.uxWelder.AutoSize = true;
            this.uxWelder.Font = new System.Drawing.Font("Algerian", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWelder.Location = new System.Drawing.Point(191, 7);
            this.uxWelder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxWelder.Name = "uxWelder";
            this.uxWelder.Size = new System.Drawing.Size(233, 60);
            this.uxWelder.TabIndex = 2;
            this.uxWelder.Text = "Welder";
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
            // uxWelds
            // 
            this.uxWelds.FormattingEnabled = true;
            this.uxWelds.Items.AddRange(new object[] {
            "Weld 1",
            "Weld 2",
            "Weld 3"});
            this.uxWelds.Location = new System.Drawing.Point(201, 93);
            this.uxWelds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxWelds.Name = "uxWelds";
            this.uxWelds.Size = new System.Drawing.Size(197, 94);
            this.uxWelds.TabIndex = 4;
            // 
            // uxView
            // 
            this.uxView.Location = new System.Drawing.Point(235, 222);
            this.uxView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(130, 56);
            this.uxView.TabIndex = 5;
            this.uxView.Text = "View Information";
            this.uxView.UseVisualStyleBackColor = true;
            this.uxView.Click += new System.EventHandler(this.uxView_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uxView);
            this.Controls.Add(this.uxWelds);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxWelder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu2";
            this.Text = "Menu2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWelder;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.CheckedListBox uxWelds;
        private System.Windows.Forms.Button uxView;
    }
}