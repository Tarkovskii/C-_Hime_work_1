Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

int CheckPalindrome(string number)
{   
    string numStr = number;

    string resStrFirst = numStr[0].ToString();
    int numFirst = int.Parse(resStrFirst);
    string resStrSec = numStr[1].ToString();
    int numSec = int.Parse(resStrSec);
    string resStrFour = numStr[3].ToString();
    int numFour = int.Parse(resStrFour);
    string resStrFift = numStr[4].ToString();
    int numFift = int.Parse(resStrFift);

    if (numFirst == numFift & numSec == numFour)
    {
        return 1;
    }
    return 0;

}

int result = CheckPalindrome(number);

if (result == 1)
{
    Console.WriteLine($"Число {number} - палиндром.");
}
else
{
    Console.WriteLine($"Число {number} - не палиндром.");
}
