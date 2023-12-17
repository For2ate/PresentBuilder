using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PresentBuilder.DataLayer.DataClasses
{
    public class Sweet : Sweets
    {
        public enum SweetsType{
            Chokolate = 1,
            Jelly = 2,
            Fruity = 3,
            Iris = 4,
            None = 0
        }

        private SweetsType type;
        public string Type
        {
            get
            {
                switch(type)
                {
                    case SweetsType.Chokolate:
                        return "шоколадная";
                    case SweetsType.Jelly:
                        return "желейная";
                    case SweetsType.Fruity:
                        return "фруктовая";
                    case SweetsType.Iris:
                        return "ирис";
                    default:
                        return "None";
                }
            }
            set
            {
                switch (value)
                {
                    case "шоколадная":
                        type = SweetsType.Chokolate;
                        break;
                    case "желейная":
                        type = SweetsType.Jelly;
                        break;
                    case "фруктовая":
                        type = SweetsType.Fruity;
                        break;
                    case "ирис":
                        type = SweetsType.Iris;
                        break;
                    default:
                        type = SweetsType.None; 
                        break;
                }
            }
        }
        
        public Sweet() : this(0,0,"","0") { }
        public Sweet(int weight, int sugarPercent, string name, string type) : base(weight, sugarPercent, name)
        {
            Type = type;
        }

        public virtual XElement CreateXml()
        { 
            XElement Sweet = base.CreateXml();
            Sweet.Name = "Sweet";
            Sweet.Add(new XElement("type", Type));
            return Sweet;
        }

            public string ToString()
        {
            return base.ToString() + $"тип конфеты {Type}";
        }

    }
}
