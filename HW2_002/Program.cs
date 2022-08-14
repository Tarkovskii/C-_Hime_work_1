Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());


int FoundThrNumber(int a)
{
    string numberStr = $"{number}";
    int numberLen = numberStr.Length;
    
    if (numberLen > 2)
    {
        string resStr = numberStr[2].ToString();
        int numberThr = int.Parse(resStr);
        return numberThr;
    }

    return -1;

}

int result = FoundThrNumber(number);

if (result == -1)
{
    Console.WriteLine($"Число {number} не имеет третью цифру.");
}
else
{
    Console.WriteLine($"Третья цифра числа {number} = {result}.");
}



