using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public static class DestinationCity
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            var destination = "";
            var allDestinations = new Dictionary<string, int>();
            for (int i = 0; i < paths.Count; i++)
            {
                for (int j = 0; j < paths[i].Count; j++)
                {
                    if (allDestinations.ContainsKey(paths[i][j]))
                        allDestinations[paths[i][j]] += 1;
                    else
                        allDestinations.Add(paths[i][j], 1);
                }
            }

            foreach (var pair in allDestinations.Where(pair => pair.Value == 1)
                .Where(pair => paths.Any(t => t.IndexOf(pair.Key) == 1)))
            {
                destination = pair.Key;
            }

            return destination;
        }
    }
}