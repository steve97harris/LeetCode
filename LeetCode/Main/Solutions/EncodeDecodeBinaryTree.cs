using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Main.VersatileClasses;

namespace LeetCode.Main
{
    public class EncodeDecodeBinaryTree
    {
        private Dictionary<TreeNode, string> map = new Dictionary<TreeNode, string>();
        private string _currString = "";
        public string Serialize(TreeNode root)
        {
            if (root == null)
                return "";
            
            if (map.ContainsKey(root))
                return map[root];
            
            TreeToString(root);
            var res = _currString;
            _currString = "";
            map.Add(root, res);
            
            Console.WriteLine(res);
            return res;
        }

        public TreeNode Deserialize(string data)
        {
            if (map.ContainsValue(data))
            {
                var pair = map.FirstOrDefault(x => x.Value == data).Key;
                return pair;
            }

            if (data.Contains('['))
            {
                data = data.Remove(0, 1);
                data = data.Remove(data.Length-1, 1);
            }
            
            var dataList = new List<int>();
            var stringArr = data.Split(',');
            foreach (var s in stringArr)
            {
                int.TryParse(s, out var result);
                if (result > 0)
                    dataList.Add(result);
                else
                {
                    dataList.Add(-1);
                }
            }
            
            var root = ArrayToBt(dataList.ToArray(), new TreeNode(), 0);
            root.Print();
                
            return root;
        }

        private void TreeToString(TreeNode node)
        {
            if (node == null)
            {
                _currString += "null,";
                return;
            }
        
            _currString += node.val + ",";
            
            TreeToString(node.left);
            TreeToString(node.right);
        }

        private static TreeNode ArrayToBt(int[] nums, TreeNode root, int i)
        {
            if (i >= nums.Length) 
                return root;

            TreeNode temp = null;
            
            if (nums[i] != -1)
                temp = new TreeNode(nums[i]);

            root = temp;

            if (root == null) 
                return null;
            
            root.left = ArrayToBt(nums, root.left, 2 * i + 1);
            root.right = ArrayToBt(nums, root.right, 2 * i + 2);

            return root; 
        }
    }
}