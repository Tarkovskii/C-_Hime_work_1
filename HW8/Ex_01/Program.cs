bool numberN = int.TryParse(Console.ReadLine(), out int n);
bool numberM = int.TryParse(Console.ReadLine(), out int m);

if (numberN == false && numberM == false)
{
    Console.WriteLine("Не те данные!");
}

int[,] FillArray(int n, int m)
{
    int[,] arr = new int[n, m];

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i, j] = random.Next(1, 100);
        }
    }
    return arr;
}

int[,] ArrRes(int[,] arr)
{
    int[,] arrRes = arr;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int maxPos = j;

            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, maxPos] < arr[i, k])
                {
                    maxPos = k;
                }
            }

            int temp = arr[i, j];
            arr[i, j] = arr[i, maxPos];
            arr[i, maxPos] = temp;

            arrRes = arr;

        }

    }
    return arrRes;
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

int[,] arrayOrig = FillArray(n, m);
PrintArray(arrayOrig);
Console.WriteLine();
int[,] arrayRes = ArrRes(arrayOrig);

PrintArray(arrayRes);