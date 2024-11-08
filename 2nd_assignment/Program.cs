using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even numbers");

            for (int v = 1; v <= 50; v++) {
                if (v % 2 == 0)
                {
                    Console.WriteLine(v);
                }
            }

            Console.WriteLine("Odd numbers");

            int i = 1;
            do {
                Console.WriteLine(i);
                i+=2;
            } while (i < 50);

            //using foreach to print out a list of string
            Console.WriteLine("string");
            string[] students = { "david", "stephen", "jake", "eliya" };
            foreach (string names in students) { 
            Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}
