namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_1_1_IsUnique
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nIsUnique Solution A:");
            Util.Print("A: null", false, SolutionA(null));
            Util.Print("A: whitespace", false, SolutionA("      "));
            Util.Print("A: one char", true, SolutionA("a"));
            Util.Print("A: two char same", false, SolutionA("aa"));
            Util.Print("A: two char different", true, SolutionA("ab"));
            Util.Print("A: repeats", false, SolutionA("a sentence with repeated characters"));
            Util.Print("A: no repeats", true, SolutionA("no duplicates"));

            Console.Out.WriteLine("\nIsUnique Solution B:");
            Util.Print("B: null", false, SolutionB(null));
            Util.Print("B: whitespace", false, SolutionB("      "));
            Util.Print("B: one char", true, SolutionB("a"));
            Util.Print("B: two char same", false, SolutionB("aa"));
            Util.Print("B: two char different", true, SolutionB("ab"));
            Util.Print("B: repeats", false, SolutionB("a sentence with repeated characters"));
            Util.Print("B: no repeats", true, SolutionB("no duplicates"));

        }

        // uses a set to track characters we have seen
        public static bool SolutionA(string s)
        {
            if (s == null || s.Trim().Length == 0) return false;
            if (s.Length == 1) return true;
            
            var seen = new HashSet<char>();

            foreach (char c in s)
            {
                if (seen.Contains(c)) return false;
                seen.Add(c);
            }

            return true;
        }

        // does not use extra data structures
        public static bool SolutionB(string s)
        {
            if (s == null || s.Trim().Length == 0) return false;
            if (s.Length == 1) return true;

            for (int i = 0; i < s.Length - 1; i++)
            {
                var ci = s[i];

                for (int j = i + 1; j < s.Length; j++)
                {
                    var cj = s[j];
                    if (ci == cj) return false;
                }
            }

            return true;
        }
    }
}