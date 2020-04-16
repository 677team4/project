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
            this.uxView = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uxUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxView
            // 
            this.uxView.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxView.Location = new System.Drawing.Point(721, 449);
            this.uxView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxView.Name = "uxView";
            this.uxView.Size = new System.Drawing.Size(231, 63);
            this.uxView.TabIndex = 1;
            this.uxView.Text = "Upload";
            this.uxView.UseVisualStyleBackColor = true;
            this.uxView.Click += new System.EventHandler(this.uxView_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(72, 449);
            this.uxExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(231, 63);
            this.uxExit.TabIndex = 2;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uxUpload
            // 
            this.uxUpload.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxUpload.Location = new System.Drawing.Point(400, 449);
            this.uxUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uxUpload.Name = "uxUpload";
            this.uxUpload.Size = new System.Drawing.Size(231, 63);
            this.uxUpload.TabIndex = 3;
            this.uxUpload.Text = "Save";
            this.uxUpload.UseVisualStyleBackColor = true;
            // 
            // Photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.uxUpload);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxView);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Photo";
            this.Text = "Weld";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button uxView;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button uxUpload;
    }
}