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

        private bool Check(string u, string p)
        {
            for (int i = 0; i < assignment23DataSet.Tables["Login"].Rows.Count; i++)
            {
                for (int j = 0; j < assignment23DataSet.Tables["Login"].Columns.Count; j++)
                {
                    Object o = assignment23DataSet.Tables["Login"].Rows[i][j];
                    String sqluser = o.ToString();
                    Object ob = assignment23DataSet.Tables["Login"].Rows[i][j];
                    String sqlpass = ob.ToString();
                    if (sqluser == u && sqlpass == p)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void uxLogin_Click(object sender, EventArgs e)
        {
            //Check User and Pass
            bool check = Check(uxUsername.Text, uxPassword.Text);
            if(check == true)
            {
                this.Hide();
                MessageBox.Show("Login Successful!");
                if (uxUsername.Text == "Manager")
                {
                    Menu m1 = new Menu();
                    m1.Show();
                }
                else if (uxUsername.Text == "Welder")
                {
                    Menu2 m2 = new Menu2();
                    m2.Show();
                }
                else if (uxUsername.Text == "Inspector")
                {
                    Menu3 m3 = new Menu3();
                    m3.Show();
                }
                else if (uxUsername.Text == "Admin")
                {
                    Menu4 m4 = new Menu4();
                    m4.Show();
                }
                else
                {
                    MessageBox.Show("User has no access please get admin to give correct permissions.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, Try Again.");
            }
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment23DataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.assignment23DataSet.Login);
            // TODO: This line of code loads data into the 'databaseDataSet1.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.databaseDataSet1.login);

        }
    }
}
