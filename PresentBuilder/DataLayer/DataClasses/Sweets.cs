using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PresentBuilder.DataLayer.DataClasses
{
    public class Sweets : IComparable{
        private int weight; //in grams
        private int sugarPercent; // 0-100%
        private string name; 
        public int Weight { get; set; }
        public int SugarPercent { get { return sugarPercent; } set {  sugarPercent = Math.Min(value, 100); } }
        public string Name { get; set; }

        public Sweets() : this(0, 0, "") { }
        public Sweets(int weight, int sugarPercent, string name)
        {
            Weight = weight;
            SugarPercent = sugarPercent;
            Name = name;
        }

        public virtual XElement CreateXml()
        {
            XElement Sweet = new XElement("Sweet");
            Sweet.Add(new XElement("name", Name));
            Sweet.Add(new XElement("weight", Weight));
            Sweet.Add(new XElement("sugarPercent", SugarPercent));
            return Sweet;

        }

        public int CompareTo(object obj)
        {
            if (obj is Sweets == false) return 0;
            return (obj as Sweet).Weight - Weight;
        }

        public override string ToString()
        {
            return $"Название продукта - {Name}, содержание сахара {SugarPercent}%,\nвес {Weight} г. ";
        }

    }
}
