using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class StevesHashMap
    {
        // private List<int> keys;
        // private List<int> values;
        
        // or
        
        // public class MyTuple
        // {
        //     public int key;
        //     public int value;
        //     public MyTuple(int k, int v)
        //     {
        //         key = k;
        //         value = v;
        //     }
        // };
        //
        // List[] mymap;
        // int hashFunction = 10000;
        
        // or

        private int size = 1000000;
        public int[] keyValues { get; set; }

        public StevesHashMap()        // Initialize data structure here
        {
            keyValues = new int[size];
            for (int i = 0; i < keyValues.Length; i++)
            {
                keyValues[i] = -1;
            }
        }

        public void Put(int key, int value)
        {
            if (key < 0 || key > 1000000 || value < 0 || value > 1000000)
                return;
            
            keyValues[key] = value;
        }

        public int Get(int key)        // returns value subject to key or -1.
        {
            return keyValues[key];
        }

        public void Remove(int key)        // removes mapping of specified value key
        {
            keyValues[key] = -1;
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}