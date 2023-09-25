// 그룹 단어 체커
// https://www.acmicpc.net/problem/1316

using System;

public class Baekjoon1316
{
    public Baekjoon1316 ()
    {
        int count = int.Parse (Console.ReadLine ());
        int result = count;

        for (int i = 0; i < count; i++)
        {
            string str = Console.ReadLine ();
            bool[] checkArr = new bool['z' - 'a' + 1];
            for (int j = 0; j < str.Length; j++)
            {
                int index = str[j] - 'a';
                if (j > 0 && str[j] != str[j - 1])
                {
                    if (checkArr[index])
                    {
                        result--;
                        break;
                    }
                }
                checkArr[index] = true;
            }
        }
        Console.Write (result);
    }
}