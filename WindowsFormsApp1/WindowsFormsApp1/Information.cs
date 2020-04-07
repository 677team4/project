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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void uxPhoto_Click(object sender, EventArgs e)
        {
            Photo p1 = new Photo();
            p1.Show();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.assignment23DataSet);

        }

        private void Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment23DataSet.Logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter.Fill(this.assignment23DataSet.Logs);

        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
