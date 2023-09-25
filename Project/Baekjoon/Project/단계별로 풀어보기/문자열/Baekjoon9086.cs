// 문자열
// https://www.acmicpc.net/problem/9086

using System;

public class Baekjoon9086
{
    public Baekjoon9086 ()
    {
        int leng = int.Parse (Console.ReadLine ());
        for (int i = 0; i < leng; i++)
        {
            string str = Console.ReadLine ();
            Console.WriteLine ($"{str[0]}{str[str.Length - 1]}");
        }
    }
}