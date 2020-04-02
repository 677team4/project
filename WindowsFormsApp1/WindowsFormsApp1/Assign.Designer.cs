namespace WindowsFormsApp1
{
    partial class Assign
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
            this.uxExit = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxExit
            // 
            this.uxExit.Location = new System.Drawing.Point(282, 314);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(234, 71);
            this.uxExit.TabIndex = 3;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Welders",
            "Inspectors"});
            this.checkedListBox1.Location = new System.Drawing.Point(258, 69);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(285, 154);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Assign";
            // 
            // Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(807, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.uxExit);
            this.Name = "Assign";
            this.Text = "Assign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}