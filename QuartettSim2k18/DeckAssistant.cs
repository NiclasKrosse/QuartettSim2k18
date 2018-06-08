using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QuartettSim2k18
{
    class DeckAssistant
    {
        public DeckStructure myDeckStructure;


        //public void SetDeckStructure()
        //{
        //    myDeckStructure = new DeckStructure();
        //    //Testdaten
        //    //todo 8 Quartetts //jeweils 4 Karten , das überprüfen
        //    myDeckStructure.deckName = "Testdeck";

        //    DeckStructure.Quartett myQuartett = new DeckStructure.Quartett();
        //    DeckStructure.QuartettCard myCard_1 = new DeckStructure.QuartettCard();
        //    DeckStructure.CardProperties myCardProperties = new DeckStructure.CardProperties();

        //    //Anzahl der Eigenschaften kann in der Ersetllungsmaske festgelegt werden
        //    //Alles ausser der Wert soll nur einmal gesetzt werden
        //    myCard_1.cardProperties = new List<DeckStructure.CardProperties>();
        //    myDeckStructure.listOfQuartetts = new List<DeckStructure.Quartett>();
        //    myQuartett.Cards = new List<DeckStructure.QuartettCard>();

        //    myCardProperties.propertyName = "Verbrauch: ";
        //    myCardProperties.greaterIsBetter = false;
        //    myCardProperties.propertyDisplayValue = "8 l/100km";
        //    myCardProperties.propertyValue = 8;
        //    myCard_1.cardProperties.Add(myCardProperties);

        //    myCardProperties.propertyName = "Leistung: ";
        //    myCardProperties.greaterIsBetter = true;
        //    myCardProperties.propertyDisplayValue = "160 PS";
        //    myCardProperties.propertyValue = 160;
        //    myCard_1.cardProperties.Add(myCardProperties);

        //    myCardProperties.propertyName = "Türen: ";
        //    myCardProperties.greaterIsBetter = true;
        //    myCardProperties.propertyDisplayValue = "5 Türen";
        //    myCardProperties.propertyValue = 5;
        //    myCard_1.cardProperties.Add(myCardProperties);

        //    myCardProperties.propertyName = "Gewicht: ";
        //    myCardProperties.greaterIsBetter = false;
        //    myCardProperties.propertyDisplayValue = "1600 kg";
        //    myCardProperties.propertyValue = 1600;
        //    myCard_1.cardProperties.Add(myCardProperties);

        //    myQuartett.Cards.Add(myCard_1);

        //    myDeckStructure.listOfQuartetts.Add(myQuartett);

        //    ExportXml(myDeckStructure);
        //}


        public void ExportXml(DeckStructure deckStructure,String exportPath)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(DeckStructure));
            TextWriter myTextWriter = new StreamWriter("test.xml");
            mySerializer.Serialize(myTextWriter,myDeckStructure);
            myTextWriter.Close();
        }
    }

    //Diese Klasse in XML Serialisieren; OrdnerSrukturen erstellen; etc...
    public class DeckStructure
    {
        public string deckName;
        public List<Quartett> listOfQuartetts;

        public struct Quartett
        {
            public int quartettNummer;
            public String quartettName;
            public List<QuartettCard> Cards;
        }
        public struct QuartettCard
        {
            public String cardName;
            public String cardImagePath;
            public List<CardProperties> cardProperties;
        }

        public struct CardProperties
        {
            public string propertyName; //z.B. Hubraum, Leistung, Gewicht
            public string propertyDisplayValue; //z.B. [Leistung] 200 PS
            public double propertyValue; //z.B [Leistung]200
            public Boolean greaterIsBetter; 
        }
    }
}
