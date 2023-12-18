using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentBuilder.Gui;

namespace PresentBuilder.DataLayer.DataClasses
{
    public class Present
    {
        private List <Sweets> presentList = new List <Sweets> ();

        public Present() {}
        public Present(List<Sweets> presentList)
        {
            this.presentList = presentList;
        }

        public void Add(Sweets obj)
        {
            presentList.Add(obj);
        }

        public Sweets FindByString(string objString)
        {
            Sweets result = null;
            foreach (var item in presentList)
            {
                if (((item is Sweet) && (item as Sweet).ToString() == objString) || ((item is Cookie) && (item as Cookie).ToString() == objString))
                {
                    result = item;
                    break;
                }
            }
            return result;
        }

        public void Remove(Sweets obj)
        {
            presentList.Remove(obj);
        }

        public int FindBySugar(int sugarPercent)
        {
            int position = -1;
            for (int i = 0; i < presentList.Count; i++) { 
                if (presentList[i].SugarPercent == sugarPercent)
                {
                    position = i;
                }
            }
            return position;
        }

        public List <Sweets> GetPresentList()
        {
            return this.presentList;
        }

        public void Sort(int type)
        {
            switch(type)
            {
                case 1:
                    presentList.Sort((x, y) => x.Name.CompareTo(y.Name)); 
                    break;
                case 2:
                    presentList.Sort((x, y) => x.Weight.CompareTo(y.Weight));
                    break;
                case 3:
                    presentList.Sort((x,y) => x.SugarPercent.CompareTo(y.SugarPercent));
                    break;
                default: 
                    break;
            }
        }

    }
}
