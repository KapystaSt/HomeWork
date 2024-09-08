using System;

namespace Gallows
 {
    
   class Program
    {
        static void Main()
        {
            
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            string[] words = { "собака", "кишка", "комп'ютер", "програмування", "машина", "дерево", "місто" };

            
            Random random = new Random();
            string wordToGuess = words[random.Next(words.Length)];

            
            char[] hiddenWord = new char[wordToGuess.Length];
            for (int i = 0; i < hiddenWord.Length; i++) hiddenWord[i] = '_';

            int remainingAttempts = 7;
            bool wordGuessed = false;

            Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
            Console.WriteLine($"Кількість літер у слові: {wordToGuess.Length}");
            Console.WriteLine($"Кількість можливих невірних спроб: {remainingAttempts}");
            Console.WriteLine();


            while (remainingAttempts > 0 && !wordGuessed)
            {
                
                Console.WriteLine("Зашифроване слово: " + new string(hiddenWord));

               
                Console.Write("Введіть літеру: ");
                char guessedLetter = Console.ReadLine().ToLower()[0];

                
                if (wordToGuess.Contains(guessedLetter))
                {
                    Console.WriteLine("Така літера є у слові!");

                    
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedLetter)
                        {
                            hiddenWord[i] = guessedLetter;
                        }
                    }

                   if (new string(hiddenWord) == wordToGuess)
                    {
                        wordGuessed = true;
                    }
                }
                else
                {
                    remainingAttempts--;
                    Console.WriteLine($"Такої літери немає! Залишилось спроб: {remainingAttempts}");
                }
            }

            
            if (wordGuessed)
            {
                Console.WriteLine($"Вітаємо! Ви вгадали слово: {wordToGuess}");
            }
            else
            {
                Console.WriteLine($"Ви програли! Правильне слово: {wordToGuess}");
            }
        }
    }

}
