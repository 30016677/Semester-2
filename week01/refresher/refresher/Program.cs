using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Hello\nHamiora Taurima");

            /*2
            int answer = 74 + 36;
            Console.WriteLine(answer);
            */

            /*3 
            int answer = 50 / 3;
            Console.WriteLine(answer);
            */

            /*4 
            Console.WriteLine("input number");
            int num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("input another number");
            int num02 = int.Parse(Console.ReadLine());

            int answer = num01 * num02;

            Console.WriteLine(num01 + " x " + num02 + " = " + answer);
            */

            /*5 
            Console.WriteLine("input number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
            */

            /*6 */
            //Console.WriteLine("input number");
            //double num = double.Parse(Console.ReadLine());

            //Console.WriteLine("Area = " + 3.141 * num * num);
            //Console.WriteLine("Perimeter = " + 2 * 3.141 * num);

            //7

            //int a = 10;
            //int b = 20;
            //int c;

            //Console.WriteLine("A = " + a + " B = " + b);

            //c = a;
            //a = b;
            //b = c;           

            //Console.WriteLine("\nA = " + a + " B = " + b);

            // 8
            //int[] pin = new int[100];
            //Random rand = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    for (int j = 0; j < 7; j++)
            //    {
            //        Console.Write(rand.Next(1000, 9999) + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //10

            Animal[] animals = new Animal[3];

            for (int i = 0; i < 3; i++)
            {
                Animal a1 = new Animal();
                Console.Write("Please enter type: ");
                a1.Type = Console.ReadLine();
                Console.Write("Please enter name: ");
                a1.Name = Console.ReadLine();
                Console.Write("Please enter Age: ");
                a1.Age = int.Parse(Console.ReadLine());
                Console.Write("Please enter ID: ");
                a1.ID = int.Parse(Console.ReadLine());

                Console.WriteLine(a1.Details());

                animals[i] = a1;
            }


            





            //9 
            /*
            Console.WriteLine("**************");
            Console.WriteLine("*****MENU*****");
            Console.WriteLine("**************");

            Console.WriteLine("\nChoose an application to run:");
            Console.WriteLine("\n1. Add two numbers");
            Console.WriteLine("2. Times table");
            Console.WriteLine("3. Multiply two numbers\n");

            int app = int.Parse(Console.ReadLine());

            if (app == 1)
            {
                Console.WriteLine("input number");
                int num01 = int.Parse(Console.ReadLine());
                Console.WriteLine("input another number");
                int num02 = int.Parse(Console.ReadLine());

                Console.WriteLine(AddNumber(num01, num02));
            } else if (app == 2)
            {
                TimesTable();
            } else if (app == 3)
            {
                Multiply();
            }
            */
            Console.ReadLine();
        }
        static int AddNumber(int num01, int num02)
        {
            return num01 + num02;
        }
        static void TimesTable()
        {
            Console.WriteLine("input number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }
        static void Multiply()
        {
            Console.WriteLine("input number");
            int num01 = int.Parse(Console.ReadLine());
            Console.WriteLine("input another number");
            int num02 = int.Parse(Console.ReadLine());

            int answer = num01 * num02;

            Console.WriteLine(num01 + " x " + num02 + " = " + answer);
        }

    }
    class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string Details()
        {
            return $"\nAnimal Details:\n" +
                $"Type: {Type}\n" +
                $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"ID: {ID}\n";
        }
    }
}
