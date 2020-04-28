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
    public partial class Signature : Form
    {
        public Signature()
        {
            InitializeComponent();        
        }

        
        public bool s;

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ACVUMLR\\SQLEXPRESS;Initial Catalog=assignment23;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Logs SET InspectorSignature = @is, WelderSignature = @ws WHERE ID = @id";
                    command.Parameters.AddWithValue("@is", textBox1.Text);
                    command.Parameters.AddWithValue("@ws", textBox2.Text);
                    command.Parameters.AddWithValue("@id", textBox3.Text);

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
                }
            }
        }

        private void uxLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Signature_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
