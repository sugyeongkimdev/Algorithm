// 별 찍기 - 1
// https://www.acmicpc.net/problem/2439

using System;
using System.Linq;

public class Baekjoon2439
{
    public Baekjoon2439 ()
    {
        int n = int.Parse (Console.ReadLine ());
        for (int i = 0; i < n; i++)
        {
            for (int j = n; j > 0; j--)
            {
                Console.Write (i + 1 < j ? " " : "*");
            }
            Console.WriteLine ();
        }
    }
}