/**************************************
Karen Rees-Milton
Assignment 1. February 16 2018
A program to calculate bakery costs 
**************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Bakery bakeryOne = new Bakery("Bakery One", 5, 1);
            Bakery bakeryTwo = new Bakery("Bakery Two", 4, 1);

            int numberBaguettes, numberScones, totalCost1, totalCost2, counter = 0;

            while (counter < 3)
            {
                Console.WriteLine("How many baguettes would you like to purchase? ");
                numberBaguettes = ValidateInput();
                if (numberBaguettes == -1)
                    break;
                Console.WriteLine("How many scones would you like to purchase? ");
                numberScones = ValidateInput();
                if (numberBaguettes == -1)
                    break;

                totalCost1 = bakeryOne.CalculateCost(numberBaguettes, numberScones);
                totalCost2 = bakeryTwo.CalculateCost(numberBaguettes, numberScones);

                if (totalCost1 < totalCost2)
                    Console.WriteLine("Bakery One is the better deal");
                else
                    Console.WriteLine("Bakery Two is the better deal");

                Console.WriteLine();

                counter++;
            }

            Console.ReadLine();

        }
        static int ValidateInput()
        {
            int numberBakedGoods;
            try
            {
                numberBakedGoods = Int32.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error: Invalid input - must be an integer " + e);
                numberBakedGoods = -1;
            }
            return numberBakedGoods;
        }
    }
}
/**************************************************
I/O dialog
**************************************************
How many baguettes would you like to purchase?
3
How many scones would you like to purchase?
4
Bakery One      Cost Estimate
3 baguettes:    15
4 scones:       4
Overall total:  19

Bakery Two      Cost Estimate
3 baguettes:    12
4 scones:       4
Overall total:  16

Bakery Two is the better deal

How many baguettes would you like to purchase?
6
How many scones would you like to purchase?
7
Bakery One      Cost Estimate
6 baguettes:    30
7 scones:       7
Overall total:  37

Bakery Two      Cost Estimate
6 baguettes:    24
7 scones:       7
Overall total:  31

Bakery Two is the better deal

How many baguettes would you like to purchase?
77
How many scones would you like to purchase?
88
Bakery One      Cost Estimate
77 baguettes:   385
88 scones:      88
Overall total:  473

Bakery Two      Cost Estimate
77 baguettes:   308
88 scones:      88
Overall total:  396

Bakery Two is the better deal


************************************************
I/O dialog when invalid input
************************************************
How many baguettes would you like to purchase?
two
Error: Invalid input - must be an integer System.FormatException: Input string was not in a correct format.
   at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at assignmentOne.Program.ValidateInput() in C:\Users\Karen\Documents\semester2\COMP60Csharp\assignments\assignmentOne\assignmentOne\Program.cs:line 55

************************************************************
I/O dialog when missing input
************************************************************

How many baguettes would you like to purchase?

Error: Invalid input - must be an integer System.FormatException: Input string was not in a correct format.
   at System.Number.StringToNumber(String str, NumberStyles options, NumberBuffer& number, NumberFormatInfo info, Boolean parseDecimal)
   at System.Number.ParseInt32(String s, NumberStyles style, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at assignmentOne.Program.ValidateInput() in C:\Users\Karen\Documents\semester2\COMP60Csharp\assignments\assignmentOne\assignmentOne\Program.cs:line 55

***************************************/
