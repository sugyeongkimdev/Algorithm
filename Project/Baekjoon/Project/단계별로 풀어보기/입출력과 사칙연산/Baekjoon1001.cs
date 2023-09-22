// A-B
// https://www.acmicpc.net/problem/1001

using System;

public class Baekjoon1001
{
    public Baekjoon1001 ()
    {
        string[] arr = Console.ReadLine ().Split (' ');
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        Console.WriteLine (a - b);
    }
}