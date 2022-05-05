using System;
using System.Collections.Generic;
using System.Linq;

namespace Khonsu.KeyGenerator
{
    public static class KhonsuIdGenerator
    {
        // Combines the scrambled millisecond string & random string with the prefix!
        public static string GenerateId(string prefix)
        {
            var millisInString = _GetTimeString();
            var text = _GetRandomString(8);
            return $"{prefix}-{millisInString}-{text}";
        }
        
        // Creates random string
        private static string _GetRandomString(int length)
        {
            var random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        // Hides a Millisecond string by scrambling it.
        private static string _GetTimeString()
        {
            var translateDict = new Dictionary<char, char>()
            {
                {'0', 'k'},
                {'1', '7'},
                {'2', 'r'},
                {'3', '2'},
                {'4', 't'},
                {'5', 'B'},
                {'6', '4'},
                {'7', 'A'},
                {'8', 'u'},
                {'9', 'Z'}
            };
            var result = "";
            var millisInString = DateTime.Now.ToFileTimeUtc().ToString();
            foreach (var millisChar in millisInString)
            {
                if (translateDict.Keys.Contains(millisChar))
                {
                    result += translateDict[millisChar].ToString();
                }
            }

            return result;
        }
    }
}