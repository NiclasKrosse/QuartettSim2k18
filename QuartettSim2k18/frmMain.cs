﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartettSim2k18
{
    //Author Niclas Krosse
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            frmPreperation nFrmPreperation = new frmPreperation();
            nFrmPreperation.ShowDialog();

        }
    }
}
