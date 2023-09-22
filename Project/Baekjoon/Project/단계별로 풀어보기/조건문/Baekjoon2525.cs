// 오븐 시계
// https://www.acmicpc.net/problem/2525
using System;

public class Baekjoon2525
{
    public Baekjoon2525 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        string str = Console.ReadLine ();
        int cur_h = int.Parse (arr[0]);
        int cur_m = int.Parse (arr[1]);
        int end_m = int.Parse (str);

        var ts = TimeSpan.FromMinutes (new TimeSpan (cur_h, cur_m, 0).TotalMinutes + end_m);
        Console.WriteLine ($"{ts.Hours} {ts.Minutes}");
    }
}