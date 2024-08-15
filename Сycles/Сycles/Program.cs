//!!!Важливо!!!Вікна задач на ячейці (1,38,74,112,148,184,222),орієнтуйся по ним ,вікно буде акцент тримати на одній задачі, і думаю так буде простіше її проаналізувати, наприклад як осьо перша задача
//1. Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
//Після отримання всіх значень програма має обчислити та вивести середній заробіток.



Console.WriteLine("exercise №1");
Console.WriteLine();
Console.Write("Enter the number of employees: ");
int numberOfEmployees = int.Parse(Console.ReadLine());

Console.WriteLine();

double totalSalary = 0;

for (int i = 1; i <= numberOfEmployees; i++)
{
    Console.Write($"Enter the employee's salary {i}: ");
    double salary = double.Parse(Console.ReadLine());
    totalSalary += salary;
}

double averageSalary = totalSalary / numberOfEmployees;

Console.WriteLine();

Console.WriteLine($"Average earnings: {averageSalary}");










//2.Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
//Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.

Console.WriteLine();
Console.WriteLine("exercise №2");
Console.WriteLine();

Console.Write("Enter the number of graph lines: ");
int numberOfRows = int.Parse(Console.ReadLine());


for (int i = 1; i <= numberOfRows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine(); 
}

















//3.Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа.
//Просте число - це число, яке ділиться лише на 1 і на себе.
Console.WriteLine();
Console.WriteLine("exercise №3");
Console.WriteLine();
Console.Write("Enter a number: ");
int limit = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Simple numbers from 1 to " + limit + ":");

for (int i = 2; i <= limit; i++)
{
    if (IsSimple(i))
    {
        Console.Write(i + " ");
    }
}
    static bool IsSimple(int number)
{
    if (number < 2)
    {
        return false;
    }
    for (int i = 2; i < Math.Sqrt(number); i++) 
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine();




//4.Сказали пропускати 
//5.Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі.
//Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.




Console.WriteLine("exercise №5");
Console.WriteLine();

Console.Write("Enter the number of Fibonacci numbers: ");
int N = int.Parse(Console.ReadLine());

int firstNumber = 0, secondNumber = 1, nextNumber;

Console.WriteLine("The first {0} Fibonacci numbers:", N);
if (N >= 1) Console.Write(firstNumber + " ");
if (N >= 2) Console.Write(secondNumber + " ");

for (int i = 3; i <= N; i++)
{
    nextNumber = firstNumber + secondNumber;
    Console.Write(nextNumber + " ");
    firstNumber = secondNumber;
    secondNumber = nextNumber;
}

Console.WriteLine();









//6.Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки.
//Після введення значень програма має обчислити та вивести оплату за день.





Console.WriteLine("exercise №6");
Console.WriteLine();

Console.Write("Enter the number of hours worked per day: ");
double hoursWorked = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Enter the hourly rate: ");
double hourlyRate = double.Parse(Console.ReadLine());

Console.WriteLine();

double dailyPay = hoursWorked * hourlyRate;
Console.WriteLine("The payment per day is: " + dailyPay + " UAH");

Console.WriteLine();












//7.Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.



Console.WriteLine();
Console.WriteLine("exercise №7");
Console.WriteLine();
Console.Write("Enter a number to generate the multiplication table: ");
int numeral = int.Parse(Console.ReadLine());

Console.WriteLine("Multiplication table for a number " + numeral + ":");

for (int i = 1; i <= 10; i++)
{
    int result = numeral * i;
    Console.WriteLine($"{numeral} * {i} = {result}");
}





















//8.Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.
Console.WriteLine();
Console.WriteLine("exercise №8");

Console.WriteLine();
Console.Write("Enter a number: ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine();
if (IsPrime(number))
{
    Console.WriteLine($"{number} is a prime number.");
}
else
{
    Console.WriteLine($"{number} is not a prime number.");
}
static bool IsPrime(int number)
{
    if (number <= 1)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}