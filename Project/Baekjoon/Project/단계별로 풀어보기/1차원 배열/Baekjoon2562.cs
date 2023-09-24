// 최소, 최대
// https://www.acmicpc.net/problem/2562

using System;

public class Baekjoon2562
{
    public Baekjoon2562 ()
    {
        int max = int.MinValue;
        int index = 0;
        for (int i = 0; i < 9; i++)
        {
            var num = int.Parse (Console.ReadLine ());
            if (num > max)
            {
                max = num;
                index = i + 1;
            }
        }
        Console.WriteLine (max);
        Console.WriteLine (index);
    }
}