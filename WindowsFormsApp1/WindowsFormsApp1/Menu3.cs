﻿using System;
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
    public partial class Menu3 : Form
    {
        public Menu3()
        {
            InitializeComponent();
        }

        private void uxExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void uxView_Click(object sender, EventArgs e)
        {
            Information i = new Information();
            i.Show();
        }

        private void uxJob_Click(object sender, EventArgs e)
        {
            Signature s = new Signature();
            s.s = true;
            s.Show();
        }
    }
}
