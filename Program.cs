using System;
using System.Collections;
using System.Collections.Generic;

namespace Apples_and_oranges
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<string> tobuy = new List<string>();
            double total = 0;
            string product;
            tobuy.Add("apple");
            tobuy.Add("orange");
            tobuy.Add("orange");
            tobuy.Add("apple");
            tobuy.Add("apple");
            while (tobuy.Count > 0)
            {
                product = tobuy[tobuy.Count - 1];
                if (product == "apple")
                {
                    total += 0.60;
                }
                else
                {
                    total += 0.25;
                }
                tobuy.RemoveAt(tobuy.Count - 1);
            }
            Console.WriteLine(total);
            Console.ReadKey();


            tobuy.Add("apple");
            tobuy.Add("apple");
            tobuy.Add("apple");
            tobuy.Add("apple");
            tobuy.Add("apple");
            total = 0;
            while (tobuy.Count > 0)
            {
                product = tobuy[tobuy.Count - 1];
                if (product == "apple")
                {
                    total += 0.60;
                }
                else
                {
                    total += 0.25;
                }
                tobuy.RemoveAt(tobuy.Count - 1);
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
