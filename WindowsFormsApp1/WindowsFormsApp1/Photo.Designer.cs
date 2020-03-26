namespace WindowsFormsApp1
{
    partial class Photo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxUpload = new System.Windows.Forms.Button();
            this.uxBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxUpload
            // 
            this.uxUpload.Location = new System.Drawing.Point(541, 365);
            this.uxUpload.Name = "uxUpload";
            this.uxUpload.Size = new System.Drawing.Size(173, 51);
            this.uxUpload.TabIndex = 1;
            this.uxUpload.Text = "Upload Weld Photo";
            this.uxUpload.UseVisualStyleBackColor = true;
            this.uxUpload.Click += new System.EventHandler(this.uxUpload_Click);
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(54, 365);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(173, 51);
            this.uxBack.TabIndex = 2;
            this.uxBack.Text = "Go Back";
            this.uxBack.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxUpload);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Photo";
            this.Text = "Weld";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uxUpload;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}