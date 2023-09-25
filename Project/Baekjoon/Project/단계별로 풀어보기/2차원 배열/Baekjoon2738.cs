// 행렬 덧셈
// https://www.acmicpc.net/problem/2738

using System;

public class Baekjoon2738
{
    public Baekjoon2738 ()
    {
        var line = Console.ReadLine ().Split ();
        int N = int.Parse (line[0]);
        int M = int.Parse (line[1]);
        int[,] arr2D = new int[N, M];
        for (int i = 0; i < N; i++)
        {
            var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            for (int j = 0; j < M; j++)
            {
                arr2D[i, j] = arr[j];
            }
        }
        for (int i = 0; i < N; i++)
        {
            var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            for (int j = 0; j < M; j++)
            {
                arr2D[i, j] += arr[j];
            }
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write ($"{arr2D[i, j]} ");
            }
            Console.WriteLine ();
        }
    }
}