// 공 넣기
// https://www.acmicpc.net/problem/10810

using System;

public class Baekjoon10810
{
    public Baekjoon10810 ()
    {
        var firstArr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] basketArr = new int[firstArr[0]];
        int count = firstArr[1];
        for (int i = 0; i < firstArr[1]; i++)
        {
            var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            int start = arr[0];
            int end = arr[1];
            int num = arr[2];
            for (; start <= end; start++)
            {
                basketArr[start - 1] = num;
            }
        }
        Console.WriteLine (string.Join (" ", basketArr));
    }
}