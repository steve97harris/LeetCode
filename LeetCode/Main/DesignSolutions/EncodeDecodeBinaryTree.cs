using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Main.VersatileClasses;

namespace LeetCode.Main
{
    public class EncodeDecodeBinaryTree
    {
        private Dictionary<TreeNode, string> map = new Dictionary<TreeNode, string>();
        private string currString = "";
        public string Serialize(TreeNode root)
        {
            if (map.ContainsKey(root))
                return map[root];

            TreeToString(root);
            var res = currString;
            currString = "";
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

            foreach (var i in dataList)
            {
                Console.WriteLine(i);
            }
            var root = InsertNode(dataList.ToArray(), 0, dataList.Count - 1);
            root.Print();
                
            return root;
        }

        private void TreeToString(TreeNode node)
        {
            if (node == null)
            {
                currString += "null,";
                return;
            }

            currString += node.val + ",";
            
            TreeToString(node.left);
            TreeToString(node.right);
        }
        
        private TreeNode InsertNode(int[] nums, int left, int right)
        {
            if (right < left)
                return null;
            
            var mid = (left + right) / 2;
            
            var root = new TreeNode(nums[mid]);
            root.left = InsertNode(nums, left, mid - 1);
            root.right = InsertNode(nums, mid + 1, right);

            return root;
        }    
    }
}