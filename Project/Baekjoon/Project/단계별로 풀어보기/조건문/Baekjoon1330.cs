// 두 수 비교하기
// https://www.acmicpc.net/problem/1330

using System;

public class Baekjoon1330
{
    public Baekjoon1330 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        Console.WriteLine (a > b ? ">" : a < b ? "<" : "==");
    }
}