// 네 번째 점
// https://www.acmicpc.net/problem/3009

using System;

public class Baekjoon3009
{
    public Baekjoon3009 ()
    {
        int[] xy1 = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] xy2 = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] xy3 = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] xy4 = { 0, 0 };
        xy4[0] = xy1[0] == xy2[0] ?
            xy3[0] :
            xy1[0] == xy3[0] ?
                xy2[0] :
                xy1[0];
        xy4[1] = xy1[1] == xy2[1] ?
            xy3[1] :
            xy1[1] == xy3[1] ?
                xy2[1] :
                xy1[1];
        Console.WriteLine ($"{xy4[0]} {xy4[1]}");
    }
}