namespace EnsureArg.BclExtensions
{
   using System;

   /// <summary>
   /// Provides extension methods for <see cref="System.IComparable&lt;T&gt;" /> values.
   /// </summary>
   public static class IComparablePrimitiveExtensions
   {  
      #region byte Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>byte a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this byte value, byte min, byte max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>byte a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this byte value, byte min, byte max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this byte value, byte other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this byte value, byte other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this byte value, byte other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this byte value, byte other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion byte Methods
      
      #region sbyte Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>sbyte a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(false)]
      public static bool IsBetween(this sbyte value, sbyte min, sbyte max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>sbyte a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(false)]
      public static bool IsBetweenOrEqualTo(this sbyte value, sbyte min, sbyte max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThan(this sbyte value, sbyte other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThanOrEqualTo(this sbyte value, sbyte other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThan(this sbyte value, sbyte other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThanOrEqualTo(this sbyte value, sbyte other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion sbyte Methods
      
      #region short Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>short a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this short value, short min, short max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>short a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this short value, short min, short max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this short value, short other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this short value, short other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this short value, short other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this short value, short other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion short Methods
      
      #region ushort Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>ushort a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(false)]
      public static bool IsBetween(this ushort value, ushort min, ushort max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>ushort a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(false)]
      public static bool IsBetweenOrEqualTo(this ushort value, ushort min, ushort max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThan(this ushort value, ushort other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThanOrEqualTo(this ushort value, ushort other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThan(this ushort value, ushort other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThanOrEqualTo(this ushort value, ushort other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion ushort Methods
      
      #region int Methods

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
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this int value, int min, int max)
      {
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
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this int value, int min, int max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this int value, int other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this int value, int other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this int value, int other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this int value, int other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion int Methods
      
      #region uint Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>uint a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(false)]
      public static bool IsBetween(this uint value, uint min, uint max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>uint a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(false)]
      public static bool IsBetweenOrEqualTo(this uint value, uint min, uint max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThan(this uint value, uint other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThanOrEqualTo(this uint value, uint other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThan(this uint value, uint other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThanOrEqualTo(this uint value, uint other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion uint Methods
      
      #region long Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>long a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this long value, long min, long max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>long a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this long value, long min, long max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this long value, long other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this long value, long other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this long value, long other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this long value, long other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion long Methods
      
      #region ulong Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>ulong a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(false)]
      public static bool IsBetween(this ulong value, ulong min, ulong max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>ulong a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(false)]
      public static bool IsBetweenOrEqualTo(this ulong value, ulong min, ulong max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThan(this ulong value, ulong other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsGreaterThanOrEqualTo(this ulong value, ulong other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThan(this ulong value, ulong other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsLessThanOrEqualTo(this ulong value, ulong other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion ulong Methods
      
      #region float Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>float a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this float value, float min, float max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>float a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this float value, float min, float max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this float value, float other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this float value, float other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this float value, float other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this float value, float other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion float Methods
      
      #region double Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>double a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this double value, double min, double max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>double a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this double value, double min, double max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this double value, double other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this double value, double other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this double value, double other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this double value, double other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion double Methods
      
      #region decimal Methods

      /// <summary>
      /// Determines whether the value is between the specified min and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>decimal a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max.</returns>
      [CLSCompliant(true)]
      public static bool IsBetween(this decimal value, decimal min, decimal max)
      {
         return value.CompareTo(min) > 0 && value.CompareTo(max) < 0;
      }

      /// <summary>
      /// Determines whether the value is between the specified min and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>decimal a = 2;</para>
      /// <para>a.IsBetween(1, 3); // returns true.</para>
      /// <para>a.IsBetween(2, 3); // return false.</para>
      /// <para>a.IsBetween(1, 2); // returns false.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 3); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(2, 3); // return true.</para>
      /// <para>a.IsBetweenOrEqualTo(1, 2); // returns true.</para>
      /// <para>a.IsBetweenOrEqualTo(3, 4); // returns false.</para>
      /// </example>
      /// <param name="value">The value to test.</param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <returns>True if value was between min and max inclusively.</returns>
      [CLSCompliant(true)]
      public static bool IsBetweenOrEqualTo(this decimal value, decimal min, decimal max)
      {
         return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
      }

      /// <summary>
      /// Determines whether the value is greater than the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThan(this decimal value, decimal other)
      {
         return value.CompareTo(other) > 0;
      }

      /// <summary>
      /// Determines whether the value is greater than or equal to the specified other value.
      /// </summary>      
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was greater than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsGreaterThanOrEqualTo(this decimal value, decimal other)
      {
         return value.CompareTo(other) >= 0;
      }

      /// <summary>
      /// Determines whether the value is less than to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThan(this decimal value, decimal other)
      {
         return value.CompareTo(other) < 0;
      }

      /// <summary>
      /// Determines whether the value is less than or equal to the specified other value.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <param name="other">The value to compare against.</param>
      /// <returns>True if value was less than or equal to other; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsLessThanOrEqualTo(this decimal value, decimal other)
      {
         return value.CompareTo(other) <= 0;
      }

      #endregion decimal Methods
        
   }
}
