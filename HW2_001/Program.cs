﻿
Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int ShowThrNumber(int number)
{
    int numberFirst = number / 100;
    int numberSec = (number - (numberFirst * 100)) / 10;
    int numberThr = number % 10;
    return numberSec;
}
int number2 = ShowThrNumber(number);
Console.WriteLine(number2);
