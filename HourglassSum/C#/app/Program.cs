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
    private readonly int ROW_COUNT = 6;
    private readonly int COLUMN_COUNT = 6;

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



