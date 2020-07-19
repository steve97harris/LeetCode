using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Main
{
    public class Twitter
    {
        private Dictionary<int, IList<int>> userNewsFeeds;        // {userId, userNewsFeed}       
        private List<int>[] followers; 
        public Twitter()
        {
            userNewsFeeds = new Dictionary<int, IList<int>>();
            followers = new List<int>[1000];
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)        // userNewsFeed - IList<int> where int is tweetId
        {
            if (userNewsFeeds.ContainsKey(userId))
            {
                userNewsFeeds[userId].Add(tweetId);
            }
            else
            {
                userNewsFeeds.Add(userId, new List<int>() { tweetId });
            }

            if (followers[userId] != null)
            {
                for (int i = 0; i < followers[userId].Count; i++)
                {
                    userNewsFeeds[followers[userId][i]].Add(tweetId);
                }
            }
        }

        // private void PostToUserFollowers(int userId, int tweetId)
        // {
        //     foreach (var pair in usersFollowers.Where(pair => pair.Key == userId))
        //     {
        //         for (int i = 0; i < pair.Value.Count; i++)        // for all usersFollowers 
        //         {
        //             var follower = pair.Value[i];
        //             userNewsFeeds[follower].Add(tweetId);
        //         }
        //     }
        // }
        
        /** Retrieve the 10 most recent tweet ids in the user's news feed.
        Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            var last10 = new List<int>();
            if (!userNewsFeeds.ContainsKey(userId)) return last10;
            last10 = userNewsFeeds[userId].TakeLast(10).ToList();
            last10.Reverse();

            Console.WriteLine("Last10: ");
            foreach (var i in last10)
            {
                Console.WriteLine(i);
            }
            return last10;

        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            if (followerId == followeeId)
                return;
            
            if (!userNewsFeeds.ContainsKey(followeeId))
            {
                userNewsFeeds.Add(followeeId, new List<int>());
            }

            if (!userNewsFeeds.ContainsKey(followerId))
            {
                userNewsFeeds.Add(followerId, new List<int>());
            }
            
            for (int i = 0; i < userNewsFeeds[followeeId].Count; i++)
            {
                if (!userNewsFeeds[followerId].Contains(userNewsFeeds[followeeId][i]))
                    userNewsFeeds[followerId].Add(userNewsFeeds[followeeId][i]);
            }
            
            if (followers[followeeId] != null)
                followers[followeeId].Add(followerId);
            else
                followers[followeeId] = new List<int>() {followerId};
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if (!userNewsFeeds.ContainsKey(followeeId))
            {
                userNewsFeeds.Add(followeeId, new List<int>());
            }

            if (!userNewsFeeds.ContainsKey(followerId))
            {
                userNewsFeeds.Add(followerId, new List<int>());
            }
            
            for (int i = 0; i < userNewsFeeds[followeeId].Count; i++)
            {
                userNewsFeeds[followerId].Remove(userNewsFeeds[followeeId][i]);
            }

            if (followers[followeeId] != null)
                followers[followeeId].Remove(followerId);
        }

        public void DisplayAllUserNewsFeeds()
        {
            foreach (var pair in userNewsFeeds)
            {
                Console.WriteLine("UserId: " + pair.Key);
                Console.WriteLine("NewsFeed: ");
                foreach (var i in pair.Value)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("----");
            }
        }
    }
}