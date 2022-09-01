Console.WriteLine("Сколько будет строк?");
bool numN = int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine("Сколько будет коллон?");
bool numM = int.TryParse(Console.ReadLine(), out int m);

int[,] FillArray(int n, int m)
{
    int[,] arr = new int[n, m];

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }
}


void GetArithmeticMeanColumn(int[,] arr)
{
    int count = 0;
    double result = 0;
    int column = 0;

    while (count < arr.GetLength(1))
    {

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == column)
                {
                    result += arr[i, j];
                }
            }
        }
        Console.Write($"{result / arr.GetLength(0)}; ");
        column++;
        count++;
        result = 0;
    }
}

int[,] array = FillArray(n, m);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
GetArithmeticMeanColumn(array);
