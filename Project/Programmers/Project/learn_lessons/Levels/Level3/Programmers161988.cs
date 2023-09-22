
// 연속 펄스 부분 수열의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/161988
// https://velog.io/@jaehyeonkim2358/%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%98%EB%A8%B8%EC%8A%A4Python-%EC%97%B0%EC%86%8D-%ED%8E%84%EC%8A%A4-%EB%B6%80%EB%B6%84-%EC%88%98%EC%97%B4%EC%9D%98-%ED%95%A9

using System;
using System.Linq;

public class Programmers161988
{
    public Programmers161988 ()
    {
        new Solution ().solution (new[] { 2, 3, -6, 1, 3 - 1, 2, 4 });
    }
    public class Solution
    {
        public long solution (int[] sequence)
        {
            long answer = long.MinValue;
            long seq1 = 0;
            long seq2 = 0;
            long seq1Min = 0;
            long seq2Min = 0;
            int pulse = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                seq1 += sequence[i] * pulse;
                seq2 += sequence[i] * -pulse;
                answer = new[] { answer, seq1 - seq1Min, seq2 - seq2Min }.Max ();
                seq1Min = Math.Min (seq1Min, seq1);
                seq2Min = Math.Min (seq2Min, seq2);
                pulse *= -1;
            }

            return answer;
        }
    }
}