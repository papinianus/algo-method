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

            var total = Enumerable.Range(1,30).Aggregate(
                new TimeSpan(0, 0, 0),
                (a, c) => {
                    var t = GetInts();
                    var workTime = new DateTime(2022, 4, c, t[2], t[3], 0) - new DateTime(2022, 4, c, t[0], t[1], 0);
                    var rest = new TimeSpan(0, 0, 0);
                    if(workTime.TotalHours > 6) rest += new TimeSpan(0, 45, 0);
                    if(workTime.TotalHours > 8) rest += new TimeSpan(0, 15, 0);
                    return a += workTime - rest;
                    });
            Console.WriteLine($"{total.Days * 24 + total.Hours} {total.Minutes}");
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
        public static double GetDouble() => double.Parse(Read());
        public static double[] GetDoubles() => Read().Split(Separator).Select(double.Parse).ToArray();

        public static T ident<T>(T val) => val;
    }
}