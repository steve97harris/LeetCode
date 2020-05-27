namespace LeetCode.Main
{
    public class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n == 0)
                return false;

            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }
    }
}