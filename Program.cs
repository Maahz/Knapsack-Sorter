using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Knapsack_Sorter
{
    //Use value to weight ratio to calculate most valuable content
    public class Knapsack
    {
        private static int Size = 20;
        internal static List<Item> Content = new List<Item>();
        private int space = Size - Content.Count;

        public Knapsack(Item stuff)
        {
            Content.Add(stuff);
        }

    }
    
    public class Item
    {
        public string Name;
        public double Value;
        public double Weight;
        public double Ratio;
        public Item(string name, double value, double weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
            Ratio = (value / weight);
        }
    }

    

    class Program
    {
        
        static void Main(string[] args)
        {
            //Create itempool and add items
            #region "ItemPool"
            List<Item> itemPool = new List<Item>();
            itemPool.Add(new Item("Bone", 1, 56));
            itemPool.Add(new Item("Axe", 50, 18));
            itemPool.Add(new Item("Shotgun", 1231, 36));
            itemPool.Add(new Item("Bike", 200, 112));
            itemPool.Add(new Item("Car", 5000, 1564));
            itemPool.Add(new Item("Condom", 696, 1));
            itemPool.Add(new Item("Socks", 5, 5));
            itemPool.Add(new Item("Kittens", 10, 62));
            itemPool.Add(new Item("Crowbar", 20, 57));
            itemPool.Add(new Item("Flashlight", 50, 10));
            itemPool.Add(new Item("Candy", 3, .12));
            itemPool.Add(new Item("Bazooka", 1654, 598));
            itemPool.Add(new Item("Rifle", 1234, 74));
            itemPool.Add(new Item("Pistol", 510, 5.9));
            itemPool.Add(new Item("Money", 52312, 10));
            itemPool.Add(new Item("Bullets", 50, 92));
            itemPool.Add(new Item("Coke", 1231, 59));
            itemPool.Add(new Item("Pipe", 20, 90));
            itemPool.Add(new Item("Wrench", 12, 25));
            itemPool.Add(new Item("Hammer", 11, 23));
            itemPool.Add(new Item("Book", 12.30, 52));
            itemPool.Add(new Item("Hat", 10.90, 21));
            itemPool.Add(new Item("Shirt", 15.20, 5));
            itemPool.Add(new Item("Pants", 15.20, 7));
            itemPool.Add(new Item("Undies", 5, 6.2));
            itemPool.Add(new Item("Bra", 10, 13.1));
            itemPool.Add(new Item("Shoes", 64.20, 23));
            itemPool.Add(new Item("Mittens", 42, 5));
            itemPool.Add(new Item("Beanie", 20, 9));
            itemPool.Add(new Item("Holster", 113, 18));
            #endregion

            foreach (Item item in itemPool)
            {
                //Add items to knapsack
            }

            foreach (Item item in Knapsack.Content)
            {
                Console.WriteLine(item.Name + " " + (item.Ratio).ToString());
            }
            Console.Read();
        }
    }
}
