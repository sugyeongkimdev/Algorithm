// 꼬마 정민
// https://www.acmicpc.net/problem/11382
using System;

public class Baekjoon11382
{
    public Baekjoon11382 ()
    {
        string[] str = Console.ReadLine ().Split ();
        ulong a = ulong.Parse (str[0]);
        ulong b = ulong.Parse (str[1]);
        ulong c = ulong.Parse (str[2]);
        Console.WriteLine (a + b + c);
    }
}