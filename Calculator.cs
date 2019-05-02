using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1,num2;
            Console.WriteLine("Hello! This is simple console calculator");
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a - Add");
            Console.WriteLine("s - Subtract");
            Console.WriteLine("m - Multiply");
            Console.WriteLine("d - Divide");
            Console.WriteLine("p - Power");

           Console.WriteLine("Choose what you want to do:");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 == 0)
                    { 
                        Console.WriteLine("Error..You can't divide by 0! Enter another number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        break;
                case "p":
                    double num3 = num1;

                        for (double i = num2; i > 0; i--)
                        {
                            if (i == 1)
                            {
                                Console.WriteLine($"Your result: {num1} ^ {num2} = " + num1);
                            }

                            num1 =num1 * num3;
                        }


                    break;
            }
            Console.ReadLine();
        }
    }

}
