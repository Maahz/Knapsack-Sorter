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
            
            Knapsack.Content.Add(new Item("Bone", 1, 56));
            Knapsack.Content.Add(new Item("Axe", 50, 18));
            Knapsack.Content.Add(new Item("Shotgun", 1231, 36));
            Knapsack.Content.Add(new Item("Bike", 200, 112));
            Knapsack.Content.Add(new Item("Car", 5000, 1564));
            Knapsack.Content.Add(new Item("Condom", 1000, 1));
            Knapsack.Content.Add(new Item("Socks", 5, 5));
            Knapsack.Content.Add(new Item("Kittens", 10, 62));
            Knapsack.Content.Add(new Item("Crowbar", 20, 57));
            Knapsack.Content.Add(new Item("Flashlight", 50, 10));
            Knapsack.Content.Add(new Item("Candy", 3, .12));
            Knapsack.Content.Add(new Item("Bazooka", 1654, 598));
            Knapsack.Content.Add(new Item("Rifle", 1234, 74));
            Knapsack.Content.Add(new Item("Pistol", 510, 5.9));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));
            Knapsack.Content.Add(new Item("Bone", 123, 50));
            Knapsack.Content.Add(new Item("Axe", 1000, 50));

            foreach (Item item in Knapsack.Content)
            {
                Console.WriteLine(item.Name + " " + (item.Ratio).ToString());
            }
            Console.Read();
        }
    }
}
