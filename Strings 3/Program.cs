using System;

class Program
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть рядок зі словами, розділеними комами:");
        string input = Console.ReadLine();

        
        string result = input.Replace(" ", "");

        
        Console.WriteLine("Рядок без пробілів:");
        Console.WriteLine(result);
    }
}
