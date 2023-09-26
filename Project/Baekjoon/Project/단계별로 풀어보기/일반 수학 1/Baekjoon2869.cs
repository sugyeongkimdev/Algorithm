// 달팽이는 올라가고 싶다
// https://www.acmicpc.net/problem/2869

using System;

public class Baekjoon2869
{
    public Baekjoon2869 ()
    {
        var arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int A = arr[0];
        int B = arr[1];
        int V = arr[2];
        // 날 = 총 - 밤 / 낮 - 밤
        int day = (int)Math.Ceiling ((V - B) / (double)(A - B));
        Console.WriteLine (day);
    }
}