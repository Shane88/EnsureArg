namespace EnsureArg
{
   using System;
   using System.Collections.Generic;

   public static class IEnsureArgCollectionExtensions
   {
      public static IEnsureArg<ICollection<T>> HasItems<T>(IEnsureArg<ICollection<T>> ensureArg)
      {
         return ensureArg.HasItems(null);
      }

      public static IEnsureArg<ICollection<T>> HasItems<T>(this IEnsureArg<ICollection<T>> ensureArg, string exceptionMessage)
      {
         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
