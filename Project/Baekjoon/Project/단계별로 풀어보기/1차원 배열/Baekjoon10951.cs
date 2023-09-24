// 개수 세기
// https://www.acmicpc.net/problem/10807

using System;

public class Baekjoon10807
{
    public Baekjoon10807 ()
    {
        int c = int.Parse (Console.ReadLine ());
        var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int n = int.Parse (Console.ReadLine ());
        int result = 0;
        for (int i = 0; i < c; i++)
        {
            if (arr[i] == n)
            {
                result++;
            }
        }
        Console.WriteLine (result);
    }
}