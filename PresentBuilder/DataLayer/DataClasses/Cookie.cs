using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PresentBuilder.DataLayer.DataClasses
{
    public class Cookie : Sweets
    {
        public enum CookieType
        {
            Chokolate = 1,
            Fruity = 2,
            Walnut = 3,
            None = 0
        }

        private CookieType type;
        public string Type
        {
            get
            {
                switch (type)
                {
                    case CookieType.Chokolate:
                        return "шоколадная";
                    case CookieType.Walnut:
                        return "с орехами";
                    case CookieType.Fruity:
                        return "фруктовая";
                    default:
                        return "None";
                }
            }
            set
            {
                switch (value)
                {
                    case "шоколадное":
                        type = CookieType.Chokolate;
                        break;
                    case "с орехами":
                        type = CookieType.Fruity;
                        break;
                    case "фруктовое":
                        type = CookieType.Walnut;
                        break;
                    default:
                        type = CookieType.None;
                        break;
                }
            }
        }
        public Cookie() : this(0, 0, "", "0") { }
        public Cookie(int weight, int sugarPercent, string name, string type) : base(weight, sugarPercent, name)
        {
            Type = type;
        }

        public virtual XElement CreateXml()
        {
            XElement Sweet = base.CreateXml();
            Sweet.Name = "Cookie";
            Sweet.Add(new XElement("type", Type));
            return Sweet;
        }

        public string ToString()
        {
            return base.ToString() + $"тип печенья {Type}";
        }
    }

}
