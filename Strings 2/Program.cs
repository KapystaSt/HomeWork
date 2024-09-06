using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        StringBuilder report = new StringBuilder();

        
        report.AppendLine("Текстовий звіт");
        report.AppendLine($"Дата: {DateTime.Now.ToShortDateString()}");
        report.AppendLine("Події:");


        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Введіть подію (або 'зупинити' для завершення):");
            
            string input = Console.ReadLine();

            
            if (input.ToLower() == "зупинити")
                break;

            
            report.AppendLine($"- {input}");
        }

        
        Console.WriteLine("\nГотовий звіт:");
        Console.WriteLine();
        Console.WriteLine(report);
    }
}

