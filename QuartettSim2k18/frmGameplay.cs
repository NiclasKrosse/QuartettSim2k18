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
    //Author Kateryna Dik
    public partial class frmGameplay : Form
    {
        public DeckStructure myDeckStructure;

        //todo  Bilder sind in einer festen Ordnerstruktur hinterlegt
        //todo Daruaus extrahieren
        private Dictionary<DeckStructure.Quartett, string> mImagePaths;
        private List<DeckStructure.QuartettCard> mKartenSpieler1 = new List<DeckStructure.QuartettCard>();
        private List<DeckStructure.QuartettCard> mKartenSpieler2 = new List<DeckStructure.QuartettCard>();
        private List<DeckStructure.QuartettCard> mKartenRest = new List<DeckStructure.QuartettCard>();

        private int mMaxKartenCount;

        //todo 1. Karten Verteilen
        //todo 2. Vergleiche Einbauen
        //Todo 3. Ergebnisse ausgeben

        public void Init()
        {
            mMaxKartenCount = myDeckStructure.listOfQuartetts.Count * 4 / 3;
            LitenFüllen();
            CurrentCard = mKartenSpieler1.FirstOrDefault();
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
                                if (mKartenSpieler1.Count <= mMaxKartenCount)
                                {
                                    mKartenSpieler1.Add(tmpQuartettCard);
                                    nKarteZugewiesen = true;
                                }
                                break;
                            case 2:
                                if (mKartenSpieler2.Count <= mMaxKartenCount)
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
            while (mKartenSpieler1.Count < mMaxKartenCount || mKartenSpieler2.Count < mMaxKartenCount)
            {
                foreach (DeckStructure.QuartettCard tmpQuartettCard in mKartenRest)
                {
                    Random nZufall = new Random();
                    if (nZufall.Next(1, 3) == 1 && mKartenSpieler1.Count < mMaxKartenCount)
                    {
                        mKartenSpieler1.Add(tmpQuartettCard);
                    }
                    else if (nZufall.Next(1, 3) == 1 && mKartenSpieler2.Count < mMaxKartenCount)
                    {
                        mKartenSpieler2.Add(tmpQuartettCard);
                    }
                }
            }
            mPropertyLabelList.Add(label_P1);
            mPropertyLabelList.Add(label_P2);
            mPropertyLabelList.Add(label_P3);
            mPropertyLabelList.Add(label_P4);
            mPropertyLabelList.Add(label_P5);
            mPropertyLabelList.Add(label_P6);

        }

        #region Vergleiche

        private void EigenschaftSelected(object sender, EventArgs e)
        {
            DeckStructure.CardProperties selectedCardProperty;
            Label nPropertyLabel = (Label)sender;
            selectedCardProperty = myCurrentQuartettCard.cardProperties.ElementAt(int.Parse(nPropertyLabel.Tag.ToString()));

            VergleicheKarte(selectedCardProperty);
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
                UpdateShownCard();
            }
        }

        //todo Nur so viele Labels wie benötigt einblenden
        private List<Label> mPropertyLabelList = new List<Label>();
        private void UpdateShownCard()
        {
            label_Kartenname.Text = myCurrentQuartettCard.cardName;
            //Bild laden
            try
            {
                pictureBox1.ImageLocation = myCurrentQuartettCard.cardImagePath;
                pictureBox1.Load();
            }
            catch (Exception e)
            {

            }

            int counter = 0;
            foreach (Label tmpLabel in mPropertyLabelList)
            {
                if (counter < myCurrentQuartettCard.cardProperties.Count && myCurrentQuartettCard.cardProperties.ElementAt(counter).propertyName != null)
                {
                    tmpLabel.Text = myCurrentQuartettCard.cardProperties.ElementAt(counter).propertyName + ": " +
                                    myCurrentQuartettCard.cardProperties.ElementAt(counter).propertyDisplayValue;
                }
                else
                {
                    tmpLabel.Text = "";
                }

                counter++;
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
                    DeckStructure.QuartettCard tmpcard = mKartenRest.First();
                    mKartenSpieler1.Add(tmpcard);
                    mKartenRest.Remove(tmpcard);
                }
                else
                {
                    EndGame();
                }
            }
            label_KartenDu.Text = "Du hast noch " + mKartenSpieler1.Count.ToString() + " Karten!\nDu hast "+PunkteSpieler1+" Punkte.";
            //Hat Spieler 2 noch Karten
            if (mKartenSpieler2.Count == 0)
            {
                if (mKartenRest.Count != 0)
                {
                    DeckStructure.QuartettCard tmpcard = mKartenRest.First();
                    mKartenSpieler1.Add(tmpcard);
                    mKartenRest.Remove(tmpcard);
                }
                else
                {
                    EndGame();
                }
            }
            label_KartenGegner.Text = "COM1 hat noch " + mKartenSpieler2.Count.ToString() + " Karten!\nCOM1 hat "+PunkteSpieler2 +" Punkte.";
            label_Status.Text =
                "Es befinden sich noch " + mKartenRest.Count.ToString() + " Karten auf dem Restestapel!";

        }

        //Todo eventuell Punkezähler implementieren
        private int PunkteSpieler1;
        private int PunkteSpieler2;

        private void EndGame()
        {
            if (PunkteSpieler1 > PunkteSpieler2)
            {
                MessageBox.Show("Du hast gewonnen!\nGlückwunsch", "Glückwunsch", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (PunkteSpieler2 < PunkteSpieler1)
            {
                MessageBox.Show("Du hast verloren!\nDas ist unschön", "Verloren", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            
            {
                MessageBox.Show("Unentschieden!\nAlle haben gewonnen und so...", "Unentschieden", MessageBoxButtons.OK,
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
            if (karteDesGegners.cardProperties is null)
            {
                return;
            }
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
                else
                {
                    AddKarteToRest(karteDesGegners);
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
                else
                {
                    AddKarteToRest(karteDesGegners);
                }
            }
        }

        //Karten bekommen/ entfernen/ umdisponieren etc.
        private DeckStructure.QuartettCard GetKarteFromOpponent()
        {
            DeckStructure.QuartettCard myLocalCard = new DeckStructure.QuartettCard();
            Random nZufallszahl = new Random();
            if (mKartenSpieler2.Count!= 0) myLocalCard = mKartenSpieler2.ElementAt(nZufallszahl.Next(0, mKartenSpieler2.Count));
            return myLocalCard;
        }

        private void RemoveKarteFromOpponent(DeckStructure.QuartettCard myLocalCard)
        {
            mKartenSpieler2.Remove(myLocalCard);
            mKartenSpieler1.Add(myLocalCard);
            PunkteSpieler1 += 10;
        }

        private void RemoveKarteFromMe()
        {
            mKartenSpieler1.Remove(CurrentCard);
            mKartenSpieler2.Add(CurrentCard);
            if (mKartenSpieler1.Count > 0)
            {
                CurrentCard = mKartenSpieler1.First();
            }
            
            PunkteSpieler2 += 10;
        }

        private void AddKarteToRest(DeckStructure.QuartettCard myCard)
        {
            mKartenSpieler1.Remove(CurrentCard);
            mKartenSpieler2.Remove(myCard);
            mKartenRest.Add(myCard);
            if (mKartenSpieler1.Count > 0)
            {
                CurrentCard = mKartenSpieler1.First();
            }

            
        }

        #endregion

        public frmGameplay()
        {
            InitializeComponent();
        }
    }
}
