using System;
using System.Collections.Generic;

namespace List_of_cases
{
    
class ToDoListApp
        {
            
            static List<string> toDoList = new List<string>();

            static void Main()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                bool running = true;

                
                while (running)
                {
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
                            AddTask();
                            break;
                        case "2":
                            ShowTasks();
                            break;
                        case "3":
                            MarkTaskCompleted();
                            break;
                        case "4":
                            DeleteTask();
                            break;
                        case "5":
                            running = false;
                            Console.WriteLine("Вихід з програми...");
                            break;
                        default:
                            Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                            break;
                    }
                }
            }

            
            static void AddTask()
            {
                Console.Write("Введіть назву нової справи: ");
                string task = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(task))
                {
                    toDoList.Add(task);
                    Console.WriteLine("Справу додано.");
                }
                else
                {
                    Console.WriteLine("Справу не можна залишити пустою.");
                }
            }

            
            static void ShowTasks()
            {
                if (toDoList.Count > 0)
                {
                    Console.WriteLine("\nВаші справи:");
                    for (int i = 0; i < toDoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {toDoList[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Список справ порожній.");
                }
            }

            
            static void MarkTaskCompleted()
            {
                if (toDoList.Count > 0)
                {
                    ShowTasks();
                    Console.Write("Введіть номер справи, яку хочете позначити як виконану: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= toDoList.Count)
                    {
                        Console.WriteLine($"Справу \"{toDoList[taskNumber - 1]}\" позначено як виконану.");
                        toDoList[taskNumber - 1] += " (виконано)";
                    }
                    else
                    {
                        Console.WriteLine("Некоректний номер справи.");
                    }
                }
                else
                {
                    Console.WriteLine("Список справ порожній.");
                }
            }

            
            static void DeleteTask()
            {
                if (toDoList.Count > 0)
                {
                    ShowTasks();
                    Console.Write("Введіть номер справи, яку хочете видалити: ");
                    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= toDoList.Count)
                    {
                        Console.WriteLine($"Справу \"{toDoList[taskNumber - 1]}\" видалено.");
                        toDoList.RemoveAt(taskNumber - 1);
                    }
                    else
                    {
                        Console.WriteLine("Некоректний номер справи.");
                    }
                }
                else
                {
                    Console.WriteLine("Список справ порожній.");
                }
            }
        }

    }
