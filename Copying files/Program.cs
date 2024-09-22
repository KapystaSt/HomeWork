using System;
using System.IO;

namespace Copying_files
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                
                Console.Write("Введіть шлях до вихідного файлу: ");
                string inputFilePath = Console.ReadLine();

                
                Console.Write("Введіть шлях до файлу, в який потрібно скопіювати дані: ");
                string outputFilePath = Console.ReadLine();

                
                if (File.Exists(inputFilePath))
                {
                   File.Copy(inputFilePath, outputFilePath, overwrite: true);

                   Console.WriteLine("Файл успішно скопійовано!");
                }

                else
                {
                    Console.WriteLine("Вихідний файл не знайдено. Перевірте шлях і спробуйте ще раз.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
    }

}

