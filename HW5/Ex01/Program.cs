Console.WriteLine("Сколько чисел вывести?");
int number = Convert.ToInt32(Console.ReadLine());

int[] FillArray(int number)
{
    int[] arr = new int[number];
    Random random = new Random();

    for (int i = 0; i < number; i++)
    {
        arr[i] = random.Next(100, 1000);
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

int CountEvenArray(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;

}

Console.WriteLine("");
int[] arr = FillArray(number);
PrintArray(arr);
int countEven = CountEvenArray(arr);
Console.WriteLine($" количество чётных чисел - {countEven}");
