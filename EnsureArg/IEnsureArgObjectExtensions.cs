namespace EnsureArg
{
   public static class IEnsureArgObjectExtensions
   {
      public static IEnsureArg<T> IsNotNull<T>(this IEnsureArg<T> ensureArg, string exceptionMessage = null, params object[] args)
         where T : class
      {
         if (ensureArg.Value == null)
         {
            ensureArg.ThrowArgumentNullException(exceptionMessage, args);
         }

         return ensureArg;
      }
   }
}
