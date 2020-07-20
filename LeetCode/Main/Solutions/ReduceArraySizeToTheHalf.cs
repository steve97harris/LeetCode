using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class ReduceArraySizeToTheHalf
    {
        private Dictionary<int, int> _map;
        private int _halfLength;
        private int _count = 0;
        public int MinSetSize(int[] arr)
        {
            var cloneArr = new List<int>();
            _halfLength = arr.Length / 2;
                
            _map = new Dictionary<int, int>();    // arr[i], count
            for (int i = 0; i < arr.Length; i++)
            {
                cloneArr.Add(arr[i]);
                
                if (!_map.ContainsKey(arr[i]))
                    _map.Add(arr[i], 1);
                else
                    _map[arr[i]]++;
            }

            RemoveValues(cloneArr);

            Console.WriteLine(_count);
            return _count;
        }

        private void RemoveValues(List<int> clone)
        {
            while (clone.Count > _halfLength)
            {
                var largest = 0;
                var mapValues = _map.Values.ToList();
                foreach (var pair in _map.Where(pair => pair.Value == mapValues.Max()))
                {
                    largest = pair.Key;
                }

                clone.RemoveAll(i => i == largest);
                _map.Remove(largest);
                _count++;
            }
        }
    }
}