namespace Practice
{
    using System;

    public static class Leet_191_NumberOf1Bits
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nNumber of bit");

            Util.Print("1", 1, Solution(1));
            Util.Print("4294967293: 11111111111111111111111111111101", 31, Solution(4294967293));
        }

        public static int Solution(uint n)
        {
            if (n == 0) return 0;
            uint c = 1; // check bit
            int r = 0; // result
            
            while (c <= n && c > 0) {
                if ((c & n) != 0) r++;
                c = c << 1;
            }
            
            return r;
        }
    }
}