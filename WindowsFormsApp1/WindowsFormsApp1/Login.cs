using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool CheckPass(string p)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(p == dataGridView1.Rows[i].Text)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckUser(string u)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (p == dataGridView1.Rows[i].Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void uxLogin_Click(object sender, EventArgs e)
        {
            //Check User and Pass
            bool user= CheckUser(uxLogin.Text);
            bool pass = CheckPass(uxPassword.Text);
            if(user == true && pass == true)
            {
                MessageBox.Show("Login Successful!");
                Menu m1 = new Menu();
                m1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, Try Again.");
            }
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.databaseDataSet1.login);

        }
    }
}
