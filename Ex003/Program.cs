Console.Clear();

Console.WriteLine("Введите число");
double numberRand = Convert.ToInt32(Console.ReadLine());

double result = (numberRand % 2);

if (result == 0)
{
    Console.Write("Число ");
    Console.Write(numberRand);
    Console.Write(" - чётное.");
}
else
{
    Console.Write("Число ");
    Console.Write(numberRand);
    Console.Write(" - нечётное.");
}