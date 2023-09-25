// 세로읽기
// https://www.acmicpc.net/problem/10798

using System;

public class Baekjoon10798
{
    public Baekjoon10798 ()
    {
        char[,] arr2D = new char[5, 15];
        for (int i = 0; i < 5; i++)
        {
            var str = Console.ReadLine ();
            for (int j = 0; j < str.Length; j++)
            {
                arr2D[i, j] = str[j];
            }
        }
        var sb = new System.Text.StringBuilder ();
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                char c = arr2D[j, i];
                if (c != '\0')
                {
                    sb.Append (arr2D[j, i]);
                }
            }
        }
        Console.WriteLine (sb);
    }
}