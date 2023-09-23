// 영수증
// https://www.acmicpc.net/problem/25304

using System;

public class Baekjoon25304
{
    public Baekjoon25304 ()
    {
        int sum = int.Parse (Console.ReadLine ());
        for (int i = int.Parse (Console.ReadLine ()); i > 0; i--)
        {
            var arr = Console.ReadLine ().Split ();
            sum -= int.Parse (arr[0]) * int.Parse (arr[1]);
        }
        Console.WriteLine (sum == 0 ? "Yes" : "No");
    }
}