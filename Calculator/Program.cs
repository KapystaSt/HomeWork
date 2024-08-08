Console.WriteLine("Enter first number");
double FirstNum = double.Parse(Console.ReadLine());

Console.WriteLine("Enter action you want to perform");
char action = char.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
double SecondNum = double.Parse(Console.ReadLine());

double result = 0;

switch (action)
{
    case '+':
        result = FirstNum + SecondNum;
    break;

    case '-':
        result = FirstNum - SecondNum;
    break;

    case '*':   
        result = FirstNum * SecondNum;
    break;

    case '/':

        if (SecondNum == 0)

        {
            Console.WriteLine("You can not divide by 0!");
            return;
        }

        result = FirstNum / SecondNum;

    break;

    default:
        
        Console.WriteLine("You entered incorrect action!");
        return;
    break;
}


    Console.WriteLine($"{FirstNum} {action} {SecondNum} = {result}");
