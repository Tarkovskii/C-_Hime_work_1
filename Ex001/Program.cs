Console.Clear();

Console.WriteLine("Введите первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberSec = Convert.ToInt32(Console.ReadLine());


if (numberOne > numberSec)
{
    Console.Write("Большее число = ");
    Console.WriteLine(numberOne);

}
if (numberOne < numberSec)
{
     Console.Write("Большее число = ");
     Console.WriteLine(numberSec);
}
else
{
    Console.Write("Числа равны.");
}
