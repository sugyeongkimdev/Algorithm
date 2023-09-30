// 소인수분해
// https://www.acmicpc.net/problem/11653

using System;

public class Baekjoon11653
{
    public Baekjoon11653 ()
    {
        int num = int.Parse (Console.ReadLine ());
        for (int i = 2; num != 1; i++)
        {
            if (num % i == 0)
            {
                num = num / i;
                Console.WriteLine (i--);
            }
        }
    }
}