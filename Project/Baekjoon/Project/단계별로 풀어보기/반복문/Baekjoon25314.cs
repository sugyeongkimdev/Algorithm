// 코딩은 체육과목 입니다
// https://www.acmicpc.net/problem/25314
using System;
using System.Linq;

public class Baekjoon25314
{
    public Baekjoon25314 ()
    {
        int b = int.Parse (Console.ReadLine ());
        string str = string.Join ("", Enumerable.Repeat ("long ", b / 4)) + "int";
        Console.WriteLine (str);
    }
}