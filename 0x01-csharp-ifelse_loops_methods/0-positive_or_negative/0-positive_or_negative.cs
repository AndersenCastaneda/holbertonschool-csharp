using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        Console.WriteLine((number > 0) ? $"{number} is positive" :
            (number == 0) ? $"{number} is zero" : $"{number} is negative");
    }
}
