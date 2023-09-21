
// 프린터
// https://programmers.co.kr/learn/courses/30/lessons/42587

using System.Collections.Generic;
using System.Linq;

public class Solution42587
{
    public Solution42587 ()
    {
        new Solution ().solution (new[] { 2, 1, 3, 2 }, 2);
    }

    //====================================//
    public class Solution
    {
        public int solution (int[] priorities, int location)
        {
            int answer = 0;
            Queue<int> que = new Queue<int> (Enumerable.Range (0, priorities.Length));
            List<int> max = new List<int> (priorities);

            while (que.Count > 0)
            {
                int document = que.Dequeue ();

                if (max.Max () <= priorities[document])
                {
                    answer++;
                    max.Remove (priorities[document]);

                    if (document == location)
                        break;
                }
                else
                    que.Enqueue (document);
            }

            return answer;
        }
    }
    //====================================//
}