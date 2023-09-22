// 알람 시계
// https://www.acmicpc.net/problem/2884
using System;

public class Baekjoon2884
{
    public Baekjoon2884 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        int h = int.Parse (arr[0]);
        h = h == 0 ? 24 : h;
        int m = int.Parse (arr[1]);
        var ts = TimeSpan.FromMinutes (new TimeSpan (h, m, 0).TotalMinutes - 45);
        Console.WriteLine ($"{ts.Hours} {ts.Minutes}");
    }
}