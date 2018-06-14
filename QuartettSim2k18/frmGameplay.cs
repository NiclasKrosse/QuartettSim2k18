using System;
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
        public DeckStructure myDeckStructure;
        public GameMode MyGameMode;
        private List<DeckStructure.QuartettCard> kartenSpieler1;
        private List<DeckStructure.QuartettCard> kartenSpieler2;
        private List<DeckStructure.QuartettCard> kartenRest;

        private void KartenVerteilen()
        {
            foreach (DeckStructure.Quartett tmpQuartett in myDeckStructure.listOfQuartetts)
            {
                foreach (DeckStructure.QuartettCard tmpQuartetCard in tmpQuartett.Cards)
                {
                    // имеет ли игрок 10 карт
           
                    
                }

            }
        } 7

        

        public enum GameMode
        {
            AufZeit,LastManStanding,FourQuartett 
        }
        public frmGameplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmGameplay_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
