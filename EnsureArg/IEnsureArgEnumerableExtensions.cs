namespace EnsureArg
{
   using System.Collections;
   using System.Collections.Generic;

   public static class IEnsureArgEnumerableExtensions
   {
      public static IEnsureArg<IEnumerable<T>> HasItems<T>(
         this IEnsureArg<IEnumerable<T>> ensureArg,
         string exceptionMessage = null,
         params object[] args)
      {
         if (ensureArg.Value == null)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         ICollection<T> genericCollection = ensureArg.Value as ICollection<T>;

         if (genericCollection != null && genericCollection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         ICollection collection = ensureArg.Value as ICollection;

         if (collection != null && collection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         bool hasItems = false;
         foreach (var item in ensureArg.Value)
         {
            hasItems = true;
            break;
         }

         if (!hasItems)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         return ensureArg;
      }
   }
}
