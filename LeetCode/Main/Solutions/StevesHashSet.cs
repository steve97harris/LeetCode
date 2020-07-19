using System;
using System.Collections;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class StevesHashSet : IEnumerable
    {
        private const int mSize = 10000;
        private int[] mSet;
        
        public StevesHashSet()
        {
            mSet = new int[mSize];
            for (int i = 0; i < mSize; i++)
            {
                mSet[i] = -1;
            }
        }

        public void Add(int key)
        {
            for (int i = 0; i < mSet.Length; i++)
            {
                if (mSet[i] != -1) continue;
                mSet[i] = key;
                return;
            }
        }

        

        public void Remove(int key)
        {
            if (!mSet.Contains(key)) return;
            for (int i = 0; i < mSet.Length; i++)
            {
                if (mSet[i] == key)
                    mSet[i] = -1;
            }
        }

        public bool Contains(int key)
        {
            return mSet.Contains(key);
        }

        public void PrintFirst5()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(mSet[i]);
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}