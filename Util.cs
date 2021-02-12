namespace Practice
{
    using System;

    public static class Util
    {
        public static void Print<T1,T2>(string testName, T1 expected, T2 actual)
        {            
            var success = (expected == null && actual == null) || expected.Equals(actual) ? "😁" : "🤬";
            string expectedOut = expected != null ? expected.ToString() : "🚫";
            string actualOut = actual != null ? actual.ToString() : "🚫";
            Console.Out.WriteLine($"{success} {testName}: ⌜{expectedOut}⌟ ⌜{actualOut}⌟");
        }
    }
}