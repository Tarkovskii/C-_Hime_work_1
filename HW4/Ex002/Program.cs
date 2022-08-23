Console.WriteLine("Введите число");
string numb = Console.ReadLine();

int[] FillArray(string numb)
{
    string numS = numb[0].ToString();
    int numAr = int.Parse(numS);

    int[] arr = new int[numb.Length];

    for (int i = 0; i < numb.Length; i++)
    {
        numS = numb[i].ToString();
        numAr = int.Parse(numS);
        arr[i] = numAr;
    }
    return arr;
}

void SumArray(int[] arr)
{
    int numStr = 0;
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum = arr[i];

        numStr += sum;

    }

    Console.WriteLine(numStr);
}

SumArray(FillArray(numb));