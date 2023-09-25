// 너의 평점은
// https://www.acmicpc.net/problem/25206

using System;

public class Baekjoon25206
{
    public Baekjoon25206 ()
    {
        string str;
        float count = 0;
        float sum = 0;
        while (string.IsNullOrEmpty (str = Console.ReadLine ()) == false)
        {
            var arr = str.Split ();
            float score = float.Parse (arr[1]);
            string grade = arr[2];

            if (grade != "P")
            {
                count += score;
                sum += Grade(grade) * score;
            }
        }
        Console.Write (sum / count);

        float Grade (string grade)
        {
            return grade switch
            {
                "A+" => 4.5f,
                "A0" => 4.0f,
                "B+" => 3.5f,
                "B0" => 3.0f,
                "C+" => 2.5f,
                "C0" => 2.0f,
                "D+" => 1.5f,
                "D0" => 1.0f,
                _ => 0f
            };
        }
    }
}