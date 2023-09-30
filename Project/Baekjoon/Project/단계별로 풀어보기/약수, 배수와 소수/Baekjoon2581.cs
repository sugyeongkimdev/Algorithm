// 소수
// https://www.acmicpc.net/problem/2581

using System;

public class Baekjoon2581
{
    public Baekjoon2581 ()
    {
        int M = int.Parse (Console.ReadLine ());
        int N = int.Parse (Console.ReadLine ());
        int sum = 0;
        int first = 0;
        for (int i = M; i <= N; i++)
        {
            if (IsPrimeNum (i))
            {
                sum += i;
                if (first == 0)
                {
                    first = i;
                }
            }
        }

        sum = sum == 0 ? -1 : sum;
        Console.WriteLine (sum);
        if (sum != -1)
        {
            Console.WriteLine (first);
        }

        bool IsPrimeNum (int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}