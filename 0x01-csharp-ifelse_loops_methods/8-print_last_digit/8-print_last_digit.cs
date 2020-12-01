using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastDigit;

        if (number < 0)
            lastDigit = (number % 10) * -1;
        else
            lastDigit = number % 10;

        Console.Write($"{lastDigit}");
        return lastDigit;
    }
}
