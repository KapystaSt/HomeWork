using System.Xml.Linq;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//1.Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, використовуючи клас Random.
//Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
Console.WriteLine("Завдання №1");

Console.WriteLine();


int[] number = new int[10];

Random rndm = new Random();

for (int i = 0; i < number.Length; i++)
{
    number[i] = rndm.Next(-10,11);
}

Console.WriteLine("Елементи масиву з парним індексом:");
Console.WriteLine();

for (int i = 0; i < number.Length; i += 2)
{
    Console.WriteLine($"number[{i}] = {number[i]}");
}
//2.Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
Console.WriteLine();
Console.WriteLine("Завдання №2");
Console.WriteLine();

int sum = 0;
for (int i = 0;i < number.Length;i++)
{
    sum += number[i]; 
}

if (sum >= 0)
{
    Console.WriteLine("Сума елементів масиву є невід'ємним числом.");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Сума елементів масиву є від'ємним числом.");
    Console.WriteLine();
}

//3.Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення (у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1,
//у другому – на 2,...,в останньому – на 9).Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
Console.WriteLine("Завдання №3");
Console.WriteLine();

int[,] multiplicationTable = new int[9, 9];

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}

Console.WriteLine("Таблиця множення 9x9:");
Console.WriteLine();
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(multiplicationTable[i, j] + "\t" );
    }
    Console.WriteLine();
}

//4.Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран: 
//а) максимальний елемент масиву; 
//б) мінімальний елемент масиву; 
//в) координати мінімального елемента масиву. г) координати максимального елемента масиву.
Console.WriteLine();
Console.WriteLine("Завдання №4");

int[,] element = new int[5,5];

Random random = new Random();

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        element[i, j] = random.Next(-7,21);
    }
}
Console.WriteLine();
Console.WriteLine("Масив:");
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(element[i, j] + "\t");
    }
    Console.WriteLine();
}


int max = element[0, 0];
int min = element[0, 0];
int maxRow = 0, maxrod = 0;
int minRow = 0, minrod = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (element[i, j] > max)
        {
            max = element[i, j];
            maxRow = i;
            maxrod = j;
        }

        if (element[i, j] < min)
        {
            min = element[i, j];
            minRow = i;
            minrod = j;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальний елемент: {max} (Координати: {maxRow}, {maxrod})");
Console.WriteLine();
Console.WriteLine($"Мінімальний елемент: {min} (Координати: {minRow}, {minrod})");
Console.WriteLine();