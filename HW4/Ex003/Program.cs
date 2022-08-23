int[] array = new int[8];

int[] FilArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 100);
    }
    return arr;
}

string PrintArray(int[] arr)
{
    string result = " ";

    for (int i = 0; i < arr.Length; i++)
    {
        result += $"{arr[i]},";
    }
    return result;
}

string strLine = PrintArray(FilArray(array));
Console.WriteLine(strLine);