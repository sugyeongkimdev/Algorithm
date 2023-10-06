// 수 정렬하기
// https://www.acmicpc.net/problem/2750

using System;

public class Baekjoon2750
{
    public Baekjoon2750 ()
    {
        int num = int.Parse (Console.ReadLine ());
        int[] sort = new int[num];
        for (int i = 0; i < num; i++)
        {
            sort[i] = int.Parse (Console.ReadLine ());
        }

        BubbleSort (sort);
        Console.WriteLine (string.Join ("\n", sort));

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