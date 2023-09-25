// 다이얼
// https://www.acmicpc.net/problem/5622

using System;

public class Baekjoon5622
{
    public Baekjoon5622 ()
    {
        string arr = Console.ReadLine ();
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += Convert (arr[i]) + 1;
        }
        Console.WriteLine (sum);

        int Convert (char c)
        {
            int num = c switch
            {
                >= 'A' and <= 'C' => 2,
                >= 'D' and <= 'F' => 3,
                >= 'G' and <= 'I' => 4,
                >= 'J' and <= 'L' => 5,
                >= 'M' and <= 'O' => 6,
                >= 'P' and <= 'S' => 7,
                >= 'T' and <= 'V' => 8,
                >= 'W' and <= 'Z' => 9,
                _ => 10,
            };
            return num;
        }
    }
}