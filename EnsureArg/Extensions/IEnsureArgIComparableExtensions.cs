namespace EnsureArg
{
   using System;
   using EnsureArg.BclExtensions;
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on <see
   /// cref="IComparable&lt;T&gt;" /> values.
   /// </summary>
   public static class IEnsureArgIComparableExtensions
   {
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsBetween<T>(
         this IEnsureArg<T> ensureArg,
         T min,
         T max,
         string exceptionMessage = null) where T : IComparable<T>
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsBetweenOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T min,
         T max,
         string exceptionMessage = null) where T : IComparable<T>
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsGreaterThan<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null) where T : IComparable<T>
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsGreaterThanOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null) where T : IComparable<T>
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsLessThan<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null) where T : IComparable<T>
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
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      public static IEnsureArg<T> IsLessThanOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null) where T : IComparable<T>
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(other, exceptionMessage);
         }

         return ensureArg;
      }
   }
}
