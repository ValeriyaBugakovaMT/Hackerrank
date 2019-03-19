using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string a = s.Substring(0, 2);
        string b = Convert.ToInt32(a) < 12 ? (Convert.ToInt32(a) + 12).ToString() : a;
        string rac = s.StartsWith("0") ? s.Substring(0, 2) : (Convert.ToInt32(a) - 12).ToString();
        string c = rac.Length > 1 ? rac : "0" + rac;
        s = s.Substring(8, 2) == "PM" ? s.Replace(a, b).Remove(8) : s.Replace(a, c).Remove(8);
        return s;
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
