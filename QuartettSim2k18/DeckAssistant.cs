using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace QuartettSim2k18
{
    class DeckAssistant
    {
        public DeckStructure myDeckStructure;

        
        public void ExportXml(DeckStructure deckStructure,String exportPath, String fileName)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(DeckStructure));
            TextWriter myTextWriter = new StreamWriter(exportPath + @"\" + fileName);
            mySerializer.Serialize(myTextWriter,myDeckStructure);
            myTextWriter.Close();
        }

        public DeckStructure DeserializeDeck(string filename)
        {
            DeckStructure nDeckStructure = new DeckStructure();
            try
            {                
                XmlSerializer mySerializer = new XmlSerializer(typeof(DeckStructure));

                FileStream myFileStream = new FileStream(filename, FileMode.Open);
                XmlReader myReader = XmlReader.Create(myFileStream);

                nDeckStructure = (DeckStructure)mySerializer.Deserialize(myReader);
                myFileStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Fehler bei der Deserialisierung");
            }
            

            return nDeckStructure;
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
            public Boolean greaterIsBetter; //Bestimmt ob der größere wert beim Verglich der Bessere ist
        }
    }
}
