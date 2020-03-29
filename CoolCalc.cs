using System;

namespace Learn2Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cool Calculations:\nThere are many operations you can do\n+-/*^");

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "^")
            {
                Console.WriteLine(GetPow(num1, num2));
            }
            else
            {
                Console.WriteLine("Invalid operation wrong operator");
            }

            Console.ReadLine();

            static double GetPow(double baseNum, double powNum)
            {
                double result = 1;

                for (double i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
                return result;
            }

        }
    }
}
