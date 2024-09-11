namespace Fibonacci_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

           Console.WriteLine("Введіть порядковий номер числа Фібоначчі:");
           int number = int.Parse(Console.ReadLine());

           int fibonacciNumber = FibonacciCalculator.FibonacciShifted(number);

           Console.WriteLine($"Число Фібоначчі порядку {number}: {fibonacciNumber}");

        }

        
        static class FibonacciCalculator
        {
            
            public static int FibonacciShifted(int n)
            {
                return Fibonacci(n - 1); 
            }

            
            public static int Fibonacci(int n)
            {
                if (n == 0) return 0;        
                if (n == 1) return 1;        
                return Fibonacci(n - 1) + Fibonacci(n - 2);  
            }
        }

    }
}


