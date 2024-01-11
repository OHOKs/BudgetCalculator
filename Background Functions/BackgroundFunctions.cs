using BudgetCalc.Items;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetCalc.Background_Functions
{
    internal class BackgroundFunctions
    {
        public List<Item> ReadJSON(string path)
        {
            List<Item> itemList;
            string json;
            bool isFileExist = File.Exists($@"{path}\BudgetCalcData.json");

            if (isFileExist)
            {
                json = File.ReadAllText($@"{path}\BudgetCalcData.json");

                itemList = JsonConvert.DeserializeObject<List<Item>>(json);

                return itemList;
            }
            else
            {
                MessageBox.Show("Non-existent file, New file generated!");

                var myFile = File.Create($@"{path}\BudgetCalcData.json");
                myFile.Close();

                return new List<Item>();
            }
        }
        public void WriteJSON(List<Item> list, string path)
        {
            List<Item> itemList = new List<Item>();

            if (list.Count() != 0)
            {
                foreach (var item in list)
                {
                    itemList.Add(new Item()
                    {
                        ID = item.ID,
                        date = item.date,
                        sum = item.sum,
                        category = item.category,
                        description = item.description
                    });
                }

                string json = JsonConvert.SerializeObject(itemList, Newtonsoft.Json.Formatting.Indented);

                File.Delete($@"{path}\BudgetCalcData.json");

                File.WriteAllText($@"{path}\BudgetCalcData.json", json);
            }
        }
        /*public List<Item> UpdateItem()
        {

        }
        public List <Item> DeleteItem()
        {

        }
        public List <Item> AddItem()
        {

        }
        public Item GetItem()
        { 

        }*/

    }
}
