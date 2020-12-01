using System;

class Character
{
    public static bool IsLower(char c)
    {
        bool r = false;
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (c == i)
                r = true;
        }

        return (r);
    }
}
