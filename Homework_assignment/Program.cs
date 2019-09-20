using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float pikkus;
            int kaal;
            float kehaMass;
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, {0}", name);
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            if (age < 20)
            {
                Console.WriteLine("You are too young for that calculations.");
                Console.ReadLine();
            }
            else if (age > 65)
            {
                Console.WriteLine("You are too old for that calculations.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("How tall are you in meters?");
                pikkus = float.Parse(Console.ReadLine());
                Console.WriteLine("What is your weight (kg)?");
                kaal = int.Parse(Console.ReadLine());
                kehaMass = (float)(Math.Round((double)(kaal / (pikkus * pikkus)), 2));

                if (kehaMass < 16) 
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is ohtlik sinu alakaal.");                    
                }
                else if (kehaMass >= 16 && kehaMass <= 18.5)
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is alakaal.");
                }
                else if (kehaMass >= 18.6 && kehaMass <= 25)
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is normaalkaal.");
                }
                else if (kehaMass >= 25.1 && kehaMass <= 30)
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is ülekaal.");
                }
                else if (kehaMass >= 30.1 && kehaMass <= 35)
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is rasvumine.");
                }
                else if (kehaMass >= 35.1 && kehaMass <= 40)
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is tugev rasvumine.");
                }
                else 
                {
                    Console.WriteLine($"{name}, your kehamassiindeks is {kehaMass}. It is tervisele ohtlik rasvumine.");
                }
                Console.ReadLine();
            }
        }
    }
}
