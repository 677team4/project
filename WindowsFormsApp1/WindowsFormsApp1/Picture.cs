using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Picture : Form
    {
        string fileName;

        public Picture()
        {
            InitializeComponent();
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    uxFileName.Text = fileName;
                    pictureBox.Image = Image.FromFile(fileName);
                }
            } 
        }

        byte[] ConvertImageToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ACVUMLR\\SQLEXPRESS;Initial Catalog=assignment23;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT into Photo (Data, FileName) VALUES (@Data, @FileName)";
                    command.Parameters.AddWithValue("@Data", ConvertImageToBinary(pictureBox.Image));
                    command.Parameters.AddWithValue("@FileName", fileName);

                    try
                    {
                        connection.Open();
                        int recordsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Saved to database.");
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
            this.Close();
        }

        private void uxPic_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-ACVUMLR\\SQLEXPRESS;Initial Catalog=assignment23;Integrated Security=True"))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT Filename FROM Photo";
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        fileName = (string)ds.Tables[0].Rows[ds.Tables[0].Rows.Count-1]["FileName"];
                        uxFileName.Text = fileName;
                        pictureBox.Image = Image.FromFile(fileName);
                    }
                }
            }
        }
    }
}
