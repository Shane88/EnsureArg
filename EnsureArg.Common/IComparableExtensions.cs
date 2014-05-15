namespace EnsureArg.Common
{
   using System;

   public static class IComparableExtensions
   {
      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
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
