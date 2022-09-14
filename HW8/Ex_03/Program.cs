Console.WriteLine("Введите размерность первой матрицы:");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
bool numberM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите размерность первой матрицы:");
bool numberK = int.TryParse(Console.ReadLine(), out int k);
bool numberJ = int.TryParse(Console.ReadLine(), out int j);

if (numberN == false && numberM == false && numberK == false && numberJ == false)
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
            arr[i, j] = random.Next(1, 11);
        }
    }
    return arr;
}

int[,] Nultiplication(int[,] arrF, int[,] arrS)
{
    if (arrF.GetLength(0) != arrS.GetLength(1))
    {
        throw new Exception("матрицы невозможно перемножить.");
    }

    int[,] arrRes = new int[arrF.GetLength(0), arrS.GetLength(1)];

    for (int i = 0; i < arrF.GetLength(1); i++)
    {
        for (int j = 0; j < arrS.GetLength(0); j++)
        {
            for (int k = 0; k < arrS.GetLength(1); k++)
            {
                arrRes[i, j] = arrF[i, k] * arrS[k, j];
            }
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


int[,] matrixFirst = FillArray(n, m);
int[,] matrixSecond = FillArray(k, j);
Console.WriteLine();
PrintArray(matrixFirst);
Console.WriteLine();
PrintArray(matrixSecond);
Console.WriteLine();
int[,] matrixRes = Nultiplication(matrixFirst, matrixSecond);
PrintArray(matrixRes);
