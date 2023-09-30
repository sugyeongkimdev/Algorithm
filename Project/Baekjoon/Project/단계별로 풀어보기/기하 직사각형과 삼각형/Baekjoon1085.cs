// 직사각형에서 탈출
// https://www.acmicpc.net/problem/1085

using System;

public class Baekjoon1085
{
    public Baekjoon1085 ()
    {
        int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int x = arr[0];
        int y = arr[1];
        int w = arr[2];
        int h = arr[3];
        Console.WriteLine (Math.Min (Math.Min (x, y), Math.Min (w - x, h - y)));
    }
}