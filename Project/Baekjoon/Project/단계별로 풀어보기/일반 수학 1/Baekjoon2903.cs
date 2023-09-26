// 중앙 이동 알고리즘
// https://www.acmicpc.net/problem/2903

using System;

public class Baekjoon2903
{
    public Baekjoon2903 ()
    {
        // 0 - 2*2 = 4
        // 1 - 3*3 = 9
        // 2 - 5*5 = 25
        // 3 - 9*9 = 81
        // 4 - 17*17 = 289
        // 5 - 33*33 = 1089
        int c = int.Parse (Console.ReadLine ());
        var p = 1 + Math.Pow (2, c);
        Console.Write (p * p);
    }
}