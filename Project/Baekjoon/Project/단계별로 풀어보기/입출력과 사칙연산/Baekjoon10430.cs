// 나머지
// https://www.acmicpc.net/problem/10430

using System;

public class Baekjoon10430
{
    public Baekjoon10430 ()
    {
        string[] arr = Console.ReadLine ().Split ();
        int a = int.Parse (arr[0]);
        int b = int.Parse (arr[1]);
        int c = int.Parse (arr[2]);

        Console.WriteLine ((a + b) % c);
        Console.WriteLine (((a % c) + (b % c)) % c);
        Console.WriteLine ((a * b) % c);
        Console.WriteLine (((a % c) * (b % c)) % c);
        // (A + B) % C, 
        // ((A % C) + (B % C)) % C, 
        // (A × B) % C, 
        // ((A % C) × (B % C)) % C
    }
}