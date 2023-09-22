
// 문자열 내 마음대로 정렬하기
// https://programmers.co.kr/learn/courses/30/lessons/12915

using System.Linq;

public class Programmers12915
{
    public Programmers12915 ()
    {
        new Solution ().solution (new[] { "sun", "bed", "car" }, 1);
    }

    //====================================//
    public class Solution
    {
        public string[] solution (string[] strings, int n)
        {
            var list = strings.ToList ();
            list.Sort ((a, b) => Custom (a, b, n));
            return list.ToArray ();
        }

        public int Custom (string a, string b, int n)
        {
            int com = a[n].CompareTo (b[n]);
            if (com != 0)
            {
                return com;
            }
            else
            {
                return a.CompareTo (b);
            }
        }
    }
    //====================================//
}