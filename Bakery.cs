/******************************
Karen Rees-Milton
Assignment 1. February 16 2018
Bakery Class 
*******************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOne
{
    class Bakery
    {
        public string bakeryName;
        public int baguetteCost, sconeCost;

        public Bakery(string initialBakery, int initialBaguetteCost, int initialSconeCost)
        {
            bakeryName = initialBakery;
            baguetteCost = initialBaguetteCost;
            sconeCost = initialSconeCost;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberBaguettes"></param>
        /// <param name="numberScones"></param>
        /// <returns></returns>
        public int CalculateCost(int numberBaguettes, int numberScones)
        {
            int totalCost, totalBaguetteCost, totalSconeCost;
            totalBaguetteCost = numberBaguettes * baguetteCost;
            totalSconeCost = numberScones * sconeCost;
            totalCost = totalBaguetteCost + totalSconeCost;

            Console.WriteLine(bakeryName + "\tCost Estimate");
            Console.WriteLine(numberBaguettes + " baguettes:\t" + totalBaguetteCost);
            Console.WriteLine(numberScones + " scones:\t" + totalSconeCost);
            Console.WriteLine("Overall total:\t" + totalCost);
            Console.WriteLine();

            return totalCost;
        }
    }
}
