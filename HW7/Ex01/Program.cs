bool numN = int.TryParse(Console.ReadLine(), out int n);
bool numM = int.TryParse(Console.ReadLine(), out int m);

if (numN == false || numM == false)
{
    Console.WriteLine("Не те данные!");
}

double[,] FillArray(int n, int m)
{
   double[,] arr = new double[n, m];

    Random a = new Random();
    Random b = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int an = a.Next(-1, 10);
            int bn = b.Next(1, 10);
            float aN = an;
            float bN = bn;
            float res = aN / bN;
            float resN =res;

            arr[i,j] = Math.Round(resN,2);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
    }
}

double[,] array = FillArray(n,m);
Console.WriteLine("");
PrintArray(array);
