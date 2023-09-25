// 색종이
// https://www.acmicpc.net/problem/2563

using System;

public class Baekjoon2563
{
    public Baekjoon2563 ()
    {
        int paper = int.Parse (Console.ReadLine ());
        bool[,] arr = new bool[100, 100];
        int count = 0;
        for (int i = 0; i < paper; i++)
        {
            var line = Console.ReadLine ().Split ();
            int x = int.Parse (line[0]);
            int y = int.Parse (line[1]);

            for (int j = x; j < x + 10; j++)
            {
                for (int k = y; k < y + 10; k++)
                {
                    if (arr[j, k] == false)
                    {
                        count++;
                    }
                    arr[j, k] = true;
                }
            }
        }
        Console.WriteLine (count);
    }
}