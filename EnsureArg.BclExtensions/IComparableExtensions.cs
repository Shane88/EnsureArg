namespace EnsureArg.BclExtensions
{
   using System;
   using EnsureArg.BclExtensions.Core;

   /// <summary>
   /// Provides extension methods for <see cref="System.IComparable&lt;T&gt;" /> values.
   /// </summary>
   public static class IComparableExtensions
   {
      // TODO: Add DateTime overloads?

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>int a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
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

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>int a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      public static bool IsBetweenOrEqualTo<T>(this IComparable<T> value, T min, T max)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(min, "min");
         Throw.IfNull(max, "max");
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      public static bool IsGreaterThan<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      public static bool IsGreaterThanOrEqualTo<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      public static bool IsLessThan<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <typeparam name="T">The type of the IComparable.</typeparam>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      public static bool IsLessThanOrEqualTo<T>(this IComparable<T> value, T other)
      {
         Throw.IfNull(value, "value");
         Throw.IfNull(other, "other");
         return value.CompareTo(other) <= 0;
      }
   }
}
