namespace EnsureArg
{
   using System.Collections;
   using System.Collections.Generic;

   public static class IEnsureArgEnumerableExtensions
   {
      public static IEnsureArg<IEnumerable<T>> HasItems<T>(IEnsureArg<IEnumerable<T>> ensureArg)
      {
         return ensureArg.HasItems(null);
      }

      public static IEnsureArg<IEnumerable<T>> HasItems<T>(this IEnsureArg<IEnumerable<T>> ensureArg, string exceptionMessage)
      {
         if (ensureArg.Value == null)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         ICollection<T> genericCollection = ensureArg.Value as ICollection<T>;

         if (genericCollection != null && genericCollection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         ICollection collection = ensureArg.Value as ICollection;

         if (collection != null && collection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         bool hasItems = false;
         foreach (var item in ensureArg.Value)
         {
            hasItems = true;
            break;
         }

         if (!hasItems)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
