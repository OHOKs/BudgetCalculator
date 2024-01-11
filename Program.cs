using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetCalc.Items;
using BudgetCalc.Background_Functions;
using BudgetCalc.Display_Functions;

namespace BudgetCalc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            List<Item> list = new List<Item>();
            BackgroundFunctions BackgrroundFunctions = new BackgroundFunctions();
            DisplayFunctions DisplayFunctions = new DisplayFunctions();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            //Test WriteJSON
            /*list.Add(new Item() 
            { 
                ID = 1,
                date = new int[] { 2005, 01, 01 },
                sum = 1000,
                category = "Haztartas",
                description = "Mososzer"
            });
            list.Add(new Item()
            {
                ID = 2,
                date = new int[] { 2005, 01, 01 },
                sum = 2000,
                category = "Haztartas",
                description = "szappan"
            });

            BackgrroundFunctions.WriteJSON(list, "D:/");*/

            //Test ReadJSON
            /*list = BackgrroundFunctions.ReadJSON("D:/");
            MessageBox.Show(list[0].description);*/
        }
    }
}
