// 커트라인 
// https://www.acmicpc.net/problem/25305

using System;

public class Baekjoon25305
{
    public Baekjoon25305 ()
    {
        var read = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        var grades = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);;
        int target = read[1];

        LimitBubbleSort (grades);
        Console.WriteLine (grades[grades.Length - target]);

        void LimitBubbleSort (int[] arr)
        {
            for (int i = 0; i < target; i++)
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