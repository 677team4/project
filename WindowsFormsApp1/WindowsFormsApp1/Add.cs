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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            

        }

        private void uxSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ACVUMLR\\SQLEXPRESS;Initial Catalog=assignment23;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;            
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Logs (StartDate, Unit, Equipment, UnitManager, Welder, Inspector, Shift1or2, Notes) VALUES (@StartDate, @Unit, @Equipment, @UnitManager, @Welder, @Inspector, @Shift1or2, @Notes)";
                    command.Parameters.AddWithValue("@StartDate", textBox1.Text);
                    command.Parameters.AddWithValue("@Unit", textBox2.Text);
                    command.Parameters.AddWithValue("@Equipment", textBox3.Text);
                    command.Parameters.AddWithValue("@UnitManager", textBox4.Text);
                    command.Parameters.AddWithValue("@Welder", textBox5.Text);
                    command.Parameters.AddWithValue("@Inspector", textBox6.Text);
                    command.Parameters.AddWithValue("@Shift1or2", textBox7.Text);
                    command.Parameters.AddWithValue("@Notes", textBox8.Text);

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

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
