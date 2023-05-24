using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Enter two numbers:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Prompt user for operation
            Console.WriteLine("Enter an operation (Add, Sub, Mul, Div):");
            string operation = Console.ReadLine();

            // Define lambda operators
            Func<double, double, double> Add = (a, b) => a + b;
            Func<double, double, double> Sub = (a, b) => a - b;
            Func<double, double, double> Mul = (a, b) => a * b;
            Func<double, double, double> Div = (a, b) => b == 0 ? throw new DivideByZeroException("Cannot divide by zero") : a / b;

            // Perform operation based on user input
            double result = 0;
            switch (operation)
            {
                case "Add":
                    result = Add(num1, num2);
                    break;
                case "Sub":
                    result = Sub(num1, num2);
                    break;
                case "Mul":
                    result = Mul(num1, num2);
                    break;
                case "Div":
                    try
                    {
                        result = Div(num1, num2);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            // Print result
            Console.WriteLine($"Result: {result}");
        }
    }
}