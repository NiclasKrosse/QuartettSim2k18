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

        //todo  Bilder sind in einer festen Ordnerstruktur hinterlegt
        //todo Daruaus extrahieren
        private Dictionary<DeckStructure.Quartett, string> mImagePaths;
        private List<DeckStructure.QuartettCard> mKartenSpieler1 = new List<DeckStructure.QuartettCard>();
        private List<DeckStructure.QuartettCard> mKartenSpieler2 = new List<DeckStructure.QuartettCard>();
        private List<DeckStructure.QuartettCard> mKartenRest = new List<DeckStructure.QuartettCard>();

        private int nMaxKartenCount;

        //todo 1. Karten Verteilen
        //todo 2. Vergleiche Einbauen
        //Todo 3. Ergebnisse ausgeben

        public void Init()
        {
            nMaxKartenCount = myDeckStructure.listOfQuartetts.Count * 4 / 3;
            LitenFüllen();
            myCurrentQuartettCard = mKartenSpieler1.First();
        }

        private void LitenFüllen()
        {
            foreach (DeckStructure.Quartett tmpQuartett in myDeckStructure.listOfQuartetts)
            {
                foreach (DeckStructure.QuartettCard tmpQuartettCard in tmpQuartett.Cards)
                {
                    Boolean nKarteZugewiesen = false;
                    Random nZufall = new Random();
                    while (!nKarteZugewiesen)
                    {
                        switch (nZufall.Next(1, 4))
                        {
                            case 1:
                                if (mKartenSpieler1.Count <= nMaxKartenCount)
                                {
                                    mKartenSpieler1.Add(tmpQuartettCard);
                                    nKarteZugewiesen = true;
                                }
                                break;
                            case 2:
                                if (mKartenSpieler2.Count <= nMaxKartenCount)
                                {
                                    mKartenSpieler2.Add(tmpQuartettCard);
                                    nKarteZugewiesen = true;
                                }
                                break;
                            default:
                                mKartenRest.Add(tmpQuartettCard);
                                nKarteZugewiesen = true;
                                break;
                        }
                    }

                }
            }
            //Durch den Restestapel gehen, falls Karten fehlen sollten
            while (mKartenSpieler1.Count < nMaxKartenCount || mKartenSpieler2.Count < nMaxKartenCount)
            {
                foreach (DeckStructure.QuartettCard tmpQuartettCard in mKartenRest)
                {
                    Random nZufall = new Random();
                    if (nZufall.Next(1,3) == 1 && mKartenSpieler1.Count < nMaxKartenCount)
                    {
                        mKartenSpieler1.Add(tmpQuartettCard);
                    }
                    else if (nZufall.Next(1, 3) == 1 && mKartenSpieler2.Count < nMaxKartenCount)
                    {
                        mKartenSpieler2.Add(tmpQuartettCard);
                    }
                }
            }

        }

        #region Vergleiche

        private void EigenschaftSelected(object sender, EventArgs e)
        {
            VergleicheKarte();
            CheckIfPlayerHasCardsLeft();
        }

        //todo Eigene Karte auswählen
        private DeckStructure.QuartettCard myCurrentQuartettCard;
        private DeckStructure.QuartettCard CurrentCard
        {
            get { return myCurrentQuartettCard; }
            set
            {
                myCurrentQuartettCard = value;
                //todo Anzeige überarbeiten
            }
        }

        //todo Überprüfen ob Quartett vollständig
        private void CheckIfPlayerHasCardsLeft()
        {
            //Hat Spieler 1 noch Karten
            if (mKartenSpieler1.Count == 0)
            {
                if (mKartenRest.Count != 0)
                {
                    mKartenSpieler1.Add(mKartenRest.First());
                }
                else
                {
                    EndGame(2);
                }
            }

            //Hat Spieler 2 noch Karten
            if (mKartenSpieler2.Count == 0)
            {
                if (mKartenRest.Count != 0)
                {
                    mKartenSpieler2.Add(mKartenRest.First());
                }
                else
                {
                    EndGame(1);
                }
            }
        }

        //Todo eventuell Punkezähler implementieren
        private void EndGame(int winner)
        {
            if (winner == 1)
            {
                MessageBox.Show("Du hast gewonnen!\nGlückwunsch", "Glückwunsch", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Du hast verloren!\nDas ist unschön", "Verloren", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            this.Close();
        }

        //todo Überprüfen,ob noch Karten da sind

        private void VergleicheKarte(DeckStructure.CardProperties eigenschaft)
        {
            //todo Karte vom Gegner bekommen
            DeckStructure.QuartettCard karteDesGegners = GetKarteFromOpponent();
            DeckStructure.CardProperties propertyDesGegners = new DeckStructure.CardProperties();

            foreach (DeckStructure.CardProperties tmpProperties in karteDesGegners.cardProperties)
            {
                if (tmpProperties.propertyName == eigenschaft.propertyName)
                {
                    propertyDesGegners = tmpProperties;
                }
            }

            //Vergleichen
            if (eigenschaft.greaterIsBetter)
            {
                if (eigenschaft.propertyValue > propertyDesGegners.propertyValue)
                {
                    //Ich bekomme die Karte
                    RemoveKarteFromOpponent(karteDesGegners);
                }
                else if (eigenschaft.propertyValue < propertyDesGegners.propertyValue)
                {
                    //Der Gegner bekommt die Karte
                    RemoveKarteFromMe();
                }
            }
            else
            {
                if (eigenschaft.propertyValue > propertyDesGegners.propertyValue)
                {
                    //Der Gegner bekommt die Karte
                    RemoveKarteFromMe();
                }
                else if (eigenschaft.propertyValue < propertyDesGegners.propertyValue)
                {
                    //Ich bekomme die Karte
                    RemoveKarteFromOpponent(karteDesGegners);
                }
            }
        }

        //Karten bekommen/ entfernen/ umdisponieren etc.
        private DeckStructure.QuartettCard GetKarteFromOpponent()
        {
            DeckStructure.QuartettCard myLocalCard = new DeckStructure.QuartettCard();
            Random nZufallszahl = new Random();
            myLocalCard = mKartenSpieler2.ElementAt(nZufallszahl.Next(1, mKartenSpieler2.Count));
            return myLocalCard;
        }

        private void RemoveKarteFromOpponent(DeckStructure.QuartettCard myLocalCard)
        {
            mKartenSpieler2.Remove(myLocalCard);
            mKartenSpieler1.Add(myLocalCard);
        }

        private void RemoveKarteFromMe()
        {
            mKartenSpieler1.Remove(CurrentCard);
            mKartenSpieler2.Add(CurrentCard);
            CurrentCard = mKartenSpieler1.First();
        }

        #endregion

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
