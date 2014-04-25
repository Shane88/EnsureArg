namespace EnsureArg
{
   using System.Collections;
   using System.Collections.Generic;

   public static class IEnsureArgCollectionExtensions
   {
      public static IEnsureArg<ICollection<T>> HasItems<T>(
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

      public static IEnsureArg<ICollection> HasItems(
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

      public static IEnsureArg<T[]> HasItems<T>(
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
