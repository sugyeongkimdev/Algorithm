// 평균 
// https://www.acmicpc.net/problem/1546

using System;

public class Baekjoon1546
{
    public Baekjoon1546 ()
    {
        Console.ReadLine ();
        var arr = Array.ConvertAll (Console.ReadLine ().Split (), float.Parse);
        float max = float.MinValue;
        float sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            max = max < arr[i] ? arr[i] : max;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i] / max * 100;
        }
        Console.WriteLine (string.Format("{0:#.0######}", sum/arr.Length));
    }
}