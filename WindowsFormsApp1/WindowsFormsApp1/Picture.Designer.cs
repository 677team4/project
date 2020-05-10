namespace WindowsFormsApp1
{
    partial class Picture
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
            this.uxSave = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxFileName = new System.Windows.Forms.Label();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxExit = new System.Windows.Forms.Button();
            this.uxPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSave
            // 
            this.uxSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSave.Location = new System.Drawing.Point(404, 58);
            this.uxSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(188, 39);
            this.uxSave.TabIndex = 1;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(10, 11);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(390, 184);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File name:";
            // 
            // uxFileName
            // 
            this.uxFileName.AutoSize = true;
            this.uxFileName.Location = new System.Drawing.Point(67, 199);
            this.uxFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFileName.Name = "uxFileName";
            this.uxFileName.Size = new System.Drawing.Size(13, 13);
            this.uxFileName.TabIndex = 7;
            this.uxFileName.Text = "?";
            // 
            // uxOpen
            // 
            this.uxOpen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOpen.Location = new System.Drawing.Point(404, 10);
            this.uxOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(188, 39);
            this.uxOpen.TabIndex = 9;
            this.uxOpen.Text = "Open";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxExit
            // 
            this.uxExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxExit.Location = new System.Drawing.Point(404, 154);
            this.uxExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxExit.Name = "uxExit";
            this.uxExit.Size = new System.Drawing.Size(188, 39);
            this.uxExit.TabIndex = 10;
            this.uxExit.Text = "Exit";
            this.uxExit.UseVisualStyleBackColor = true;
            this.uxExit.Click += new System.EventHandler(this.uxExit_Click);
            // 
            // uxPic
            // 
            this.uxPic.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPic.Location = new System.Drawing.Point(404, 106);
            this.uxPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxPic.Name = "uxPic";
            this.uxPic.Size = new System.Drawing.Size(188, 39);
            this.uxPic.TabIndex = 11;
            this.uxPic.Text = "Picture on file";
            this.uxPic.UseVisualStyleBackColor = true;
            this.uxPic.Click += new System.EventHandler(this.uxPic_Click);
            // 
            // Picture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(600, 240);
            this.Controls.Add(this.uxPic);
            this.Controls.Add(this.uxExit);
            this.Controls.Add(this.uxOpen);
            this.Controls.Add(this.uxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.uxSave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Picture";
            this.Text = "Picture";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxFileName;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.Button uxExit;
        private System.Windows.Forms.Button uxPic;
    }
}