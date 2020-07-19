using System;

namespace LeetCode.Main
{
    public class ComplexMultiplication
    {
        public string ComplexNumberMultiply(string a, string b)
        {
            var arrA = a.Split('+');
            var arrB = b.Split('+');

            var a0 = ReturnInt(arrA[0]);
            var b0 = ReturnInt(arrB[0]);

            arrA[1] = RemoveI(arrA[1]);
            arrB[1] = RemoveI(arrB[1]);
            var a1 = ReturnInt(arrA[1]);
            var b1 = ReturnInt(arrB[1]);

            var result = Helper(a0, a1, b0, b1);
            Console.WriteLine(result);

            return a;
        }

        private string Helper(int x, int y, int m, int n)
        {
            var a = (x * m) - (y * n);
            var b = (x * n) + (m * y);
            
            var res = a + "+" + b + "i";
            return res;
        }

        private int ReturnInt(string str)
        {
            int.TryParse(str, out var result);
            return result;
        }

        private string RemoveI(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'i')
                    s = s.Remove(i, 1);
            }
            return s;
        }
    }
}