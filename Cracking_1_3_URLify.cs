namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_1_3_URLify
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nURLify");

            var s = "Mr John Smith    ".ToCharArray();
            Solution(s, 13);

            Util.Print("modified", "Mr%20John%20Smith", new String(s));

            s = "".ToCharArray();
            Solution(s, 0);

            Util.Print("empty", "", new String(s));

            s = null;
            Solution(s, 0);
            Util.Print("null", null as string, s);

            s = "  ".ToCharArray();
            Solution(s, 2);
            Util.Print("too short", "  ", new String(s));

            s = "   ".ToCharArray();
            Solution(s, 1);
            Util.Print("one space", "%20", new String(s));

            s = "     ".ToCharArray();
            Solution(s, 10);
            Util.Print("wrong len", "     ", new String(s));
        }

        public static void Solution(char[] s, int len)
        {
            if (s == null || s.Length < 3) return;
            if (len > s.Length) return;

            int c = len - 1;
            int e = s.Length - 1;

            while (c >= 0)
            {
                if (s[c] != ' ')
                {
                    s[e--] = s[c];
                }
                else
                {
                    s[e--] = '0';
                    s[e--] = '2';
                    s[e--] = '%';
                }

                c--;
            }
        }
    }
}