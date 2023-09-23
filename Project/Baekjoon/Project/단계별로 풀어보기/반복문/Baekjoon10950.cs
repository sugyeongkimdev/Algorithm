// A+B - 3
// https://www.acmicpc.net/problem/10950

using System;

public class Baekjoon10950
{
    public Baekjoon10950 ()
    {
        for (int i = int.Parse (Console.ReadLine ()); i > 0; i--)
        {
            var arr = Console.ReadLine ().Split ();
            Console.WriteLine ($"{int.Parse (arr[0]) + int.Parse (arr[1])}");
        }
    }
}