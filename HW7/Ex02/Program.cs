bool numN = int.TryParse(Console.ReadLine(), out int n);
bool numM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Какое число ищешь?");
bool numK = int.TryParse(Console.ReadLine(), out int k);

if (numN == false && numM == false && numK == false)
{
    Console.WriteLine("Не те данные");
}

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

bool CheckFoundNaber(int[,] arr, int k)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == k)
            {
                count += 1;
            }
        }
    }
    if (count == 0)
    {
        return false;
    }
    else
    {
        return true;
    }
}

void FonndIndexNumberInArray(int[,] arr, int k)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == k)
            {
                Console.WriteLine($"{k} -> {i},{j}; ");
            }
        }
    }
}

int[,] array = FillArray(n, m);
bool check = CheckFoundNaber(array, k);
Console.WriteLine("");
PrintArray(array);


if (check == true)
{
    Console.WriteLine();
    FonndIndexNumberInArray(array, k);
}
else
{
    Console.WriteLine($"{k} -> Не найден!");
}