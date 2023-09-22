// 윤년
// https://www.acmicpc.net/problem/2753

using System;

public class Baekjoon2753
{
    public Baekjoon2753 ()
    {
        int year = int.Parse (Console.ReadLine ());
        Console.WriteLine ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? 1 : 0);
    }
}