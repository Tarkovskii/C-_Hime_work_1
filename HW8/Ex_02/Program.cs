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
            arr[i, j] = random.Next(1, 11);
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

int[] MinRow(int[,] arr)
{
    int[] arrSumString = new int[arr.GetLength(0)];

    int sum = 0;
    int str = 0;

    while (str <= arr.GetLength(0) - 1)
    {

        for (int i = str; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (i == str)
                {

                    sum += arr[str, j];

                }
            }
            arrSumString[str] = sum;
        }
        sum = 0;
        str++;
    }

    return arrSumString;
}

int GetNumberStrMinSum(int[] arr)
{  
    int index = 0;
    int minSum = arr[index];
    

    for (int i = 0; i < arr.Length; i++)
    {
        if(minSum > arr[i])
        {
            minSum = arr[i];
            index = i;
        }
    }

    return index+1;
}

int[,] arr = FillArray(n, m);
PrintArray(arr);
Console.WriteLine("");
int[] arrRes = MinRow(arr);
int result = GetNumberStrMinSum(arrRes);
Console.WriteLine(result);
