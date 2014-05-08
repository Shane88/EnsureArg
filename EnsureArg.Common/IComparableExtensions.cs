namespace EnsureArg.Common
{
   using System;

   public static class IComparableExtensions
   {
      public static bool IsBetween<T>(this IComparable<T> value, T min, T max)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(min, "min");
         Throw.IfNull(max, "max");
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      public static bool IsBetweenOrEqualTo<T>(this IComparable<T> value, T min, T max)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(min, "min");
         Throw.IfNull(max, "max");
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      public static bool IsGreaterThan<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) > 0;
      }

      public static bool IsGreaterThanOrEqualTo<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) >= 0;
      }

      public static bool IsLessThan<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) < 0;
      }

      public static bool IsLessThanOrEqualTo<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) <= 0;
      }
   }
}
