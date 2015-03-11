namespace EnsureArg.BclExtensions
{
   using System;

   /// <summary>
   /// Provides extension methods for primitive values.
   /// </summary>
   public static class PrimitiveExtensions
   {
      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Byte" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this byte value)
      {
         return value == default(byte);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Byte" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this byte value)
      {
         return value != default(byte);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.SByte" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsDefaultValue(this sbyte value)
      {
         return value == default(sbyte);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.SByte" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsNotDefaultValue(this sbyte value)
      {
         return value != default(sbyte);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Int16" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this short value)
      {
         return value == default(short);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Int16" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this short value)
      {
         return value != default(short);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.UInt16" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsDefaultValue(this ushort value)
      {
         return value == default(ushort);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.UInt16" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsNotDefaultValue(this ushort value)
      {
         return value != default(ushort);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Int32" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this int value)
      {
         return value == default(int);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Int32" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this int value)
      {
         return value != default(int);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.UInt32" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsDefaultValue(this uint value)
      {
         return value == default(uint);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.UInt32" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsNotDefaultValue(this uint value)
      {
         return value != default(uint);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Int64" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this long value)
      {
         return value == default(long);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Int64" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this long value)
      {
         return value != default(long);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.UInt64" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsDefaultValue(this ulong value)
      {
         return value == default(ulong);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.UInt64" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(false)]
      public static bool IsNotDefaultValue(this ulong value)
      {
         return value != default(ulong);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Single" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this float value)
      {
         return value == default(float);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Single" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this float value)
      {
         return value != default(float);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Double" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this double value)
      {
         return value == default(double);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Double" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this double value)
      {
         return value != default(double);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Decimal" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this decimal value)
      {
         return value == default(decimal);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Decimal" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this decimal value)
      {
         return value != default(decimal);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.DateTime" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this DateTime value)
      {
         return value == default(DateTime);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.DateTime" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this DateTime value)
      {
         return value != default(DateTime);
      }

      /// <summary>
      /// Determines whether the value is equal to the default value of the <see cref="System.Guid" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsDefaultValue(this Guid value)
      {
         return value == default(Guid);
      }

      /// <summary>
      /// Determines whether the value is not equal to the default value of the <see cref="System.Guid" /> type.
      /// </summary>
      /// <param name="value">The value to test.</param>
      /// <returns>True if value is not equal to the default value; otherwise false.</returns>
      [CLSCompliant(true)]
      public static bool IsNotDefaultValue(this Guid value)
      {
         return value != default(Guid);
      }
   }
}
