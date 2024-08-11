Console.WriteLine("Enter first number");
double FirstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter action you want to perform");
char action = char.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
double SecondNum = double.Parse(Console.ReadLine());

double result = 0;
try
{
    switch (action)
    {
        case '+':
            result = FirstNum + SecondNum;
            break;
        case '-':
            result = FirstNum - SecondNum;
            break;
        case '*':
            result = FirstNum * SecondNum;
            break;
        case '/':
            if (SecondNum == 0)
            {
                throw new DivideByZeroException();
            }
            result = FirstNum / SecondNum;
            break;
        default:
            Console.WriteLine("Invalid action.");
            return;
    }

    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException)
{
    Console.WriteLine(" Division by zero is not allowed!");
}
catch (FormatException)
{
    Console.WriteLine(" Invalid input format!");
}
catch (Exception )
{
    Console.WriteLine($"General exception caught! ");
}