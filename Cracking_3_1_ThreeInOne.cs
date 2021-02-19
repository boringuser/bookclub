namespace Practice
{
    using System;
    using System.Collections.Generic;

    public static class Cracking_3_1_ThreeInOne
    {
        public static void Go()
        {
            Console.Out.WriteLine("\nThree In One");

            var tio = new ThreeStacks();
            
            for (int i = 0; i < 15; i++)
            {
                tio.Push(i % 3, i);
            }

            for (int i = 14; i >= 0; i--)
            {
                Util.Print("Three In One " + i, i, tio.Pop(i % 3));
            }
        }


    }
}