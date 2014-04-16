namespace EnsureArg
{
   public static class IEnsureArgObjectExtensions
   {
      public static IEnsureArg<T> IsNotNull<T>(this IEnsureArg<T> ensureArg) where T : class
      {
         return ensureArg.IsNotNull(null);
      }

      public static IEnsureArg<T> IsNotNull<T>(this IEnsureArg<T> ensureArg, string exceptionMessage) where T : class
      {
         if (ensureArg.Value == null)
         {
            ensureArg.ThrowArgumentNullException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
