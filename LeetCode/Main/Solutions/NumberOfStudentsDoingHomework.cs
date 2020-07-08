using System.Linq;

namespace LeetCode.Main
{
    public class NumberOfStudentsDoingHomework
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            return startTime.Where((t, i) => t <= queryTime && endTime[i] >= queryTime).Count();
        }
    }
}