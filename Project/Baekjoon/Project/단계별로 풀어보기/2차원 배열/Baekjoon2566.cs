// 최댓값
// https://www.acmicpc.net/problem/2566

using System;

public class Baekjoon2566
{
    public Baekjoon2566 ()
    {
        int max = int.MinValue;
        int x = 0;
        int y = 0;
        for (int i = 0; i < 9; i++)
        {
            var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            for (int j = 0; j < 9; j++)
            {
                if (arr[j] > max)
                {
                    max = arr[j];
                    x = i + 1;
                    y = j + 1;
                }
            }
        }
        Console.WriteLine (max);
        Console.WriteLine ($"{x} {y}");
    }
}