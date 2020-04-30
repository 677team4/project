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
    public partial class Menu4 : Form
    {
        public Menu4()
        {
            InitializeComponent();
        }

        private void uxLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            AddUser u = new AddUser();
            u.Show();
        }

        private void uxJob_Click(object sender, EventArgs e)
        {
            Add a = new Add();
            a.Show();
        }
    }
}
