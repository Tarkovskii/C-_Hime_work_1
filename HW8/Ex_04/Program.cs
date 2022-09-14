bool numberN = int.TryParse(Console.ReadLine(), out int n);
bool numberM = int.TryParse(Console.ReadLine(), out int m);
bool numberK = int.TryParse(Console.ReadLine(), out int k);


if (numberN == false && numberM == false && numberK == false)
{
    Console.WriteLine("Не те данные!");
}

int[,,] FillArray3d(int n, int m, int k)
{
    int[,,] array = new int[n, m, k];

    Random random = new Random();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i, j, l] = random.Next(10, 100);
            }
        }
    }
    return array;
}

int[,,] CheckAndChangeDoubleValue(int[,,] arr)
{
    int[,,] resArr = arr;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                for (int n = 0; n < arr.GetLength(0); n++)
                {
                    for (int m = 0; m < arr.GetLength(1); m++)
                    {
                        for (int k = 0; k < arr.GetLength(2); k++)
                        {
                            if (arr[i, j, l] == arr[n, m, k])
                            {
                                arr[n, m, k] += 13;
                            }
                            if (i == n && j == m && l == k)
                            {
                                arr[n, m, k] -= 13;
                            }
                        }
                    }
                }

                resArr[i, j, l] = arr[i, j, l];
            }

        }

    }
    return resArr;
}

void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                Console.Write($"{arr[i, j, l]}({i},{j},{l}) ");
            }
            Console.WriteLine();
        }
    }

}

Console.WriteLine();
int[,,] arr3D = FillArray3d(n, m, k);
PrintArray3D(arr3D);
Console.WriteLine();
int[,,] res = CheckAndChangeDoubleValue(arr3D);
PrintArray3D(arr3D);
