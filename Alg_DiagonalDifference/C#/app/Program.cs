// Solution for: https://www.hackerrank.com/challenges/diagonal-difference/problem
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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int length = arr.Count;
        int leftDiagonolPos = 0;
        int rightDiaganolPos = length - 1;
        int leftDiagonolTotal = 0;
        int rightDiaganolTotal = 0;

        for(int row = 0; row < length; row++) {
            List<int> curRow = arr[row];
            leftDiagonolTotal += curRow[leftDiagonolPos];
            rightDiaganolTotal += curRow[rightDiaganolPos];

            leftDiagonolPos++;
            rightDiaganolPos--;
        }

        return Math.Abs(leftDiagonolTotal - rightDiaganolTotal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter(@"C:\Temp\Test.txt", true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

