using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> myMulDict = new Dictionary<string, int>();
        if (myDict == null || myDict.Count == 0)
            return myMulDict;

        foreach (var key in myDict.Keys)
            myMulDict[key] = myDict[key] * 2;

        return myMulDict;
    }
}
