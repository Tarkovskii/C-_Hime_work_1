Console.Clear();

Console.WriteLine("Введите число.");
double number = Convert.ToInt32(Console.ReadLine());

double numberOne = 1;

if (number == 1)
    {
        Console.Write("Лучше начинать с цифры ");
    }


if (number % 2 == 0)
    {
        while (numberOne <= number - 2 )
        {
            if ( numberOne % 2 == 0)
                {
                    Console.Write($"{numberOne}, ");
                }

            numberOne++;
        }


        if (numberOne % 2 != 0)
            {
                Console.Write($"{numberOne + 1}.");
            }

    }


else
    {
        while (numberOne < number - 2 )
            {
                if ( numberOne % 2 == 0 )
                    {
                        Console.Write($"{numberOne}, ");
                    }

                        numberOne++;
            }

        if (numberOne % 2 != 0 )
            {
                Console.Write($"{numberOne + 1}.");
            }
    }


