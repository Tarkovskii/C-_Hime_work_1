Console.WriteLine("Введите первую точку");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую точку");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью точку");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвёртую точку");
float k2 = Convert.ToInt32(Console.ReadLine());


float GetXlocation(float b1, float k1, float b2, float k2)
{
    float x = ((b1 * (-1)) + b2) / (k1 - k2);

    return x;
}

float GetYlocation(float b2, float k2, float x)
{
    float y = (k2 * x) + b2;

    return y;
}

float x = GetXlocation(b1, k1, b2, k2);
float y = GetYlocation(b2, k2, x);

Console.WriteLine($"x = {x}, y = {y}");
