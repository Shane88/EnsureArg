namespace EnsureArg
{
   using System;

   public static class IEnsureArgExtensions
   {
      public static IEnsureArg<T> And<T>(this IEnsureArg<T> ensureArg)
      {
         return ensureArg;
      }

      public static string GetExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         return exceptionMessage ?? ensureArg.ExceptionMessage;
      }

      public static void ThrowArgumentException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         throw new ArgumentException(ensureArg.GetExceptionMessage(exceptionMessage), ensureArg.ArgumentName);
      }

      public static void ThrowArgumentNullException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         throw new ArgumentNullException(ensureArg.ArgumentName, ensureArg.GetExceptionMessage(exceptionMessage));
      }
   }
}
