using System;

class Program
{
    static void Main(string[] args)
    {
        char letter = 'a';

        while (letter <= 'z')
        {
            if (letter != 'q' && letter != 'e')
                Console.Write($"{letter}");

            letter++;
        }
    }
}
