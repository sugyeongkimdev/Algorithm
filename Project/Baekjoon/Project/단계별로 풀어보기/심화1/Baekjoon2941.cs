// 크로아티아 알파벳 
// https://www.acmicpc.net/problem/2941

using System;

public class Baekjoon2941
{
    public Baekjoon2941 ()
    {
        string[] matArr = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z="};
        string str = Console.ReadLine ();
        int result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            result++;
            for (int j = 0; j < matArr.Length; j++)
            {
                string word = matArr[j];

                for (int k = 0; k < word.Length; k++)
                {
                    if (i + k > str.Length - 1)
                    {
                        break;
                    }
                    if (str[i + k] == word[k])
                    {
                        if(k == word.Length -1)
                        {
                            result--;
                            j = matArr.Length;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine (result);
    }
}