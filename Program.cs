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
        internal static double space = Size;

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
        
        static void Main()
        {
            
            //Create itempool and add items
            #region "ItemPool"
            List<Item> itemPool = new List<Item>();
            itemPool.Add(new Item("Bone", 3, 1));
            itemPool.Add(new Item("Axe", 50, 3));
            itemPool.Add(new Item("Shotgun", 1231, 5));
            itemPool.Add(new Item("Bike", 200, 10));
            itemPool.Add(new Item("Condom", 696, 1));
            itemPool.Add(new Item("Socks", 5, 1));
            itemPool.Add(new Item("Kittens", 10, 3));
            itemPool.Add(new Item("Crowbar", 20, 3));
            itemPool.Add(new Item("Flashlight", 50, 2));
            itemPool.Add(new Item("Candy", 3, 1));
            itemPool.Add(new Item("Bazooka", 1654, 6));
            itemPool.Add(new Item("Rifle", 1234, 4));
            itemPool.Add(new Item("Pistol", 510, 2));
            itemPool.Add(new Item("Money", 523, 2));
            itemPool.Add(new Item("Bullets", 50, 1));
            itemPool.Add(new Item("Coke", 123, 1));
            itemPool.Add(new Item("Pipe", 20, 3));
            itemPool.Add(new Item("Wrench", 12, 2));
            itemPool.Add(new Item("Hammer", 11, 2));
            itemPool.Add(new Item("Book", 12.30, 1));
            itemPool.Add(new Item("Hat", 10.90, 1));
            itemPool.Add(new Item("Shirt", 15.20, 1));
            itemPool.Add(new Item("Pants", 15.20, 1));
            itemPool.Add(new Item("Undies", 5, 1));
            itemPool.Add(new Item("Bra", 10, 1));
            itemPool.Add(new Item("Shoes", 64.20, 1));
            itemPool.Add(new Item("Mittens", 42, 1));
            itemPool.Add(new Item("Beanie", 20, 1));
            itemPool.Add(new Item("Holster", 113, 2));
            #endregion

            //Some mildly useful values
            double value = 0;
            List<Item> tempPool = WorkerClass.ListSort(itemPool);


            for (int i = 0; i < 20; i++)
            {
                //Add 20 items from sorted list to Knapsack    
                Knapsack.Content.Add(tempPool[i]);
            }

            //Print results
            foreach (Item item in Knapsack.Content)
            {
                value += item.Value; //Calculate value
                Knapsack.space -= item.Weight;
                Console.WriteLine(item.Name + " : " + item.Ratio);
            }

            Console.WriteLine("Value:  " + value);
            Console.Read();
        }

        
    }
}
