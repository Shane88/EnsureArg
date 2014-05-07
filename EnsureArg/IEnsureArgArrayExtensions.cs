namespace EnsureArg
{
   using EnsureArg.Common;

   public static class IEnsureArgArrayExtensions
   {
      public static IEnsureArg<T[]> IsNotEmpty<T>(
         this IEnsureArg<T[]> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.IsNullOrEmpty())
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
