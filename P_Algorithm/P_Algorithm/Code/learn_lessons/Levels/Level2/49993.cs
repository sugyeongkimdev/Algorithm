// 스킬트리
// https://programmers.co.kr/learn/courses/30/lessons/49993

namespace P_Algorithm_49993 {
    public class ActiveClass {
        public void Active() {
            new Solution().solution("CBD", new[] { "BACDE", "CBADF", "AECB", "BDA" });
        }
    }

    //====================================//

    public class Solution {
        public int solution(string skill, string[] skill_trees) {
            int hit = 0;
            for(int treeCount = 0; treeCount < skill_trees.Length; treeCount++) {
                if(Check(skill, skill_trees[treeCount])) {
                    hit++;
                }
            }
            return hit;
        }

        bool Check(string _skill, string _tree) {
            int skillIndex = 0;
            for(int treeLeng = 0; treeLeng < _tree.Length; treeLeng++) {
                for(int skillLeng = 0; skillLeng < _skill.Length; skillLeng++) {

                    if(_tree[treeLeng] == _skill[skillLeng]) {

                        if(skillIndex != skillLeng) {
                            return false;
                        }

                        skillIndex++;
                    }
                }
            }
            return true;
        }
    }

}
