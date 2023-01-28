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
            var N = GetInts()[0];
            var menus = Enumerable.Range(1, N).Select(_=>{
                var input = GetStrings();
                return new {Name = input[0], Price = int.Parse(input[1])};
            }).ToDictionary(x => x.Name, x => x.Price);
            GetStrings().Aggregate(0, (a,c) => a + menus[c]).Echo();
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
    }
}