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
            var d = GetInts()[1];
            var nums = GetInts();
            var sums = new long[nums.Length + 1];
            sums[0] = nums[0];
            for (var i = 1; i <= nums.Length; i++)
            {
                sums[i] = sums[i - 1] + nums[i - 1];
            }
            var max = 0L;
            var start = -1;
            for (var i = 0; i <= nums.Length - d; i++)
            {
                var between = sums[i + d] - sums[i];
                if (between < max) continue;
                max = between;
                start = i;
            }
            Console.WriteLine($"{start}~{start + d - 1}");
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
