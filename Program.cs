using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A simple calculator program using C Sharp");
            Console.Write("Enter first value: ");
            // Getting first number value
            int firstNumber = int.Parse(Console.ReadLine());
            // Getting second number value
            Console.Write("Enter second value: ");
            int secondNumber = int.Parse(Console.ReadLine());

            // Sum of two values
            int sum = firstNumber + secondNumber;
            // Printing sum
            Console.WriteLine("Sum of " + firstNumber + " and " + secondNumber + " = " + sum);

            // Substraction of two values
            int sub = firstNumber - secondNumber;
            Console.WriteLine("Substraction of " + firstNumber + " and " + secondNumber + " = " + sub);

            // Multiplication of two values
            int mul = firstNumber * secondNumber;
            Console.WriteLine("Multiplication of " + firstNumber + " and " + secondNumber + " = " + mul);

            // Division of two values
            int div = firstNumber / secondNumber;
            Console.WriteLine("Division of " + firstNumber + " and " + secondNumber + " = " + div);

            Console.ReadKey();

        }
    }
}
