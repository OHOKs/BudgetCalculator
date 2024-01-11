using System;

namespace BudgetCalc.Items
{
    public class Item
    {
        public int ID { get; set; }
        public int[] date { get; set; }
        public int sum { get; set; }
        public string category { get; set; }
        public string description { get; set; }
    }
}
