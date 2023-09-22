
// 소수 만들기
// https://programmers.co.kr/learn/courses/30/lessons/12977

public class Programmers12977
{
    public Programmers12977 ()
    {
        new Solution ().solution (new[] { 1, 2, 3, 4 });
        //new Solution().solution(new[] { 1, 2, 7, 6, 4 });
    }

    //====================================//
    public class Solution
    {
        public int solution (int[] nums)
        {
            int answer = 0;
            int leng = nums.Length;
            for (int i = 0; i < leng; i++)
            {
                for (int j = i + 1; j < leng; j++)
                {
                    for (int k = j + 1; k < leng; k++)
                    {
                        if (IsPrime (nums[i] + nums[j] + nums[k]))
                        {
                            answer++;
                        }

                    }
                }
            }

            return answer;
        }

        // 소수 판별 메소드
        private bool IsPrime (int num)
        {
            for (int i = 2; i < num; i++)
            {
                // 나누어지는지 하나씩 대입
                if (num % i == 0)
                {
                    return false;
                }
            }
            // 1은 소수가 아님
            return num > 1;
        }
    }
    //====================================//
}