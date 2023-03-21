// Solution for: https://www.hackerrank.com/challenges/append-and-delete/problem
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
     * Complete the 'appendAndDelete' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s - the first/original string
     *  2. STRING t - what s needs to be converted to
     *  3. INTEGER k - how many operations or "moves" it needs to be able to be done in.
     */

    public static string appendAndDelete(string s, string t, int k)
    {

        int stringsMatchUntilPosition = 0;
        int shortStringLength = s.Length < t.Length ? s.Length : t.Length;
        
        for(int i = 0; i < shortStringLength; i++)
        {
            if(s[i] == t[i])
                stringsMatchUntilPosition++;
            else
                break;
        }

        if(k % 2 == 0 && Math.Abs(t.Length - stringsMatchUntilPosition) % 2 != 0)
            return "No";
        
        for(int i = s.Length; i > stringsMatchUntilPosition; i--)
        {
            s = s.Remove(i);
            k--;
        }
        
        for(int i = stringsMatchUntilPosition; i < t.Length; i++)
        {
            s += t[i];
            k--;    
        }           
               
        return k >= 0 ? "Yes" : "No";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        TextWriter textWriter = new StreamWriter(@"C:\Temp\Test.txt", true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
