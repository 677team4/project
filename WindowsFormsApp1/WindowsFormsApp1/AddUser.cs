using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ACVUMLR\\SQLEXPRESS;Initial Catalog=assignment23;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Login (Username, Password) VALUES (@Username, @Password)";
                    command.Parameters.AddWithValue("@Username", uxUsername.Text);
                    command.Parameters.AddWithValue("@Password", uxPassword.Text);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    MessageBox.Show("User Added");
                }
            }
        }
    }
}
