using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine();
        Console.WriteLine("Введіть ім'я та прізвище користувача:");
        Console.WriteLine();
        string fullName = Console.ReadLine();

        string[] parts = fullName.Split(' ');

        
        if (parts.Length >= 2)
        {
            string firstName = parts[0];  
            string lastName = parts[1];   

            
            if (char.ToUpper(firstName[0]) == char.ToUpper(lastName[0]))
            {
                Console.WriteLine();
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім'я.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім'я.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Введіть, будь ласка, повне ім'я (ім'я та прізвище).");
            Console.WriteLine();
            Main();
        }
    }
}