// A+B
// https://www.acmicpc.net/problem/1000

using System;

public class Baekjoon1000
{
    public Baekjoon1000 ()
    {
        string[] arr = Console.ReadLine ().Split (' ');
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        Console.WriteLine (a + b);
    }
}