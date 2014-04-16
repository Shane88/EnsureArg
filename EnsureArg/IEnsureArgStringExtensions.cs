namespace EnsureArg
{
   public static class IEnsureArgStringExtensions
   {
      public static IEnsureArg<string> IsNotNullOrEmpty(this IEnsureArg<string> ensureArg)
      {
         return ensureArg.IsNotNullOrEmpty(null);
      }

      public static IEnsureArg<string> IsNotNullOrEmpty(this IEnsureArg<string> ensureArg, string exceptionMessage)
      {
         if (string.IsNullOrEmpty(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      public static IEnsureArg<string> IsNotNullOrWhiteSpace(this IEnsureArg<string> ensureArg)
      {
         return ensureArg.IsNotNullOrWhiteSpace(null);
      }

      public static IEnsureArg<string> IsNotNullOrWhiteSpace(this IEnsureArg<string> ensureArg, string exceptionMessage)
      {
         if (string.IsNullOrWhiteSpace(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
