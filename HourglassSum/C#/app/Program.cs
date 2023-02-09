// Solution for: https://www.hackerrank.com/challenges/2d-array/problem

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
    // These values should always be the same
    // since they represent a non-jagged 2D array
    // but we'll store them separately for clarity
    // around what we're doing
    private static readonly int ROW_COUNT = 6;
    private static readonly int COLUMN_COUNT = 6;

    /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int hourglassSum(List<List<int>> arr)
    {
        // start in the "middle" of the first hourglass, which
        // can be determined by the values for the ROW_COUNT
        // and COLUMN_COUNT values in this class. This way the code
        // is dynamic and can work for any number of rows or columns
        // The number of hourglasses possible is going to be the number
        // of rows and columns - 2, squared. So a 6 x 6 array...
        // (6 - 2) ^ 2 = 16
        // (7 - 2) ^ 2 = 25
        var maximumHourglassSum = int.MinValue; // initialize to MinValue since we're using Math.Max below and need to account for a max value that's a negative number

        for(int hourglassRow = 1; hourglassRow < ROW_COUNT - 1; hourglassRow++) {
            List<int> rowOfHourglass = arr[hourglassRow];
            List<int> previousRow = arr[hourglassRow - 1];
            List<int> nextRow = arr[hourglassRow + 1];

            for(int hourglassCenterPosition = 1; hourglassCenterPosition < COLUMN_COUNT - 1; hourglassCenterPosition++) {
                int currentHourglassSum = rowOfHourglass[hourglassCenterPosition] +
                previousRow[hourglassCenterPosition] + previousRow[hourglassCenterPosition - 1] + previousRow[hourglassCenterPosition + 1] +
                nextRow[hourglassCenterPosition] + nextRow[hourglassCenterPosition - 1] + nextRow[hourglassCenterPosition + 1];
                maximumHourglassSum = Math.Max(currentHourglassSum, maximumHourglassSum);
            }
        }

        return maximumHourglassSum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter(@"C:\Temp\Test.txt", true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}



