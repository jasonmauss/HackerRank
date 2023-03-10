// Solution for: https://www.hackerrank.com/challenges/mini-max-sum/problem
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

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long minValue = long.MaxValue;
        long maxValue = long.MinValue;
        long completeSum = 0;

        foreach(int i in arr) {
            minValue = Math.Min(minValue, Convert.ToInt64(i));
            maxValue = Math.Max(maxValue, Convert.ToInt64(i));
            completeSum += i;
        }

        Int64 minSum = completeSum - maxValue;
        Int64 maxSum = completeSum - minValue;

        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}

