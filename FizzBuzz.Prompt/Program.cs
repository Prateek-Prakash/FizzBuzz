using System;
using FizzBuzz.Generator;

namespace FizzBuzz.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNum = GetInputNumber();

            FBGenerator fbGenerator = new FBGenerator();
            for (int i = 1; i <= enteredNum; i++)
            {
                Console.WriteLine($"{i}\t::\t{fbGenerator.Generate(i)}");
            }

            Console.ReadKey();
        }

        static int GetInputNumber()
        {
            Console.Write("Enter Value: ");
            string enteredString = Console.ReadLine();
            
            Console.Clear();

            return int.Parse(enteredString);
        }
    }
}