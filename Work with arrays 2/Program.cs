namespace Work_with_arrays_2
{
    class Program
    {
        static void Main()
        {

            //1.  Написати програму, що знаходить другий найбільший елемент масиву.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] array = { 19, 65, 1, 21, 52, 7 };

            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in array)
            {
                if (num > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = num;
                }
                else if (num > secondMax && num != firstMax)
                {
                    secondMax = num;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Другий найбільший елемент: " + secondMax);
            Console.WriteLine();

            {  //2.Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
                int[,] array1 = { { 3,8,0 }, { 10,11, 5 }, { 6,17, 1 } };

                int rows = array1.GetLength(0);
                int cols = array1.GetLength(1);
                int[] tempArray = new int[rows * cols];
                int index = 0;

                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        tempArray[index++] = array1[i, j];
                    }
                }

                
                Array.Sort(tempArray);

                
                index = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array1[i, j] = tempArray[index++];
                    }
                }

                
                Console.WriteLine("Відсортований масив:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(array1[i, j] + " ");
                    }
                    Console.WriteLine();
                }


            }

            { //3.Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
                int[] array2 = { 5, 20, 15, 60, 35 };
                int indexToRemove = 2;

                int[] newArray = new int[array2.Length - 1];

                for (int i = 0, j = 0; i < array2.Length; i++)
                {
                    if (i == indexToRemove)
                        continue;
                    newArray[j++] = array2[i];
                }
                Console.WriteLine();
                Console.WriteLine("Масив після видалення елемента:");
                foreach (int num in newArray)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();


            }
            { //4.Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

     
            
                int[,] array3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                int diagonalSum = 0;
                int rows = array3.GetLength(0);

                for (int i = 0; i < rows; i++)
                {
                    diagonalSum += array3[i, i];
                }
                Console.WriteLine();
                Console.WriteLine("Сума елементів по головній діагоналі: " + diagonalSum);
                Console.WriteLine();
            }
        
        }

    }

}
        
   

