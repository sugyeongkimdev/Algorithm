
// 시저 암호
// https://programmers.co.kr/learn/courses/30/lessons/12925

public class Programmers12926
{
    public Programmers12926 ()
    {
        new Solution ().solution ("A", 1);
        new Solution ().solution ("z", 1);
    }

    //====================================//
    public class Solution
    {
        public string solution (string s, int n)
        {
            var arr = s.ToCharArray ();
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[i] == ' ')
                {
                    continue;
                }

                int start = (arr[i] >= 65 && arr[i] <= 90) ? 65 : 97;
                int end = (arr[i] >= 65 && arr[i] <= 90) ? 90 : 122;
                if (arr[i] + n > end)
                {
                    arr[i] = (char)((arr[i] + n) % end + start - 1);
                }
                else
                {
                    arr[i] = (char)(arr[i] + n);
                }
            }
            return new string (arr);
        }
    }
    //====================================//
}