namespace EnsureArg
{
   public static class IEnsureArgStringExtensions
   {
      public static IEnsureArg<string> IsNotNullOrEmpty(this IEnsureArg<string> ensureArg, string exceptionMessage = null, params object[] args)
      {
         if (string.IsNullOrEmpty(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         return ensureArg;
      }

      public static IEnsureArg<string> IsNotNullOrWhiteSpace(this IEnsureArg<string> ensureArg, string exceptionMessage = null, params object[] args)
      {
         if (string.IsNullOrWhiteSpace(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, args);
         }

         return ensureArg;
      }
   }
}
