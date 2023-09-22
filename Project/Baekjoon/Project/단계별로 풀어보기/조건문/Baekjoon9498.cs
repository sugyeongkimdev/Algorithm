// 시험 성적
// https://www.acmicpc.net/problem/9498

using System;

public class Baekjoon9498
{
    public Baekjoon9498 ()
    {
        int a = int.Parse (Console.ReadLine ());
        Console.WriteLine (
            a > 89 ?
            "A" :
            a > 79 ?
            "B" :
            a > 69 ?
            "C" :
            a > 59 ?
            "D" :
            "F");
    }
}