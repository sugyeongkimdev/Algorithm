// A+B - 8
// https://www.acmicpc.net/problem/11022

using System;

public class Baekjoon11022
{
    public Baekjoon11022 ()
    {
        for (int i = 1, m = int.Parse (Console.ReadLine ()); i <= m; i++)
        {
            string line = Console.ReadLine ();
            int a = line[0] - 48;
            int b = line[2] - 48;
            Console.WriteLine ($"Case #{i}: {a} + {b} = {a + b}");
        }
    }
}