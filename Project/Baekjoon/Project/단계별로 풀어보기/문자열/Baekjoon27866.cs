// 문자와 문자열
// https://www.acmicpc.net/problem/27866

using System;

public class Baekjoon27866
{
    public Baekjoon27866 ()
    {
        string str = Console.ReadLine ();
        int i = int.Parse(Console.ReadLine ());
        Console.WriteLine (str[i - 1]);
    }
}