namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_1_2_IsPermutation
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nIsPermutation:");
            Util.Print("null s1", false, Solution(null, "hi"));
            Util.Print("null s2", false, Solution("hi", null));
            Util.Print("null s1, s2", false, Solution(null, null));
            Util.Print("different lengths", false, Solution("hi", "hello"));
            Util.Print("same", true, Solution("hello", "hello"));
            Util.Print("permutation", true, Solution("hello", "ohlel"));
            Util.Print("different", false, Solution("hello", "hella"));
        }

        public static bool Solution(string s1, string s2)
        {
            if (s1 == null || s1.Trim().Length == 0) return false;
            if (s2 == null || s2.Trim().Length == 0) return false;
            if (s1.Length != s2.Length) return false;

            var c1 = CountChars(s1);
            var c2 = CountChars(s2);

            if (c1.Keys.Count != c2.Keys.Count) return false;

            foreach (var kvp in c1)
            {
                if (!c2.ContainsKey(kvp.Key)) return false;
                if (kvp.Value != c2[kvp.Key]) return false;
            }

            return true;
        }

        public static Dictionary<char, int> CountChars(string s)
        {
            var count = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (!count.ContainsKey(c)) count[c] = 0;
                count[c] = count[c] + 1;
            }

            return count;
        }
    }
}