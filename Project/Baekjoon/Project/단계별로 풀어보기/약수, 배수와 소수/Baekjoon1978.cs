// 소수 찾기
// https://www.acmicpc.net/problem/1978

using System;

public class Baekjoon1978
{
    public Baekjoon1978 ()
    {
        int count = int.Parse (Console.ReadLine ());
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (IsPrimeNum (arr[i]))
            {
                result++;
            }
        }
        Console.WriteLine ($"{result}");

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