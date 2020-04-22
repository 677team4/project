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
            this.components = new System.ComponentModel.Container();
            this.uxWildcat = new System.Windows.Forms.Label();
            this.assignment23DataSet = new WindowsFormsApp1.Assignment23DataSet();
            this.assignment23DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new WindowsFormsApp1.Assignment23DataSetTableAdapters.LogsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.uxLogout = new System.Windows.Forms.Button();
            this.uxSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
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
            // assignment23DataSet
            // 
            this.assignment23DataSet.DataSetName = "Assignment23DataSet";
            this.assignment23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assignment23DataSetBindingSource
            // 
            this.assignment23DataSetBindingSource.DataSource = this.assignment23DataSet;
            this.assignment23DataSetBindingSource.Position = 0;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.assignment23DataSetBindingSource;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manager";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Equipment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Inspector";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Welder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Shift";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(228, 252);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(228, 299);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(336, 22);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(228, 345);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(336, 22);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(228, 403);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(336, 22);
            this.textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(228, 446);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(336, 22);
            this.textBox8.TabIndex = 17;
            // 
            // uxLogout
            // 
            this.uxLogout.Location = new System.Drawing.Point(132, 487);
            this.uxLogout.Name = "uxLogout";
            this.uxLogout.Size = new System.Drawing.Size(218, 47);
            this.uxLogout.TabIndex = 18;
            this.uxLogout.Text = "Logout";
            this.uxLogout.UseVisualStyleBackColor = true;
            // 
            // uxSubmit
            // 
            this.uxSubmit.Location = new System.Drawing.Point(373, 487);
            this.uxSubmit.Name = "uxSubmit";
            this.uxSubmit.Size = new System.Drawing.Size(218, 47);
            this.uxSubmit.TabIndex = 19;
            this.uxSubmit.Text = "Submit";
            this.uxSubmit.UseVisualStyleBackColor = true;
            this.uxSubmit.Click += new System.EventHandler(this.uxSubmit_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(706, 546);
            this.Controls.Add(this.uxSubmit);
            this.Controls.Add(this.uxLogout);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxWildcat);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment23DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxWildcat;
        private System.Windows.Forms.BindingSource assignment23DataSetBindingSource;
        private Assignment23DataSet assignment23DataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private Assignment23DataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button uxLogout;
        private System.Windows.Forms.Button uxSubmit;
    }
}