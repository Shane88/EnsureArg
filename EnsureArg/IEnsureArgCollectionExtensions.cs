namespace EnsureArg
{
   using System.Collections.Generic;

   public static class IEnsureArgCollectionExtensions
   {
      public static IEnsureArg<ICollection<T>> HasItems<T>(
         this IEnsureArg<ICollection<T>> ensureArg, 
         string exceptionMessage = null, 
         params object[] formatArgs)
      {
         if (ensureArg.Value.Count <= 0)
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
