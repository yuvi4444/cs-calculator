using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("------------------");

        while (true)
        {
            Console.WriteLine("\nEnter an operator (+, -, *, /) or 'exit' to quit:");
            string op = Console.ReadLine();

            if (op == "exit")
                break;

            Console.WriteLine("Enter the first number:");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.WriteLine("Enter the second number:");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator. Please enter a valid operator.");
                    continue;
            }

            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }

        Console.WriteLine("Calculator closed.");
    }
}
