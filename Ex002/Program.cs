Console.Clear();

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberThir = Convert.ToInt32(Console.ReadLine());

int max = numberOne;

if (max < numberSec)
{
    max = numberSec;
}
if (max < numberThir)
{
    max = numberThir;
}


Console.Write("Большее число из трёх = ");
Console.WriteLine(max);

