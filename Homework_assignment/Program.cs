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

            if (age < 20 || age > 65)
            {
                Console.WriteLine("You are to young or old for that calculations");
                Console.ReadLine();
            }

            else

            {
                Console.WriteLine("How tall are you in meters?");
                pikkus = float.Parse(Console.ReadLine());

                Console.WriteLine("What is your weight (kg)?");
                kaal = int.Parse(Console.ReadLine());
                kehaMass = kaal / (pikkus * pikkus);

                if (kehaMass < 16) 
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is ohtlik sinu alakaal", name, kehaMass);
                }

                else if (kehaMass >= 16 && kehaMass <= 18.5)

                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is alakaal", name, kehaMass);
                }

                else if (kehaMass >= 18.6 && kehaMass <= 25)
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is normaalkaal", name, kehaMass);
                }

                else if (kehaMass >= 25.1 && kehaMass <= 30)
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is ülekaal", name, kehaMass);
                }

                else if (kehaMass >= 30.1 && kehaMass <= 35)
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is rasvumine", name, kehaMass);
                }
                else if (kehaMass >= 35.1 && kehaMass <= 40)
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is tugev rasvumine", name, kehaMass);
                }
                else 
                {
                    Console.WriteLine("{0}, your kehamassiindeks is {1}. It is tervisele ohtlik rasvumine", name, kehaMass);
                }

                
                Console.ReadLine();

            }
        }
    }
}
