Console.WriteLine("Введите число");
int numFir = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести?");
int numSec = Convert.ToInt32(Console.ReadLine());


int[] FillArray(int numFir, int numSec)
{
    int[] arr = new int[3];

    int count = 1;
    int result = 1;

    arr[0] = numFir;
    arr[1] = numSec;
    arr[2] = result;


    while (count <= numSec)
    {
       arr[2] *= numFir;
        count++;
    }

    return arr;
}

void PrintArray(int[] arr)
{
    
        Console.WriteLine($"Число {arr[0]} в степени {arr[1]} = {arr[2]}.");
    

}

Console.WriteLine("");

PrintArray(FillArray(numFir, numSec));