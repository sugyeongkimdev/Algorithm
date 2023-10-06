// 설탕 배달
// https://www.acmicpc.net/problem/2839

using System;

public class Baekjoon2839
{
    public Baekjoon2839 ()
    {
        int N = int.Parse (Console.ReadLine ());
        int K3 = 3, K5 = 5;
        int result = 0;

        while (N >= 0)
        {
            if (N % K5 == 0)
            {
                result += N / K5;
                Console.WriteLine (result);
                return;
            }
            N -= K3;
            result++;
        }

        Console.WriteLine (-1);
    }
}