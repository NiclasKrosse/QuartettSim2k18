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
    public partial class frmGameplay : Form
    {
        public DeckStructure MyDeckStructure;
        public GameMode MyGameMode;

        public enum GameMode
        {
            AufZeit,LastManStanding,FourQuartett 
        }
        public frmGameplay()
        {
            InitializeComponent();
        }
    }
}