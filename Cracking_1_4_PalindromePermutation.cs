namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_1_4_PalindromePermutation
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nPalindrome Permutaiton");
            Util.Print("Tact Coa", true, Solution("Tact Coa"));
            Util.Print("Tact Co", false, Solution("Tact Co"));
            Util.Print("Ta ct  Coa", true, Solution("Ta ct  Coa"));
            Util.Print("bb", true, Solution("bb"));
            Util.Print("ab", false, Solution("ab"));
            Util.Print("null", false, Solution(null));
            Util.Print("one char", false, Solution("a"));
        }

        public static bool Solution(string s)
        {
            if (s == null || s.Trim().Length < 2) return false;

            s = s.ToLower();
            int len = 0;
            int odd = 0;
            var count = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (c == ' ') continue;
                len++;
                if (!count.ContainsKey(c)) count[c] = 0;
                if (count[c] % 2 == 0) odd++; else odd--;
                count[c] = count[c] + 1;
            }

            return (len % 2 == 0 && odd == 0) || (len % 2 == 1 && odd == 1);
        }
    }
}