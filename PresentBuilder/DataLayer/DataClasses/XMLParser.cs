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
                XDocument xmlDoc = XDocument.Load(nameFile);
                XElement? root = xmlDoc.Element("Sweets");
                if (obj is Sweet)
                {
                    root.Add((obj as Sweet).CreateXml());
                } else
                {
                    root.Add((obj as Cookie).CreateXml());
                }
                xmlDoc.Save(nameFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Remove(Sweets obj)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load(nameFile);
                XElement? root = xmlDoc.Element("Sweets");
                if (obj is Sweet)
                {
                    XElement xElement = (obj as Sweet).CreateXml();
                    root.Elements("Sweet").FirstOrDefault(p => p.Element("name").Value == xElement.Element("name").Value).Remove();
                } else
                {
                    XElement xElement = (obj as Cookie).CreateXml();
                    root.Elements("Cookie").FirstOrDefault(p => p.Element("name").Value == xElement.Element("name").Value).Remove();
                }
                xmlDoc.Save(nameFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Sweets> GetList() {
            List<Sweets> result = new List<Sweets>();
            try{
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(nameFile); 
                foreach (XmlNode node in xmlDocument.DocumentElement.ChildNodes)
                {
                    string name = node.ChildNodes[0].InnerText;
                    int weight = Convert.ToInt32(node.ChildNodes[1].InnerText);
                    int sugarPercent = Convert.ToInt32(node.ChildNodes[2].InnerText);
                    string type = node.ChildNodes[3].InnerText;
                    if (node.Name == "Sweet")
                    {
                        result.Add(new Sweet(weight,sugarPercent, name, type));
                    } else {
                        result.Add(new Cookie(weight, sugarPercent, name, type));
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
