namespace EnsureArg
{
   using System;
   using EnsureArg.Common;

   public static class IEnsureArgIComparableExtensions
   {
      public static IEnsureArg<T> IsLessThan<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsLessThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T> IsLessThanOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsLessThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T> IsGreaterThan<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsGreaterThan(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T> IsGreaterThanOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T other,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsGreaterThanOrEqualTo(other))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T> IsBetween<T>(
         this IEnsureArg<T> ensureArg,
         T min,
         T max,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsBetween(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T> IsBetweenOrEqualTo<T>(
         this IEnsureArg<T> ensureArg,
         T min,
         T max,
         string exceptionMessage = null,
         params object[] formatArgs) where T : IComparable<T>
      {
         if (!ensureArg.Value.IsBetweenOrEqualTo(min, max))
         {
            ensureArg.ThrowArgumentOutOfRangeException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
