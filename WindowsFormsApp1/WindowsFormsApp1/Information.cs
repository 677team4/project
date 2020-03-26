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
    }
}
