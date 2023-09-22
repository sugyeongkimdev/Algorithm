// 사분면 고르기
// https://www.acmicpc.net/problem/14681

using System;

public class Baekjoon14681
{
    public Baekjoon14681 ()
    {
        int x = int.Parse (Console.ReadLine ());
        int y = int.Parse (Console.ReadLine ());
        int n = x switch
        {
            > 0 when y > 0 => 1,
            < 0 when y > 0 => 2,
            < 0 when y < 0 => 3,
            _ => 4,
        };
        Console.WriteLine (n);
    }
}