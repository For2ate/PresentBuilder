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


    }
}
