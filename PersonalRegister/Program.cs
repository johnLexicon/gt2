using System;
using System.Collections.Generic;
using System.Transactions;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, please enter employee and the salary.");
            Console.ReadLine();

            Company comp = new Company();
            Company comp1 = new Company();
            
                Console.WriteLine("enter new employee");
                String s = Console.ReadLine();
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(comp.add(s, a));
            Console.ReadLine();

        }
    }
}
