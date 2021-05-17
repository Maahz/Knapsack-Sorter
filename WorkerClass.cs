using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack_Sorter
{
    class WorkerClass
    {
        public static List<Item> ListSort(List<Item> tempPool)
        {
            //Make sure list isnt empty
            if (tempPool.Count < 1)
            {
                Console.WriteLine("ERROR");
                return tempPool;
            }
            //Variables
            List<Item> result = new List<Item>();
            Item heighest = tempPool[tempPool.Count - 1];
            int itemCount = tempPool.Count;


            //Sort the list
            for (int loops = 0; loops < itemCount - 1; loops++)
            {

                for (int i = 0; i < tempPool.Count; i++)
                {
                    if (tempPool[i].Ratio > heighest.Ratio)
                    {
                        heighest = tempPool[i];
                    }
                    
                }
                //Add highest value to the end of the list and remove it from the original pool
                result.Add(heighest);
                tempPool.Remove(heighest);
                heighest = tempPool[tempPool.Count - 1];
            }

            //Add the last item from the pool to the end of the list
            if (!(tempPool.Count > 1))
            {
                result.Add(tempPool[tempPool.Count - 1]);
                tempPool.Remove(tempPool[tempPool.Count - 1]);
            }
            
            return result;
        }
    }
}
