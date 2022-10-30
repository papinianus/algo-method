using System;
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
            var S = GetString();
            var N = GetInt();
            S.Skip(N - 1).First().Echo();
        }
    }

    public static class UtilIo
    {
        private static string Read() => Console.ReadLine();
        private static char separator = ' ';
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
        public static int GetInt() => int.Parse(Read());
        public static int[] GetInts() => Read().Split(separator).Select(int.Parse).ToArray();
        public static long GetLong() => long.Parse(Read());
        public static long[] GetLongs() => Read().Split(separator).Select(long.Parse).ToArray();
    }
}
