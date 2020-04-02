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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void uxJobs_Click(object sender, EventArgs e)
        {
            Assign a1 = new Assign();
            a1.Show();
        }

        private void uxLogs_Click(object sender, EventArgs e)
        {
            Logs l = new Logs();
            l.Show();
        }
    }
}
