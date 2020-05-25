using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class BinaryTreeLevelOrderTraversal
    {
        private static Dictionary<int, IList<int>> levelDic = new Dictionary<int, IList<int>>();
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            AddNodesToLevelDictionary(root, 1);
            return levelDic.Select(pair => pair.Value).ToList();
        }

        private static void AddNodesToLevelDictionary(TreeNode node, int level)
        {
            if (node == null)
                return;
            
            if (levelDic.ContainsKey(level))
                levelDic[level].Add(node.val);
            else
                levelDic.Add(level, new List<int>() {node.val});
            
            if (node.left != null)
                AddNodesToLevelDictionary(node.left, level + 1);
            if (node.right != null)
                AddNodesToLevelDictionary(node.right, level + 1);
        }
    }
}