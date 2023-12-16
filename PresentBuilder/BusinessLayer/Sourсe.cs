using PresentBuilder.DataLayer.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PresentBuilder
{
    public class Sourse
    {

        private static Present present;
        private static MainWindow mainWindow = new MainWindow();
        private static XMLParser xmlParser = new XMLParser(Path.GetFullPath("C:\\Users\\Sabryn Kh\\source\\repos\\PresentBuilder\\PresentBuilder\\DataLayer\\Data\\SweetsBase.xml"));

        [STAThread()]
        static void Main()
        {
            FillLists(); 
            App app = new();
            app.Run(mainWindow); 
        }

        private static void FillLists()
        {
            present = new Present(xmlParser.GetList());
            mainWindow.presentListView.Items.Clear();
            foreach (var obj in present.GetPresentList())
            {
                mainWindow.AddInWindow(obj);
            }
        }

        public static void AddNewElement(Sweets obj) 
        {
            present.Add(obj);
            xmlParser.Add(obj);
            mainWindow.AddInWindow(obj);
        }

        


    }
}
