namespace EnsureArg
{
   using System;
   using System.ComponentModel;
   using System.Globalization;
   using SmartFormat;

   public static class IEnsureArgExtensions
   {
      public static IEnsureArg<T> And<T>(this IEnsureArg<T> ensureArg)
      {
         return ensureArg;
      }

      public static string GetExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         string message = null;
         object[] args = null;

         if (exceptionMessage != null)
         {
            message = exceptionMessage;
            args = formatArgs;
         }
         else if (ensureArg.ExceptionMessage != null)
         {
            message = ensureArg.ExceptionMessage;
            args = ensureArg.ExceptionMessageFormatArgs;
         }

         if (message != null)
         {
            message = Smart.Format(CultureInfo.InvariantCulture, message, new { ParamName = ensureArg.ArgumentName, arg = ensureArg.Value });

            message = Smart.Format(CultureInfo.InvariantCulture, message, args ?? new object[] { });
         }

         return message;
      }

      public static void ThrowArgumentException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         throw new ArgumentException(ensureArg.GetExceptionMessage(exceptionMessage, formatArgs), ensureArg.ArgumentName);
      }

      public static void ThrowArgumentNullException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         throw new ArgumentNullException(ensureArg.ArgumentName, ensureArg.GetExceptionMessage(exceptionMessage, formatArgs));
      }

      public static void ThrowInvalidEnumArgumentException<TEnum>(
         this IEnsureArg<TEnum> ensureArg,
         string exceptionMessage,
         params object[] formatArgs)
         where TEnum : struct, IComparable, IFormattable // Closest we can get to System.Enum and be CLSCompliant.
      {
         string message = ensureArg.GetExceptionMessage(exceptionMessage, formatArgs);

         if (message == null)
         {
            int enumValue = Convert.ToInt32(ensureArg.Value, CultureInfo.InvariantCulture);
            throw new InvalidEnumArgumentException(ensureArg.ArgumentName, enumValue, ensureArg.Value.GetType());
         }

         throw new InvalidEnumArgumentException(message);
      }
   }
}
