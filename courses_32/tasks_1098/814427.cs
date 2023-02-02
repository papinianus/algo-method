using System;
using System.Collections.Generic;
using System.Linq;
using static template.UtilIo;

namespace template
{

    public static class Program
    {
        public static void Main(string[] args) => Solver.Solve();
    }

    public static class Solver
    {
        public static void Solve()
        {
            var nm = GetInts();
            var state = new { Ice = nm[0], Bar = 0 };
            var consumed = 0;
            do
            {
                consumed += state.Ice;
                state = new { Ice = 0, Bar = state.Bar + state.Ice };
                if (state.Bar >= nm[1])
                {
                    state = new { Ice = state.Bar / nm[1], Bar = state.Bar % nm[1] };
                }
            } while (state.Ice > 0);
            consumed.Echo();
        }
    }

    public static class UtilIo
    {
        private static string Read() => Console.ReadLine();
        private const char Separator = ' ';

        public static void Echo(this string val) => Console.WriteLine(val);
        public static void Echo(this int val) => Console.WriteLine(val);
        public static void Echo(this long val) => Console.WriteLine(val);
        public static void Echo(this char val) => Console.WriteLine(val);
        private static void Tell(this bool val, string truly = "Yes", string falsy = "No")
        {
            if (val)
            {
                Console.WriteLine(truly);
                return;
            }
            Console.WriteLine(falsy);
        }
        public static void YesNo(this bool val) => val.Tell("Yes", "No");

        public static string GetString() => Read();
        public static string[] GetStrings() => Read().Split(Separator);
        public static string[] GetStringMultiple(int rowCount)
        {
            var results = new List<string>();
            while (rowCount > 0)
            {
                results.Add(GetString());
                rowCount--;
            }
            return results.ToArray();
        }
        public static int GetInt() => int.Parse(Read());
        public static int[] GetInts() => Read().Split(Separator).Select(int.Parse).ToArray();
        public static long GetLong() => long.Parse(Read());
        public static long[] GetLongs() => Read().Split(Separator).Select(long.Parse).ToArray();
        public static double GetDouble() => double.Parse(Read());
        public static double[] GetDoubles() => Read().Split(Separator).Select(double.Parse).ToArray();

        public static T ident<T>(T val) => val;

        public static int Gcd(int a, int b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}