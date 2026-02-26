using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Enhanced Division Tool ---");
        
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            // Convert strings to integers
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            // Perform the division
            int result = Divide(number1, number2);
            Console.WriteLine($"\nSUCCESS: {number1} / {number2} = {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\nERROR: Input was not a whole number.");
            LogException(ex);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("\nERROR: You cannot divide by zero. Math says no!");
            LogException(ex);
        }
        catch (OverflowException ex)
        {
            // Triggered if number > 2,147,483,647 or < -2,147,483,648
            Console.WriteLine("\nERROR: That number is too large (or too small) for a 32-bit integer.");
            LogException(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nERROR: An unexpected error occurred.");
            LogException(ex);
        }
        finally
        {
            // This block ALWAYS runs, regardless of whether an error happened.
            // Perfect for cleanup tasks or closing connections.
            Console.WriteLine("\n--- Cleaning up resources... Operation Complete ---");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }

    static void LogException(Exception ex)
    {
        Console.WriteLine($"[LOG] Type: {ex.GetType().Name}");
        Console.WriteLine($"[LOG] Message: {ex.Message}");
    }
}