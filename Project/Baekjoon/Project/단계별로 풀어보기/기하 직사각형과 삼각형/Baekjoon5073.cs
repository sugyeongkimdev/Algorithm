// 삼각형과 세 변
// https://www.acmicpc.net/problem/5073

using System;

public class Baekjoon5073
{
    public Baekjoon5073 ()
    {
        while (true)
        {
            int[] arr = Array.ConvertAll (Console.ReadLine ().Split (), int.Parse);
            if (arr[0] == 0 && arr[0] == 0 && arr[1] == 0)
            {
                break;
            }

            if (arr[0] >= arr[1] && arr[0] >= arr[2])
            {

                if (arr[0] >= arr[1] + arr[2])
                {
                    Console.WriteLine ("Invalid");
                    continue;
                }
            }
            else if (arr[1] >= arr[0] && arr[1] >= arr[2])
            {
                if (arr[1] >= arr[0] + arr[2])
                {
                    Console.WriteLine ("Invalid");
                    continue;
                }
            }
            else if (arr[2] >= arr[0] && arr[2] >= arr[1])
            {
                if (arr[2] >= arr[0] + arr[1])
                {
                    Console.WriteLine ("Invalid");
                    continue;
                }
            }

            if (arr[0] == arr[1] && arr[0] == arr[2] && arr[1] == arr[2])
            {
                Console.WriteLine ("Equilateral");
            }
            else if (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
            {
                Console.WriteLine ("Isosceles");
            }
            else
            {
                Console.WriteLine ("Scalene");
            }
        }
    }
}