// 분해합
// https://www.acmicpc.net/problem/2231

using System;

public class Baekjoon2231
{
    public Baekjoon2231 ()
    {
        int N = int.Parse (Console.ReadLine ());
        int result = 0;
        for (int i = 0; i <= N; i++)
        {
            if (Sum (i) == N)
            {
                result = i;
                break;
            }
        }
        Console.WriteLine (result);

        int Sum (int num)
        {
            int sum = num;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}