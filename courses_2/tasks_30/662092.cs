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
            GetInts().OrderBy(x => x % 10).First().ToString().Echo();
            // MinBy >= .net 6
            // GetInts().MinBy(x=>x % 10).ToString().Echo();
        }
    }

    public static class UtilIo
    {
        private static string Read() => Console.ReadLine();
        private static char separator = ' ';
        public static void Echo(this string val) => Console.WriteLine(val);
        public static string GetString() => Read();
        public static int GetInt() => int.Parse(Read());
        public static int[] GetInts() => Read().Split(separator).Select(int.Parse).ToArray();
        public static long GetLong() => long.Parse(Read());
        public static long[] GetLongs() => Read().Split(separator).Select(long.Parse).ToArray();
    }
}
