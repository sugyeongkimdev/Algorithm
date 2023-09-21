
// 요격 시스템
// https://school.programmers.co.kr/learn/courses/30/lessons/181188
// https://mentum.tistory.com/734

using System.Linq;

public class Solution181188
{
    public Solution181188 ()
    {
        new Solution ().solution (new int[,] {{4,5},{4,8},{10,14},{11,13},{5,12},{3,7},{1,4}});
    }

    //====================================//
    public class Solution
    {
        public int solution (int[,] targets)
        {
            // 미사일 정렬
            var missiles = Enumerable
                .Range (0, targets.GetLength (0))
                .Select (i => (targets[i, 0], targets[i, 1]))
                .OrderBy (m => m.Item1);

            int hit = 0;
            int pointer = int.MaxValue;
            foreach ((int start, int end) missile in missiles)
            {
                if (missile.end < pointer)
                {
                    pointer = missile.end;
                    continue;
                }
                if (missile.start >= pointer)
                {
                    hit++;
                    pointer = missile.end;
                }
            }

            return hit + 1;
        }
    }
    //====================================//
}