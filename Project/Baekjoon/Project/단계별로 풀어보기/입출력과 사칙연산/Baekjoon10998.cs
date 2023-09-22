// A*B
// https://www.acmicpc.net/problem/10998

using System;

public class Baekjoon10998
{
    public Baekjoon10998 ()
    {
        string[] arr = Console.ReadLine ().Split (' ');
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        Console.WriteLine (a * b);
    }
}