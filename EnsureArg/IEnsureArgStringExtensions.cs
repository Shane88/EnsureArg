namespace EnsureArg
{
   public static class IEnsureArgStringExtensions
   {
      public static IEnsureArg<string> IsNotNullOrEmpty(
         this IEnsureArg<string> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (string.IsNullOrEmpty(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      public static IEnsureArg<string> IsNotNullOrWhiteSpace(
         this IEnsureArg<string> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (string.IsNullOrWhiteSpace(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
