Console.WriteLine("Сколько чиcел хотите ввести?");
int num = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < num; i++)
    {
        // Console.WriteLine("Введите число.");
        int value = Convert.ToInt32(Console.ReadLine());

        arr[i] = value;
    }
    return arr;
}
Console.WriteLine("");

int GerCountEvenNum(int[] arr)
{
    int count = 0;

    for (int i = 0; i <arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr = FillArray(num);
int countRes = GerCountEvenNum(arr);
Console.WriteLine("");
PrintArray(arr);
Console.WriteLine($"-> {countRes}");