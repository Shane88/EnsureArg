namespace EnsureArg
{
   using System.Collections;
   using System.Collections.Generic;

   public static class IEnsureArgCollectionExtensions
   {
      public static IEnsureArg<List<T>> IsNotEmpty<T>(
         this IEnsureArg<List<T>> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<IList<T>> IsNotEmpty<T>(
         this IEnsureArg<IList<T>> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<ICollection<T>> IsNotEmpty<T>(
         this IEnsureArg<ICollection<T>> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<ICollection> IsNotEmpty(
         this IEnsureArg<ICollection> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<T[]> IsNotEmpty<T>(
         this IEnsureArg<T[]> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.Length == 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
