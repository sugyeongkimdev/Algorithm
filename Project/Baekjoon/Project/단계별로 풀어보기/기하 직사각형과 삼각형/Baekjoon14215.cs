// 세 막대
// https://www.acmicpc.net/problem/14215

using System;
using System.Linq;

public class Baekjoon14215
{
    public Baekjoon14215 ()
    {
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        var order = arr.OrderBy (n => n).ToArray ();
        int min = order[0];
        int mid = order[1];
        int max = order[2];
        if (min + mid <= max)
        {
            Console.WriteLine (min + mid + Math.Max (min + mid - 1, 1));
        }
        else
        {
            Console.WriteLine (min + mid + max);
        }
    }
}