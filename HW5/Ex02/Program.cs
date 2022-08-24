Console.WriteLine("Сколько чисел вывести?");
int count = Convert.ToInt32(Console. ReadLine());

int[] FillArray(int count)
{
    int[] arr = new int[count];

    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-99, 100);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int GetIntSumOddPos(int[] arr)
{
    int sumNum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumNum += arr[i];
        }
    }
    return sumNum;
}
Console.WriteLine("");

int[] arr = FillArray(count);
PrintArray(arr);
int result = GetIntSumOddPos(arr);
Console.WriteLine($" -> {result}");