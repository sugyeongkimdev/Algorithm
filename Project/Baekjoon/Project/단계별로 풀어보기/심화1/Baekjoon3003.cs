// 킹, 퀸, 룩, 비숍, 나이트, 폰
// https://www.acmicpc.net/problem/3003

using System;

public class Baekjoon3003
{
    public Baekjoon3003 ()
    {
        int[] defaultArr = new[] { 1, 1, 2, 2, 2, 8 };
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write ($"{defaultArr[i] - arr[i]} ");
        }
    }
}