using System;
using System.Reflection;

namespace Cms20LinqOchAnnat
{
    public static class Extensions
    {
        public static int GetLastDateOfMonth(this DateTime dt)
        {
            var d = new DateTime(dt.Year,dt.Month,1)
                .AddMonths(1)
                .AddDays(-1);
            return d.Day;
        }

        public static string NextPosition(this Random rnd)
        {
            var positions = new[] { "Goalie", "Defence", "Forward" };
            return positions[rnd.Next(0, positions.Length)];
        }
    }
}