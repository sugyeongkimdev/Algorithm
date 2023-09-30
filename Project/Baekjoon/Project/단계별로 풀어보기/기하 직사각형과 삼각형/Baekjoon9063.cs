// 대지
// https://www.acmicpc.net/problem/9063

using System;

public class Baekjoon9063
{
    public Baekjoon9063 ()
    {
        int n = int.Parse (Console.ReadLine ());

        int[] min = { int.MaxValue, int.MaxValue };
        int[] max = { int.MinValue, int.MinValue };
        for (int i = 0; i < n; i++)
        {
            var arr = Console.ReadLine ().Split ();
            int x = int.Parse (arr[0]);
            int y = int.Parse (arr[1]);

            max[0] = max[0] < x ? x : max[0];
            max[1] = max[1] < y ? y : max[1];
            min[0] = min[0] > x ? x : min[0];
            min[1] = min[1] > y ? y : min[1];
        }
        Console.WriteLine ((max[0] - min[0]) * (max[1] - min[1]));
    }
}