string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool isPlayer1Turn = true;
int numTurns = 0;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть ім'я гравця 1: ");
string name1player = Convert.ToString(Console.ReadLine());

Console.Write("Введіть ім'я гравця 2: ");
string name2player = Convert.ToString(Console.ReadLine());

while (!CheckVictory() && numTurns != 9)
{
    PrintGrid();

    if (isPlayer1Turn)
    {
        Console.WriteLine($"Хід {name1player}!");
    }
    else
    {
        Console.WriteLine($"Хід {name2player}!");
    }
    string choice = Console.ReadLine();
    if (grid.Contains(choice) && choice != "X" && choice != "O") ;
    {
        int gridIndex = Convert.ToInt32(choice) - 1;
        if (isPlayer1Turn)
        { 
            grid[gridIndex] = "X"; 
        }   
        else
        {
            grid[gridIndex] = "O";
        }
        numTurns++;
        
    }
    isPlayer1Turn=!isPlayer1Turn;

}
if (CheckVictory())
{
    Console.WriteLine();
    string winner = isPlayer1Turn ? name2player : name1player;
    Console.WriteLine($"Ти переміг, {winner}!");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Нічия!");
}

bool CheckVictory()
{
    bool row1 = grid[0] == grid[1] && grid[1] == grid[2];
    bool row2 = grid[3] == grid[4] && grid[4] == grid[5];
    bool row3 = grid[6] == grid[7] && grid[7] == grid[8];
    bool col1 = grid[0] == grid[3] && grid[3] == grid[6];
    bool col2 = grid[1] == grid[4] && grid[4] == grid[7];
    bool col3 = grid[2] == grid[5] && grid[5] == grid[8];
    bool diagDown = grid[0] == grid[4] && grid[4] == grid[8];
    bool diagUp = grid[6] == grid[4] && grid[4] == grid[2];

    return row1 || row2 || row3 || col1 || col2 || col3 || diagDown ||diagUp ;   
}

void PrintGrid()
{
    Console.WriteLine("-----------------");
    Console.WriteLine("|Хрестики-нолики |");
    Console.WriteLine("-----------------");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(grid[i * 3 + j] + "   | ");
        }
        Console.WriteLine();
        Console.WriteLine("----|-----|-----|");
    }
}

    

