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
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void logsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectDataSet);

        }

        private void Logs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignment23DataSet.Logs' table. You can move, or remove it, as needed.
            this.logsTableAdapter1.Fill(this.assignment23DataSet.Logs);

        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }
    }
}
