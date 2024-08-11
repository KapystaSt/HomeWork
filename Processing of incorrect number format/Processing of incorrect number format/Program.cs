Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

try
{
    double number = Convert.ToDouble(input);
    Console.WriteLine($"You entered the number: {number}");
}
catch
{
  
    Console.WriteLine("Invalid number format. Please enter a valid number.");
}
finally
{
   
    Console.WriteLine("Operation completed.");
}