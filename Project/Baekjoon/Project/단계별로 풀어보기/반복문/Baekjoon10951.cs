// A+B - 4
// https://www.acmicpc.net/problem/10951

using System;

public class Baekjoon10951
{
    public Baekjoon10951 ()
    {
        string line;
        while (!string.IsNullOrWhiteSpace (line = Console.ReadLine ()))
        {
            Console.WriteLine (line[0] + line[2] - 96);
        }
    }
}