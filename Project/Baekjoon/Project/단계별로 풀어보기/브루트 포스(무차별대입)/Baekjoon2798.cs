// 블랙잭 
// https://www.acmicpc.net/problem/2798

using System;

public class Baekjoon2798
{
    public Baekjoon2798 ()
    {
        int[] NM = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);

        int M = NM[1];
        int result = int.MinValue;
        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = i + 1; j < arr.Length - 1; j++)
            {
                for (int k = j + 1; k < arr.Length; k++)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (sum == M)
                    {
                        result = sum;
                        Console.WriteLine (result);
                        return;
                    }
                    if (sum <= M && sum >= result)
                    {
                        result = sum;
                    }
                }
            }
        }

        Console.WriteLine (result);
    }
}