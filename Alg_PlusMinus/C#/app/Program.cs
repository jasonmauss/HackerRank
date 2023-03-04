// Solution for: https://www.hackerrank.com/challenges/plus-minus/problem
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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal positiveRatio = 0.0M;
        decimal negativeRatio = 0.0M;
        decimal zeroRatio = 0.0M;

        positiveRatio = Convert.ToDecimal(arr.Count(x => x > 0)) / Convert.ToDecimal(arr.Count);
        negativeRatio = Convert.ToDecimal(arr.Count(x => x < 0)) / Convert.ToDecimal(arr.Count);
        zeroRatio = Convert.ToDecimal(arr.Count(x => x == 0)) / Convert.ToDecimal(arr.Count);

        Console.WriteLine(positiveRatio.ToString("N6"));
        Console.WriteLine(negativeRatio.ToString("N6"));
        Console.WriteLine(zeroRatio.ToString("N6"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

