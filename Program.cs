using CalculatorApp;

Calculator calculator = new Calculator();

while (true)
{
    Console.WriteLine("Welcome to the Calculator APP.");
    try
    {

        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");

        int operation = Convert.ToInt32(Console.ReadLine());



        switch (operation)
        {
            case 1:
                Console.WriteLine("Result: " + calculator.Add(num1, num2));
                break;
            case 2:
                Console.WriteLine("Result: " + calculator.Subtract(num1, num2));
                break;
            case 3:
                Console.WriteLine("Result: " + calculator.Multiply(num1, num2));
                break;
            case 4:
                Console.WriteLine("Result: " + calculator.Divide(num1, num2));
                break;
            case 5:
                Console.WriteLine("\n\n\t\tThanks for using the Calculator APP.");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid operation. Please try again.");
                break;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine("Error: " + e.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("\t\t\tHave fun calculating!!!");
    }

    Console.Write("Do you want to perform another calculation? (y/n)");
    if (Console.ReadKey().Key != ConsoleKey.Y)
    {
        Console.WriteLine("\n\n\t\tThanks for using the Calculator APP.");
        break;
    }

}
namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return num1 / num2;
        }
    }

}