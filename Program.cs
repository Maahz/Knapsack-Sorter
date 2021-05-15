using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Knapsack_Sorter
{
    public class Knapsack
    {
        public int Size;
    }
    
    public class Item
    {
        public string Name;
        public int Value;
        public int Weight;
        public double Ratio ;
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Knapsack shitHole = new Knapsack();
            shitHole.Size = 20;
        }
    }
}
