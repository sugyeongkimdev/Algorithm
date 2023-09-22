// 곱셈
// https://www.acmicpc.net/problem/2588

using System;

public class Baekjoon2588
{
    public Baekjoon2588 ()
    {
        string strA = Console.ReadLine ();
        string strB = Console.ReadLine ();
        int a = int.Parse (strA);
        int b = int.Parse (strB);
        for (int i = strB.Length - 1; i >= 0; i--)
        {
            Console.WriteLine (a * (Convert.ToInt64 (strB[i]) - 48));
        }
        Console.WriteLine (a * b);
    }
}