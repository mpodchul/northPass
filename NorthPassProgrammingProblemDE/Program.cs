using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthPassProgrammingProblemDE
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Gitfcard value: ");
            int gitftCardValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of items");
            int itemCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter space separated items values list:");
            string items = Console.ReadLine();
            Console.WriteLine(findItems(gitftCardValue, itemCount, items));
        }

        public static string findItems(int giftCardValue, int itemCount, string items)
        {
            StringBuilder result = new StringBuilder("Items:");
            var itemsList = items.Split(" ").Select(int.Parse).ToList();

            for (int i = 0; i < itemsList.Count; i++)
            {
                int match = giftCardValue - itemsList.ElementAt(i);
                for(int j = i+1; j < itemsList.Count; j++)
                {
                    if (itemsList.ElementAt(j) == match)
                    {
                        result.Append(" " + (i+1) + " " + (j+1));
                        return result.ToString();
                    }
                }
            }
            return String.Format("Solution not for Giftcard of value: {0}, and items list: {1}", giftCardValue, items);
        }
    }
}

