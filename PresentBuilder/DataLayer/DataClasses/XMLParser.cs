using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace PresentBuilder.DataLayer.DataClasses
{
    internal class XMLParser
    {

        private string nameFile;

        public XMLParser(string nameFile) {
            this.nameFile = nameFile;
        }

        public void Add(Sweets obj)
        {
            try
            {
                XDocument xmlDoc = new XDocument(nameFile);
                if (obj is Sweet)
                {
                    xmlDoc.Root.Add((obj as Sweet).CreateXml());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Sweets> GetList() {
            List<Sweets> result = new List<Sweets>();
             try{
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(nameFile);
                foreach (XmlNode ths in xmlDoc.DocumentElement.ChildNodes)
                {
                    int weight = Convert.ToInt32(ths.ChildNodes[0].InnerText);
                    int sugarPercent = Convert.ToInt32(ths.ChildNodes[1].InnerText);
                    string name = ths.ChildNodes[2].InnerText;
                    string type = ths.ChildNodes[3].InnerText;
                    if (ths.Name == "Cookie")
                    {
                        result.Add(new Cookie(weight, sugarPercent, name, type));
                    }
                    else
                    {
                        result.Add(new Sweet(weight, sugarPercent, name, type));
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        

    }
}
