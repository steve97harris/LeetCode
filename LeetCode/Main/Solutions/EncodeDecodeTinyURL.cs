using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Main.Solutions
{
    public class Codec
    {
        Dictionary<int,string> shortUrlWithID = new Dictionary<int, string>();
        Dictionary<int,string> longUrlWithID = new Dictionary<int, string>();
        public string Encode(string longUrl)
        {
            var id = URLtoID(longUrl);
            var shortUrl = IDToShortURL(id);
            shortUrlWithID.Add(id,shortUrl);
            longUrlWithID.Add(id,longUrl);
            
            return shortUrl;
        }

        public string Decode(string shortUrl)
        {
            if (!shortUrlWithID.ContainsValue(shortUrl)) return "";
            var id = 0;
            foreach (var pair in shortUrlWithID.Where(pair => pair.Value == shortUrl))
            {
                id = pair.Key;
            }

            return longUrlWithID.ContainsKey(id) ? longUrlWithID[id] : "";
        }
        
        private string IDToShortURL(int n)
        {  
            var map = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToArray();  
      
            StringBuilder shorturl = new StringBuilder();  
      
            while (n > 0)  
            {  
                shorturl.Append(map[n % 62]); 
                n = n / 62;  
            }  
      
            var reverseShortUrlArray = shorturl.ToString().Reverse().ToArray();
            var result = string.Join("", reverseShortUrlArray);
            return result;  
        }  
      
        private int URLtoID(string url)  
        {  
            int id = 0; 

            for (int i = 0; i < url.Length; i++)  
            {  
                if ('a' <= url[i] &&  
                    url[i] <= 'z')  
                    id = id * 62 + url[i] - 'a';  
                if ('A' <= url[i] &&  
                    url[i] <= 'Z')  
                    id = id * 62 + url[i] - 'A' + 26;  
                if ('0' <= url[i] &&  
                    url[i] <= '9')  
                    id = id * 62 + url[i] - '0' + 52;  
            }  
            return id;  
        } 
    }
}