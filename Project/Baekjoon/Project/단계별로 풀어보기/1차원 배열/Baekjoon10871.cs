// X보다 작은 수
// https://www.acmicpc.net/problem/10871

using System;

public class Baekjoon10871
{
    public Baekjoon10871 ()
    {
        var num = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        for (int i = 0; i < num[0]; i++)
        {
            if (arr[i] < num[1])
            {
                Console.Write ($"{arr[i]} ");
            }
        }
    }
}