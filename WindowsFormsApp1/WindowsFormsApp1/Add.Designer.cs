namespace WindowsFormsApp1
{
    partial class Add
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
            this.uxWildcat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxWildcat
            // 
            this.uxWildcat.AutoSize = true;
            this.uxWildcat.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWildcat.ForeColor = System.Drawing.Color.Black;
            this.uxWildcat.Location = new System.Drawing.Point(133, 9);
            this.uxWildcat.Name = "uxWildcat";
            this.uxWildcat.Size = new System.Drawing.Size(431, 123);
            this.uxWildcat.TabIndex = 1;
            this.uxWildcat.Text = "Add a Weld";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.uxWildcat);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWildcat;
    }
}