// 알고리즘 수업 - 점근적 표기 1
// https://www.acmicpc.net/problem/24313

using System;

public class Baekjoon24313
{
    public Baekjoon24313 ()
    {
        var arr = Console.ReadLine ().Split ();
        long a1 = int.Parse (arr[0]);
        long a0 = int.Parse (arr[1]);
        long c = int.Parse (Console.ReadLine ());
        long n0 = int.Parse (Console.ReadLine ());

        if (a1 <= c)
        {
            Console.WriteLine (F (n0) <= c * n0 ? 1 : 0);
        }
        else
        {
            Console.WriteLine (0);
        }

        long F (long n)
        {
            return a1 * n + a0;
        }
    }
}