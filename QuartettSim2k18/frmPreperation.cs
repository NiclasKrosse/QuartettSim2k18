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
    public partial class frmPreperation : Form
    {
        public frmPreperation()
        {
            InitializeComponent();
        }

        private void button_DeckDef_Click(object sender, EventArgs e)
        {
            DeckAssistant myAssistant = new DeckAssistant();
            //myAssistant.SetDeckStructure();

            frmDeckEdit myDeckEdit = new frmDeckEdit();
            myDeckEdit.ShowDialog();
        }
    }
}
