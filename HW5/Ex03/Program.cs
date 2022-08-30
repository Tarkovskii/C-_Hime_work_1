Console.WriteLine("Сколько чисел вывести?");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

float[] FillArray(int numb)
{
    Random a = new Random();
    Random b = new Random();

    float[] arr = new float[numb];

    for (int i = 0; i < arr.Length; i++)
    {
        int an = a.Next(-10, 100);
        int bn = b.Next(-10, 11);
        float f = an;
        float c = bn;

        if (c == 0)
        {
            arr[i] = 0;
        }
        else
        {
            float res = f / c;
            arr[i] = res;
        }
    }
    return arr;
}


void PrintArray(float[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

float GetMaxValue(float[] arr)
{
    float maxNum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (maxNum < arr[i])
        {
            maxNum = arr[i];
        }

    }
    return maxNum;
}

float GetMinValue(float[] arr)
{
   float minNum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (minNum > arr[i])
        {
            minNum = arr[i];
        }

    }
    return minNum;

}


float[] arr = FillArray(numb);
float max = GetMaxValue(arr);
float min = GetMinValue(arr);
PrintArray(arr);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine($"Разница между большим числом : {max} и меньшим числом : {min} равняется =  {max - min}");