Console.WriteLine("Введите номер число");
int numDay = Convert.ToInt32(Console.ReadLine());

bool CheckWeekend(int number)
{
    if (number == 6 | number == 7)
    {
        return true;
    }

    if (number >= 1 & number < 7 /*& number != 6 & number != 7*/)
    {
        return false;
    }

    throw new Exception("Только от 1 до 7");

}

bool result = CheckWeekend(numDay);

if (result == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}