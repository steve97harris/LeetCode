using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public class LeastRecentlyUsedCache
    {
        private List<int> cache = new List<int>();
        private int mCapacity;
        private List<int> keysUsed = new List<int>();
        private int mLastKeyUsed;
        
        public LeastRecentlyUsedCache(int capacity)
        {
            mCapacity = capacity;
        }

        public int Get(int key)
        {
            if (keysUsed.Contains(key))
            {
                var index = keysUsed.IndexOf(key);
                var value = cache[index];

                keysUsed.RemoveAt(index);
                cache.RemoveAt(index);
                
                keysUsed.Add(key);
                cache.Add(value);
                
                Console.WriteLine("returns " + value);
                return value;
            }

            Console.WriteLine("returns " + -1 + " (not found)");
            return -1;
        }

        public void Put(int key, int value)
        {
            if (keysUsed.Contains(key))
            {
                var index = keysUsed.IndexOf(key);
                Console.WriteLine("evicts " + cache[index]);
                
                keysUsed.RemoveAt(index);
                cache.RemoveAt(index);
            }

            if (mCapacity == keysUsed.Count)
            {
                Console.WriteLine("evicts " + cache[0]);
                keysUsed.RemoveAt(0);
                cache.RemoveAt(0);
            }
            
            keysUsed.Add(key);
            cache.Add(value);
        }
    }
}