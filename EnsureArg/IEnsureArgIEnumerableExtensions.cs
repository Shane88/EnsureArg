namespace EnsureArg
{
   using System.Collections;
   using System.Collections.Generic;

   public static class IEnsureArgIEnumerableExtensions
   {
      public static IEnsureArg<IEnumerable<T>> IsNotEmpty<T>(
         this IEnsureArg<IEnumerable<T>> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         ICollection<T> genericCollection = ensureArg.Value as ICollection<T>;

         if (genericCollection != null && genericCollection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         ICollection collection = ensureArg.Value as ICollection;

         if (collection != null && collection.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         using (IEnumerator<T> enumerator = ensureArg.Value.GetEnumerator())
         {
            if (!enumerator.MoveNext())
            {
               ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
            }
         }

         return ensureArg;
      }
   }
}
