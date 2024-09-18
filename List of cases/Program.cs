using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ToDoList toDoList = new ToDoList();

        bool running = true;

        while (running)
        {
            // Меню
            Console.WriteLine("\nОберіть дію:");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Вивести всі справи");
            Console.WriteLine("3. Позначити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Вийти з програми");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    toDoList.AddTask();
                    break;
                case "2":
                    toDoList.ShowTasks();
                    break;
                case "3":
                    toDoList.MarkTaskAsDone();
                    break;
                case "4":
                    toDoList.DeleteTask();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Вихід з програми...");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Некоректний вибір, спробуйте ще раз.");
                    break;
            }
        }
    }
}

class ToDoList
{
    private List<string> tasks = new List<string>();

    // Додавання справи
    public void AddTask()
    {
        Console.WriteLine();
        Console.Write("Введіть нову справу: ");
        string task = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(task))
        {
            tasks.Add(task);
            Console.WriteLine();
            Console.WriteLine("Справу додано.");
        }
        else
        {
            Console.WriteLine();

            Console.WriteLine("Справу не можна залишити пустою.");
        }
    }

    // Виведення всіх справ
    public void ShowTasks()
    {
        if (tasks.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("\nВаші справи:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Список справ порожній.");
        }
    }

    // Позначити справу як виконану
    public void MarkTaskAsDone()
    {
        ShowTasks();
        if (tasks.Count > 0)
        {    
            Console.WriteLine();
            Console.Write("Введіть номер справи для позначення як виконаної: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.WriteLine();
                tasks[taskNumber - 1] += " (виконано)";
                Console.WriteLine();
                Console.WriteLine("Справу позначено як виконану.");
            }
            else
            {   Console.WriteLine();

                Console.WriteLine("Некоректний номер справи.");
            }
        }
    }

    // Видалення справи
    public void DeleteTask()
    {
        ShowTasks();
        if (tasks.Count > 0)
        {   Console.WriteLine();
            Console.Write("Введіть номер справи для видалення: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.WriteLine();
                tasks.RemoveAt(taskNumber - 1);
                Console.WriteLine("Справу видалено.");
                Console.WriteLine();
            }
            else
            {   Console.WriteLine();
                Console.WriteLine("Некоректний номер справи.");
                Console.WriteLine();
            }
        }
    }
}

