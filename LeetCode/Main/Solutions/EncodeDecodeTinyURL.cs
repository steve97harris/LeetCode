using System;
using System.Collections.Generic;

namespace LeetCode.Main.Solutions
{
    public static class Codec
    {
        static List<string> tinyURL_IDs = new List<string>();
        static Dictionary<string,string> urlDictionary = new Dictionary<string, string>();        // Keys - longURL, Values - shortURL
        
        public static string Encode(string longURL)
        {
            string shortURL = "";
            string generateID;
            
            generateID = TinyURL_ID(7);
            if (!tinyURL_IDs.Contains(generateID) && longURL.Length > 25)
            {
                tinyURL_IDs.Add(generateID);
                shortURL = "https://tinyurl.com/" + generateID;
                urlDictionary.Add(longURL,shortURL);
            }
            
            Console.WriteLine("shortURL = " + shortURL);

            foreach (KeyValuePair<string,string> xPair in urlDictionary)
            {
                Console.WriteLine(xPair.Key +" "+ xPair.Value);
            }
            return shortURL;
        }

        public static string TinyURL_ID(int n)
        {
            string id;
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var idChars = new char[n];
            var random = new Random();
            for (int i = 0; i < idChars.Length; i++)
            {
                idChars[i] = chars[random.Next(chars.Length)];
            }
            id = new String(idChars);
            return id;
        }

        public static string Decode(string shortURL)
        {
            return "dlfkgj";
        }
    }
}