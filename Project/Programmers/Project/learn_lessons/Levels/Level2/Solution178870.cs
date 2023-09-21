
// 연속된 부분 수열의 합
// https://school.programmers.co.kr/learn/courses/30/lessons/178870

public class Solution178870
{
    public Solution178870 ()
    {
        //new Solution ().solution (new[] { 1, 2, 3, 4, 5 }, 7);
        new Solution ().solution (new[] { 1, 1, 1, 2, 3, 4, 5 }, 5);
        //new Solution ().solution (new[] { 2, 2, 2, 2, 2 }, 6);
    }

    public class Solution
    {
        public int[] solution (int[] sequence, int k)
        {
            int r = 0;
            int l = 0;
            int sum = sequence[r];
            int leng = sequence.Length;
            int[] result = new int[] { 0, int.MaxValue };
            while (true)
            {
                if (sum == k)
                {
                    if (r - l < result[1] - result[0])
                    {
                        result = new int[] { l, r };
                    }
                }
                if (r == leng && l == leng)
                {
                    break;
                }

                if (sum <= k && r < leng)
                {
                    r++;
                    if (r < leng)
                    {
                        sum += sequence[r];
                    }
                }
                else
                {
                    if (l < leng)
                    {
                        sum -= sequence[l];
                    }
                    l++;
                }
            }

            return result;
        }
    }
}