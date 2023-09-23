// A+B - 7
// https://www.acmicpc.net/problem/11021

using System;

public class Baekjoon11021
{
    public Baekjoon11021 ()
    {
        for (int i = 1, m = int.Parse (Console.ReadLine ()); i <= m; i++)
        {
            string line = Console.ReadLine ();
            Console.WriteLine ($"Case #{i}: {line[0] + line[2] - 96}");
        }
    }
}