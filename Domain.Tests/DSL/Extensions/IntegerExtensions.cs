using System;

namespace Domain.Tests.DSL.Extensions
{
    public static class DateConstructionExtensions
    {
        public static DateTime May(this int day, int year) => new DateTime(year, 5, day);
    }
}
