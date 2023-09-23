// 별 찍기 - 2
// https://www.acmicpc.net/problem/2438

using System;
using System.Linq;

public class Baekjoon2438
{
    public Baekjoon2438 ()
    {
        var str = string.Join (
            "\n",
            Enumerable.Range (1, int.Parse (Console.ReadLine ()))
                .Select (i => new string (Enumerable.Repeat ('*', i).ToArray ()))
                .ToArray ());
        Console.WriteLine (str);
    }
}