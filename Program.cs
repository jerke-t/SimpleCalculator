using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal number1 = 0;
            decimal number2 = 0;
            decimal result = 0;
            string output;
            Console.WriteLine("Welcome to a simple calculator");
            Console.WriteLine("==============================");
            Console.Write("Give me your first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Give me your second number:");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Which operation do you want to do?");
            Console.WriteLine("Choose between + , - , * and /");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    output = number1.ToString() + " + " + number2.ToString() + " = " + result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                    output = number1.ToString() + " - " + number2.ToString() + " = " + result.ToString();
                    break;
                case "*":
                    result = number1 * number2;
                    output = number1.ToString() + " * " + number2.ToString() + " = " + result.ToString();
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        output = "You can't devide by 0";
                        break;
                    }
                    else
                    {
                        result = number1 / number2;
                        output = number1.ToString() + " / " + number2.ToString() + " = " + result.ToString();
                        break;
                    }
                default:
                    output = operation.ToString() + " is not a valid operation...";
                    break;
            };
            Console.WriteLine(output);
            Console.Write("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}

