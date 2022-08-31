Console.WriteLine("Введите первый параметр первой функции.");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второй параметр первой функции.");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первый параметр второй функции.");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второй параметр второй функции.");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1==k2)
{
    Console.WriteLine("Графики параллельны");
}

double GetXlocation(double b1, double k1, double b2, double k2)
{
    double x = ((b1*(-1)) + b2) / (k1 - k2);

    return x;
}

double GetYlocation(double b2, double k2, double x)
{
   double y = (k2 * x) + b2;

    return y;
}

double x = GetXlocation(b1, k1, b2, k2);
double y = GetYlocation(b2, k2, x);

Console.WriteLine($"x = {x}, y = {y}");
