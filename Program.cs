using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            List<int> numbers = new List<int>();
            List<int> squared = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                numbers.Add(random.Next(51));
            }
            foreach (var number in numbers)
            {
                squared.Add(number^2);
            }
            squared.RemoveAll(i => i%2 != 0);
            foreach (var number in squared)
            {
                Console.WriteLine(number);
            }
        }
    }
}
