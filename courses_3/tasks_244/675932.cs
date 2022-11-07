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
            var k = GetInts()[1];
            var nums = GetInts();
            Enumerable.Range(0, nums.Length).SelectMany(x => Enumerable.Range(1, nums.Length - 1).Select(y => new[] { x, y })).Where(x => x[1] > x[0]).Count(x => nums[x[0]] + nums[x[1]] <= k).Echo();
        }
    }

    public static class UtilIo
    {
        private static string Read() => Console.ReadLine();
        private const char Separator = ' ';

        public static void Echo(this string val) => Console.WriteLine(val);
        public static void Echo(this int val) => Console.WriteLine(val);
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

        public static T ident<T>(T val) => val;
    }
}
