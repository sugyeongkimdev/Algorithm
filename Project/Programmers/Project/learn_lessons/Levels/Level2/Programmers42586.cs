
// 기능개발
// https://programmers.co.kr/learn/courses/30/lessons/42586

using System.Collections.Generic;

public class Programmers42586
{
    public Programmers42586 ()
    {
        new Solution ().solution (new[] { 93, 30, 55 }, new[] { 1, 30, 5 });
    }

    //====================================//
    public class Solution
    {
        public int[] solution (int[] progresses, int[] speeds)
        {
            var list = new List<int> ();
            int pro = 0;
            while (pro < progresses.Length)
            {
                int func = 0;

                while (progresses[pro] < 100)
                {
                    for (int i = 0; i < progresses.Length; i++)
                    {
                        progresses[i] += speeds[i];
                    }
                }

                for (int i = pro; i < progresses.Length; i++)
                {
                    if (progresses[i] >= 100)
                    {
                        pro++;
                        func++;
                    }
                    else
                    {
                        break;
                    }
                }
                list.Add (func);
            }

            return list.ToArray ();
        }
    }
    //====================================//
}