using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int score = 0;
        string bestScore = "";
        bool isSet = false;

        if (myList == null || myList.Count == 0)
            return "None";

        foreach (var item in myList)
        {
            if (!isSet)
            {
                score = item.Value;
                bestScore = item.Key;
                isSet = true;
            }

            if (item.Value > score)
            {
                score = item.Value;
                bestScore = item.Key;
            }
        }

        return bestScore;
    }
}
