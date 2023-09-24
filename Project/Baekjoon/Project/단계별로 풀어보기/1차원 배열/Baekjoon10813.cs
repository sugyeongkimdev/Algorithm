// 공 바꾸기
// https://www.acmicpc.net/problem/10813

using System;
using System.Linq;

public class Baekjoon10813
{
    public Baekjoon10813 ()
    {
        var firstArr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
        int[] basketArr = Enumerable.Range (1, firstArr[0]).ToArray ();
        int count = firstArr[1];
        for (int i = 0; i < count; i++)
        {
            var line = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            int temp = basketArr[line[0] - 1];
            basketArr[line[0] - 1] = basketArr[line[1] - 1];
            basketArr[line[1] - 1] = temp;
        }
        Console.WriteLine (string.Join (" ", basketArr));
    }
}