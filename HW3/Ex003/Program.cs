Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());

string GetLineNumberEdge(int number)
{
    string rezult = " ";
    for (int i = 1; i <= number; i++)
    {
        rezult += $"{Math.Pow(i, 3)},";

    }
    return rezult;
}

Console.WriteLine(GetLineNumberEdge(number));
