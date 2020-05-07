namespace WindowsFormsApp1
{
    partial class Signature
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSubmit = new System.Windows.Forms.Button();
            this.uxLogout = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInspector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(311, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 22);
            this.textBox2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welder Signature";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inspector Signature";
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(414, 327);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(218, 47);
            this.uxSubmit.TabIndex = 21;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // uxLogout
            // 
            this.uxLogout.Location = new System.Drawing.Point(173, 327);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(218, 47);
            this.uxLogout.TabIndex = 20;
            this.uxLogout.Text = "Exit";
            this.uxLogout.UseVisualStyleBackColor = true;
            this.uxLogout.Click += new System.EventHandler(this.uxLogout_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(311, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 22);
            this.textBox3.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID";
            // 
            // uxInspector
            // 
            this.uxInspector.AutoSize = true;
            this.uxInspector.Font = new System.Drawing.Font("Myanmar Text", 41.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInspector.Location = new System.Drawing.Point(99, 20);
            this.uxInspector.Name = "uxInspector";
            this.uxInspector.Size = new System.Drawing.Size(611, 123);
            this.uxInspector.TabIndex = 24;
            this.uxInspector.Text = "Complete Project";
            // 
            // Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxInspector);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "Signature";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Signature_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSubmit;
        private System.Windows.Forms.Button uxLogout;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label uxInspector;
    }
}