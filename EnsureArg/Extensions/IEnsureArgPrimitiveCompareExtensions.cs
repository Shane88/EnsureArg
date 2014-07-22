namespace EnsureArg
{
   using System;
   using EnsureArg.BclExtensions;
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on <see
   /// cref="IComparable&lt;T&gt;" /> values.
   /// </summary>
   public static class IEnsureArgPrimitiveCompareExtensions
   {
      // TODO: DateTime overloads have examples which don't compile.  
   
      #region byte Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>byte a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsBetween(
         this IEnsureArg<byte> ensureArg,
         byte min,
         byte max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>byte a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsBetweenOrEqualTo(
         this IEnsureArg<byte> ensureArg,
         byte min,
         byte max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsGreaterThan(
         this IEnsureArg<byte> ensureArg,
         byte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsGreaterThanOrEqualTo(
         this IEnsureArg<byte> ensureArg,
         byte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsLessThan(
         this IEnsureArg<byte> ensureArg,
         byte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsLessThanOrEqualTo(
         this IEnsureArg<byte> ensureArg,
         byte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion byte Methods 
      
      #region sbyte Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>sbyte a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsBetween(
         this IEnsureArg<sbyte> ensureArg,
         sbyte min,
         sbyte max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>sbyte a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsBetweenOrEqualTo(
         this IEnsureArg<sbyte> ensureArg,
         sbyte min,
         sbyte max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsGreaterThan(
         this IEnsureArg<sbyte> ensureArg,
         sbyte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsGreaterThanOrEqualTo(
         this IEnsureArg<sbyte> ensureArg,
         sbyte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsLessThan(
         this IEnsureArg<sbyte> ensureArg,
         sbyte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsLessThanOrEqualTo(
         this IEnsureArg<sbyte> ensureArg,
         sbyte other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion sbyte Methods 
      
      #region short Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>short a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsBetween(
         this IEnsureArg<short> ensureArg,
         short min,
         short max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>short a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsBetweenOrEqualTo(
         this IEnsureArg<short> ensureArg,
         short min,
         short max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsGreaterThan(
         this IEnsureArg<short> ensureArg,
         short other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsGreaterThanOrEqualTo(
         this IEnsureArg<short> ensureArg,
         short other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsLessThan(
         this IEnsureArg<short> ensureArg,
         short other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsLessThanOrEqualTo(
         this IEnsureArg<short> ensureArg,
         short other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion short Methods 
      
      #region ushort Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>ushort a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsBetween(
         this IEnsureArg<ushort> ensureArg,
         ushort min,
         ushort max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>ushort a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsBetweenOrEqualTo(
         this IEnsureArg<ushort> ensureArg,
         ushort min,
         ushort max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsGreaterThan(
         this IEnsureArg<ushort> ensureArg,
         ushort other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsGreaterThanOrEqualTo(
         this IEnsureArg<ushort> ensureArg,
         ushort other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsLessThan(
         this IEnsureArg<ushort> ensureArg,
         ushort other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsLessThanOrEqualTo(
         this IEnsureArg<ushort> ensureArg,
         ushort other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion ushort Methods 
      
      #region int Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>int a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsBetween(
         this IEnsureArg<int> ensureArg,
         int min,
         int max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>int a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsBetweenOrEqualTo(
         this IEnsureArg<int> ensureArg,
         int min,
         int max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsGreaterThan(
         this IEnsureArg<int> ensureArg,
         int other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsGreaterThanOrEqualTo(
         this IEnsureArg<int> ensureArg,
         int other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsLessThan(
         this IEnsureArg<int> ensureArg,
         int other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsLessThanOrEqualTo(
         this IEnsureArg<int> ensureArg,
         int other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion int Methods 
      
      #region uint Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>uint a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsBetween(
         this IEnsureArg<uint> ensureArg,
         uint min,
         uint max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>uint a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsBetweenOrEqualTo(
         this IEnsureArg<uint> ensureArg,
         uint min,
         uint max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsGreaterThan(
         this IEnsureArg<uint> ensureArg,
         uint other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsGreaterThanOrEqualTo(
         this IEnsureArg<uint> ensureArg,
         uint other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsLessThan(
         this IEnsureArg<uint> ensureArg,
         uint other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsLessThanOrEqualTo(
         this IEnsureArg<uint> ensureArg,
         uint other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion uint Methods 
      
      #region long Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>long a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsBetween(
         this IEnsureArg<long> ensureArg,
         long min,
         long max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>long a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsBetweenOrEqualTo(
         this IEnsureArg<long> ensureArg,
         long min,
         long max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsGreaterThan(
         this IEnsureArg<long> ensureArg,
         long other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsGreaterThanOrEqualTo(
         this IEnsureArg<long> ensureArg,
         long other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsLessThan(
         this IEnsureArg<long> ensureArg,
         long other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsLessThanOrEqualTo(
         this IEnsureArg<long> ensureArg,
         long other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion long Methods 
      
      #region ulong Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>ulong a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsBetween(
         this IEnsureArg<ulong> ensureArg,
         ulong min,
         ulong max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>ulong a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsBetweenOrEqualTo(
         this IEnsureArg<ulong> ensureArg,
         ulong min,
         ulong max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsGreaterThan(
         this IEnsureArg<ulong> ensureArg,
         ulong other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsGreaterThanOrEqualTo(
         this IEnsureArg<ulong> ensureArg,
         ulong other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsLessThan(
         this IEnsureArg<ulong> ensureArg,
         ulong other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsLessThanOrEqualTo(
         this IEnsureArg<ulong> ensureArg,
         ulong other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion ulong Methods 
      
      #region float Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>float a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsBetween(
         this IEnsureArg<float> ensureArg,
         float min,
         float max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>float a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsBetweenOrEqualTo(
         this IEnsureArg<float> ensureArg,
         float min,
         float max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsGreaterThan(
         this IEnsureArg<float> ensureArg,
         float other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsGreaterThanOrEqualTo(
         this IEnsureArg<float> ensureArg,
         float other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsLessThan(
         this IEnsureArg<float> ensureArg,
         float other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsLessThanOrEqualTo(
         this IEnsureArg<float> ensureArg,
         float other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion float Methods 
      
      #region double Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>double a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsBetween(
         this IEnsureArg<double> ensureArg,
         double min,
         double max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>double a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsBetweenOrEqualTo(
         this IEnsureArg<double> ensureArg,
         double min,
         double max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsGreaterThan(
         this IEnsureArg<double> ensureArg,
         double other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsGreaterThanOrEqualTo(
         this IEnsureArg<double> ensureArg,
         double other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsLessThan(
         this IEnsureArg<double> ensureArg,
         double other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsLessThanOrEqualTo(
         this IEnsureArg<double> ensureArg,
         double other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion double Methods 
      
      #region decimal Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>decimal a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsBetween(
         this IEnsureArg<decimal> ensureArg,
         decimal min,
         decimal max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>decimal a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsBetweenOrEqualTo(
         this IEnsureArg<decimal> ensureArg,
         decimal min,
         decimal max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsGreaterThan(
         this IEnsureArg<decimal> ensureArg,
         decimal other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsGreaterThanOrEqualTo(
         this IEnsureArg<decimal> ensureArg,
         decimal other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsLessThan(
         this IEnsureArg<decimal> ensureArg,
         decimal other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsLessThanOrEqualTo(
         this IEnsureArg<decimal> ensureArg,
         decimal other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion decimal Methods 
      
      #region DateTime Methods

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values exclusively.
      /// </summary>
      /// <example>
      /// <para>DateTime a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsBetween(
         this IEnsureArg<DateTime> ensureArg,
         DateTime min,
         DateTime max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is between the specified min
      /// and max values inclusively.
      /// </summary>
      /// <example>
      /// <para>DateTime a = 2;</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetween(2, 3); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetween(1, 2); // Throws ArgumentOutOfRangeException.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(2, 3); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(1, 2); // Doesn't throw.</para>
      /// <para>Ensure.Arg(a).IsBetweenOrEqualTo(3, 4); // Throws ArgumentOutOfRangeException.</para>
      /// </example>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="min">The minimum value.</param>
      /// <param name="max">The maximum value.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is outside the range of min and max.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsBetweenOrEqualTo(
         this IEnsureArg<DateTime> ensureArg,
         DateTime min,
         DateTime max,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(min, max, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsGreaterThan(
         this IEnsureArg<DateTime> ensureArg,
         DateTime other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is greater than or equal to
      /// the specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is less than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsGreaterThanOrEqualTo(
         this IEnsureArg<DateTime> ensureArg,
         DateTime other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than or equal to other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsLessThan(
         this IEnsureArg<DateTime> ensureArg,
         DateTime other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is less than or equal to the
      /// specified other value.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="other">The value to compare against.</param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is greater than other.
      /// </exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsLessThanOrEqualTo(
         this IEnsureArg<DateTime> ensureArg,
         DateTime other,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }

      #endregion DateTime Methods 
        
   }
}
