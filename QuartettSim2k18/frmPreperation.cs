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
    public partial class frmPreperation : Form
    {
        public frmPreperation()
        {
            InitializeComponent();
        }

        private void button_DeckDef_Click(object sender, EventArgs e)
        {
            DeckAssistant myAssistant = new DeckAssistant();
            frmDeckEdit myDeckEdit = new frmDeckEdit();
            myDeckEdit.ShowDialog();
        }

        DeckStructure myDeckStructure = new DeckStructure();
        private void button_DeckWählen_Click(object sender, EventArgs e)
        {
            DeckAssistant myDeckAssistant = new DeckAssistant();
            openFileDialog1.ShowDialog();
            myDeckStructure = myDeckAssistant.DeserializeDeck(openFileDialog1.FileName);
            //todo Liste mit den Zuletzt ausgewählten Decks erstellen.
        }

        private void button_SpielStarten_Click(object sender, EventArgs e)
        {
            frmGameplay myFrmGameplay = new frmGameplay();
            myFrmGameplay.MyDeckStructure = myDeckStructure;
            if (myDeckStructure.listOfQuartetts.Count != 0)
            {
                myFrmGameplay.Show();
            }
        }
    }
}
