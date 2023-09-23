// A+B - 5
// https://www.acmicpc.net/problem/10952

using System;

public class Baekjoon10952
{
    public Baekjoon10952 ()
    {
        string line;
        var sb = new System.Text.StringBuilder ();
        while (!string.IsNullOrWhiteSpace (line = Console.ReadLine ()))
        {
            var sum = line[0] + line[2] - 96;
            if (sum != 0)
            {
                sb.AppendLine (sum.ToString ());
            }
        }
        Console.WriteLine (sb.ToString ());
    }
}