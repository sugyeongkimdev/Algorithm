// 대표값2
// https://www.acmicpc.net/problem/2587

using System;
using System.Linq;

public class Baekjoon2587
{
    public Baekjoon2587 ()
    {
        int[] sort = new int[5];
        for (int i = 0; i < 5; i++)
        {
            sort[i] = int.Parse (Console.ReadLine ());
        }

        BubbleSort (sort);
        Console.WriteLine ($"{sort.Average ()}\n{sort[2]}");

        void BubbleSort (int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }
    }
}