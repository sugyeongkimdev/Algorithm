// 최소, 최대
// https://www.acmicpc.net/problem/10818

using System;

public class Baekjoon10818
{
    public Baekjoon10818 ()
    {
        var num = int.Parse (Console.ReadLine ());
        var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < num; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine ($"{min} {max}");
    }
}