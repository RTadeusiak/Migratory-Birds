using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        int maxFreq = 0;
        int mostFrequent = 0;

        foreach (int type in arr)
        {
            if (freqMap.ContainsKey(type))
            {
                freqMap[type]++;
            }
            else
            {
                freqMap[type] = 1;
            }

            if (freqMap[type] > maxFreq)
            {
                maxFreq = freqMap[type];
                mostFrequent = type;
            }
            else if (freqMap[type] == maxFreq && type < mostFrequent)
            {
                mostFrequent = type;
            }
        }

        return mostFrequent;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.WriteLine(result);
    }
}
