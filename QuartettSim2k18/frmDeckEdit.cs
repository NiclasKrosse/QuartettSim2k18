using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuartettSim2k18
{
    public partial class frmDeckEdit : Form
    {
        public frmDeckEdit()
        {
            InitializeComponent();
            FillPanelList();
        }

        #region Controls

        private void label_NewQuartett_MouseHover(object sender, EventArgs e)
        {
            Label myLabel = (Label)sender;
            myLabel.ForeColor = Color.DeepPink;
        }

        private void label_NewQuartett_MouseLeave(object sender, EventArgs e)
        {
            Label myLabel = (Label)sender;
            myLabel.ForeColor = Color.AliceBlue;
        }

        private void ResetControls()
        {
            textBox_DeckName.Text = "";
            textBox_DeckName.ResetBackColor();
            numericUpDown_AnzahlEiggenschaften.Value = 4;
            numericUpDown_AnzahlQuartetts.Value = 8;
        }
        #endregion

        #region DeckStructure

        private int mQuartettAmount;
        private int mProprtiesAmount;
        private string mDeckName;
        private string mDeckPath;

        private DeckAssistant myDeckAssistant;

        private void label_NewDeck_Click(object sender, EventArgs e)
        {
            //init deckassistant
            if (myDeckAssistant != null)
            {
                if (MessageBox.Show(
                        "Möchten Sie wirklich ein neues Deck erstellen? \nIhre aktuellen Änderungen gehen dadurch verloren!",
                        "Neues Deck erstellen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    myDeckAssistant = new DeckAssistant();
                    ResetControls();
                }
            }
            else
            {
                myDeckAssistant = new DeckAssistant();
                ResetControls();
            }

            PanelIndex = 1;
            panel_NewQuartett.Visible = true;
        }

        private void SelectSavePath(object sender, EventArgs e)
        {
            if (folderBrowserDialog_Speicherort.ShowDialog() == DialogResult.OK)
            {
                mDeckPath = folderBrowserDialog_Speicherort.SelectedPath;

                label_SpeicherortValue.Text = mDeckPath;
                label_SpeicherortValue.ForeColor = Color.White;
            }
        }

        private void label_Zwischenspeichern_Click(object sender, EventArgs e)
        {
            if (!Zwischenspeichern())
            {
                MessageBox.Show("Zwischenspeichern nicht möglich.\nBitte überprüfen Sie die fehlenden Angaben.",
                    "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                panel_Karteninfos.Visible = true;
                label_Zwischenspeichern.Visible = false;
                label_QuartettDef.Enabled = false;
            }

        }

        private Boolean Zwischenspeichern()
        {
            Boolean success = true;
            mQuartettAmount = Convert.ToInt32(numericUpDown_AnzahlQuartetts.Value);
            mProprtiesAmount = Convert.ToInt32(numericUpDown_AnzahlEiggenschaften.Value);
            if (textBox_DeckName.Text != "")
            {
                mDeckName = textBox_DeckName.Text;
            }
            else
            {
                success = false;
                textBox_DeckName.BackColor = Color.DeepPink;
            }

            if (mDeckPath == "")
            {
                success = false;
                label_SpeicherortValue.Text = "Speicherort wählen!";
                label_SpeicherortValue.ForeColor = Color.DeepPink;
            }

            foreach (TextBox tmpTextBox in mPropertyTextBoxList)
            {
                if (Convert.ToInt32(tmpTextBox.Tag) <= mProprtiesAmount)
                {
                    success = tmpTextBox.Text != "";
                }
            }
            //todo In den Deck Assistant übermitteln
            if (myDeckAssistant.myDeckStructure == null)
            {
                myDeckAssistant.myDeckStructure = new DeckStructure();
                myDeckAssistant.myDeckStructure.deckName = mDeckName;
            }
            else
            {
                myDeckAssistant.myDeckStructure.deckName = mDeckName;
            }
            RenameAndShowProperties();

            return success;
        }

        private void RenameAndShowProperties()
        {
            foreach (Label tempLabel in mPropertyLabelList)
            {
                int currenttag = Convert.ToInt32(tempLabel.Tag);
                if (currenttag <= mProprtiesAmount)
                {
                    tempLabel.Visible = true;
                    mPropertyValueTextBoxList.ElementAt(currenttag - 1).Visible = true;
                    mPropertyDisplayValueTextBoxList.ElementAt(currenttag - 1).Visible = true;
                    tempLabel.Text = mPropertyTextBoxList.ElementAt(currenttag - 1).Text;
                }
                else
                {
                    tempLabel.Visible = false;
                    mPropertyValueTextBoxList.ElementAt(currenttag - 1).Visible = false;
                    mPropertyDisplayValueTextBoxList.ElementAt(currenttag - 1).Visible = false;
                }
            }
        }

        #endregion

        #region PanelSwitch


        private int mPanelIndex;
        private int PanelIndex
        {
            get { return mPanelIndex; }
            set
            {
                mPanelIndex = value;
                foreach (Panel tmpPanel in mQuartettPanelList)
                {
                    if (Convert.ToInt32(tmpPanel.Tag) == mPanelIndex)
                        tmpPanel.Visible = true;
                    else
                    {
                        tmpPanel.Visible = false;
                    }
                }
            }
        }

        //todo Liste der Panels anlegen
        List<Panel> mQuartettPanelList = new List<Panel>();
        List<Panel> mPropertyPanelList = new List<Panel>();
        List<TextBox> mPropertyTextBoxList = new List<TextBox>();

        List<Label> mPropertyLabelList = new List<Label>();
        List<TextBox> mPropertyValueTextBoxList = new List<TextBox>();
        List<TextBox> mPropertyDisplayValueTextBoxList = new List<TextBox>();

        List<CheckButton> mCheckButtonsList = new List<CheckButton>();

        private void FillPanelList()
        {
            mQuartettPanelList.Add(panel_Eigenschaften);
            mQuartettPanelList.Add(panel_QuartettDef);
            mQuartettPanelList.Add(panel_KartenDef);
            //Page 2
            mPropertyPanelList.Add(panel_Eigenschaft1);
            mPropertyPanelList.Add(panel_Eigenschaft2);
            mPropertyPanelList.Add(panel_Eigenschaft3);
            mPropertyPanelList.Add(panel_Eigenschaft4);
            mPropertyPanelList.Add(panel_Eigenschaft5);
            mPropertyPanelList.Add(panel_Eigenschaft6);

            mPropertyTextBoxList.Add(textBox_Eigenschaft1);
            mPropertyTextBoxList.Add(textBox_Eigenschaft2);
            mPropertyTextBoxList.Add(textBox_Eigenschaft3);
            mPropertyTextBoxList.Add(textBox_Eigenschaft4);
            mPropertyTextBoxList.Add(textBox_Eigenschaft5);
            mPropertyTextBoxList.Add(textBox_Eigenschaft6);

            mCheckButtonsList.Add(checkButton_BiB);
            mCheckButtonsList.Add(checkButton_BiB1);
            mCheckButtonsList.Add(checkButton_BiB3);
            mCheckButtonsList.Add(checkButton_BiB4);
            mCheckButtonsList.Add(checkButton_BiB5);
            mCheckButtonsList.Add(checkButton_BiB6);

            //Page 3
            mPropertyLabelList.Add(label_P1);
            mPropertyLabelList.Add(label_P2);
            mPropertyLabelList.Add(label_P3);
            mPropertyLabelList.Add(label_P4);
            mPropertyLabelList.Add(label_P5);
            mPropertyLabelList.Add(label_P6);

            mPropertyValueTextBoxList.Add(textBox_Value1);
            mPropertyValueTextBoxList.Add(textBox_Value2);
            mPropertyValueTextBoxList.Add(textBox_Value3);
            mPropertyValueTextBoxList.Add(textBox_Value4);
            mPropertyValueTextBoxList.Add(textBox_Value5);
            mPropertyValueTextBoxList.Add(textBox_Value6);

            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue1);
            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue2);
            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue3);
            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue4);
            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue5);
            mPropertyDisplayValueTextBoxList.Add(textBox_DisplayValue6);

        }


        private void label_QuartetteDefinieren_Click(object sender, EventArgs e)
        {
            try
            {
                Label myLabel = (Label)sender;
                PanelIndex = Convert.ToInt32(myLabel.Tag);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }


        }
        private void panel_QuartettDef_VisibleChanged(object sender, EventArgs e)
        {
            if (panel_QuartettDef.Visible)
            {
                foreach (Panel panel in mPropertyPanelList)
                {
                    if (Convert.ToInt32(panel.Tag) <= numericUpDown_AnzahlEiggenschaften.Value)
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }

            }
        }


        #endregion

        #region Cards

        private List<DeckStructure.Quartett> mQuartetts = new List<DeckStructure.Quartett>();
        private List<DeckStructure.QuartettCard> mQuartettCards = new List<DeckStructure.QuartettCard>();
        private DeckStructure.Quartett myCurrentQuartett = new DeckStructure.Quartett();

        private void button_BildWählen_Click(object sender, EventArgs e)
        {
            OpenFileDialog localFolderBrowserDialog = new OpenFileDialog();
            localFolderBrowserDialog.ShowDialog();
            try
            {
                pictureBox_Image.ImageLocation = localFolderBrowserDialog.FileName;
                pictureBox_Image.Load(localFolderBrowserDialog.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Kein gültiges Bild ausgewählt!");
            }
        }

        private void button_NextCard_Click(object sender, EventArgs e)
        {
            if (SaveQuartettCard())
            {
                ClearCardControls();
                label_Kartennummer.Text = "Karte " + (mQuartettCards.Count + 1);
                if (mQuartettCards.Count == 3)
                {
                    button_NextCard.Enabled = false;
                    button_NextQuartett.Enabled = true;
                    //Todo Button weiter ausblenden
                }
            }
            else
            {
                MessageBox.Show("Überprüfen Sie Ihre Eingaben!", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }


        }

        private void ClearCardControls()
        {
            foreach (TextBox tmpTextBox in mPropertyDisplayValueTextBoxList)
            {
                tmpTextBox.Text = "";
            }

            foreach (var tmpTextBox in mPropertyValueTextBoxList)
            {
                tmpTextBox.Text = "";
            }

            textBox_CardName.Text = "";
            pictureBox_Image.ImageLocation = "";
        }

        //todo Declare Current Quartett
        //Todo Save When all 4 Cards are done
        private Boolean SaveQuartettCard()
        {
            Boolean nResult = true;
            List<DeckStructure.CardProperties> nCardProperties = new List<DeckStructure.CardProperties>();
            DeckStructure.QuartettCard nCard = new DeckStructure.QuartettCard();
            try
            {

                if (textBox_CardName.Text != "")
                {
                    nCard.cardName = textBox_CardName.Text;
                }
                else
                {
                    nResult = false;
                }

                if (pictureBox_Image.ImageLocation != "")
                {
                    nCard.cardImagePath = pictureBox_Image.ImageLocation;
                }

                for (int i = 1; i < mProprtiesAmount + 1; i++)
                {

                    DeckStructure.CardProperties myCardProperties = new DeckStructure.CardProperties();
                    myCardProperties.propertyName = mPropertyTextBoxList.ElementAt(i - 1).Text;
                    myCardProperties.propertyDisplayValue = mPropertyDisplayValueTextBoxList.ElementAt(i - 1).Text;
                    myCardProperties.propertyValue = double.Parse(mPropertyValueTextBoxList.ElementAt(i - 1).Text);
                    myCardProperties.greaterIsBetter = mCheckButtonsList.ElementAt(i - 1).Checked;
                    nCardProperties.Add(myCardProperties);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                nResult = false;
            }

            if (nResult)
            {
                nCard.cardProperties = nCardProperties;
                mQuartettCards.Add(nCard);
            }
            return nResult;
        }


        private void button_NextQuartett_Click(object sender, EventArgs e)
        {
            if (!SaveQuartettCard())
            {
                MessageBox.Show("Überprüfen Sie Ihre Eingaben!", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (textBox_Quartettname.Text != "")
            {
                myCurrentQuartett.Cards = mQuartettCards;
                myCurrentQuartett.quartettNummer = mQuartetts.Count + 1;
                mQuartetts.Add(myCurrentQuartett);

                //Clear for next use
                myCurrentQuartett = new DeckStructure.Quartett();
                mQuartettCards = new List<DeckStructure.QuartettCard>();

                ClearCardControls();
                label_Kartennummer.Text = "Karte " + (mQuartettCards.Count + 1);

                button_NextQuartett.Enabled = false;
                button_NextCard.Enabled = true;

                //todo Wenn gewünschte Anzahl an Quartetten erreicht ist, dann Wandle diesen Button in einen "Abschließen Button um"
                if (mQuartetts.Count == (mQuartettAmount - 1))
                {
                    button_NextQuartett.Text = "Abschliessen";
                }

                if (mQuartetts.Count == mQuartettAmount)
                {
                    ExportDeck();
                }
            }

        }

        private void ExportDeck()
        {
            string nExportPath = mDeckPath + @"\" + mDeckName;
            //Quartette übergeben
            myDeckAssistant.myDeckStructure.deckName = mDeckName;
            myDeckAssistant.myDeckStructure.listOfQuartetts = mQuartetts;

            //Ordner anlegen todo Wenn das nicht geht, anderen Pfad anbieten
            try
            {
                if (!Directory.Exists(nExportPath))
                {
                    Directory.CreateDirectory(nExportPath);
                }

                myDeckAssistant.ExportXml(myDeckAssistant.myDeckStructure,nExportPath,mDeckName);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        #endregion
    }
}
