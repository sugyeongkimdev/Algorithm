// A/B
// https://www.acmicpc.net/problem/1008

using System;

public class Baekjoon1008
{
    public Baekjoon1008 ()
    {
        string[] arr = Console.ReadLine ().Split (' ');
        double a = double.Parse (arr[0]);
        double b = double.Parse (arr[1]);
        Console.WriteLine (a / b);
    }
}