void ShowSecNumber(int number)
{
int numberFirst = number / 100;
int numberSec = (number - (numberFirst * 100)) / 10;
int numberThr = number % 10;

Console.WriteLine(number);
Console.WriteLine($"Вторая цифра этого числа - {numberSec}");
}

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// int number = random.Next(100, 1000);

ShowSecNumber(number);
