// 사칙연산
// https://www.acmicpc.net/problem/10869

using System;

public class Baekjoon10869
{
    public Baekjoon10869 ()
    {
        string[] arr = Console.ReadLine ().Split (' ');
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        Console.WriteLine ($"{a + b}\n{a - b}\n{a * b}\n{a / b}\n{a % b}");
    }
}