using System;
using System.Linq;

namespace LeetCode.Main.Solutions
{
    public class VersionControl
    {
        public int FirstBadVersion(int n)
        {
            var start = 1;
            var end = n;
            var mid = 0;

            while (start <= end)
            {
                mid = (start + end) / 2;

                if (IsBadVersion(mid))
                {
                    if (!IsBadVersion(mid - 1))
                        return mid;
                    end = mid - 1;
                }
                else
                    start = mid + 1;
            }
            return mid;
        }

        private bool IsBadVersion(int version)
        {
            return version >= 4;
        }
    }
}