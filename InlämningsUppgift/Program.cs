using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace InlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool open = true;
            List<int> results = new List<int>();

            do
            {
                Console.Title = "AwesomeSauce calculator!";

                Console.WriteLine("Choose an operator: ");
                char operatorOne = char.Parse(Console.ReadLine());

                Console.WriteLine("Choose one more operator: ");
                char operatorTwo = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter first number: ");
                string firstNumber = Console.ReadLine();

                Console.WriteLine("Enter second number: ");
                string secondNumber = Console.ReadLine();

                Console.WriteLine("Enter third number: ");
                string thirdNumber = Console.ReadLine();

                string formula = firstNumber + operatorOne + secondNumber + operatorTwo + thirdNumber;
                DataTable dt = new DataTable();
                var result = dt.Compute(formula, "");
                Console.WriteLine(formula + "=" + result);
                if ((int)result < 100)
                {
                    Console.WriteLine("Less than a hundred");
                }
                else if ((int)result > 100)
                {
                    Console.WriteLine("More than a hundred");
                }
                else
                {
                    Console.WriteLine("Cool, you now have a hundred, clap clap");
                }

                results.Add((int)result);

                Console.WriteLine("Another try? Y or N");
                var cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Y)
                {
                    open = true;
                }
                else if (cki.Key == ConsoleKey.N)
                {
                    open = false;
                }
                Console.WriteLine("");

            } while (open == true);

            int total = 0;

            foreach (var number in results)
            {
                total += number;
            }

            Console.WriteLine("Thank you for playing. The sum of all round is " + total + ". Bye");

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
            return;
        }
    }
}
