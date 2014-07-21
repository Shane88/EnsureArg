namespace EnsureArg.Core
{
   using System.Globalization;
   using SmartFormat;

   public static class IEnsureArgFormatExtensions
   {
      private static SmartFormatter formatter;

      static IEnsureArgFormatExtensions()
      {
         formatter = Smart.CreateDefaultSmartFormat();
      }

      public static string FormatArgumentNullExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         return ensureArg.FormatArgumentExceptionMessage(exceptionMessage);
      }

      public static string FormatArgumentExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(CultureInfo.InvariantCulture, message, new { ArgName = ensureArg.ArgumentName, arg = ensureArg.Value });
         }

         return null;
      }

      public static string FormatInvalidEnumArgumentException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(CultureInfo.InvariantCulture, message, new { ArgName = ensureArg.ArgumentName, arg = ensureArg.Value, enumType = typeof(T) });
         }

         return null;
      }

      public static string FormatArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, T min, T max, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {            
            return formatter.Format(CultureInfo.InvariantCulture, message, new { ArgName = ensureArg.ArgumentName, arg = ensureArg.Value, min = min, max = max });
         }

         return null;
      }

      public static string FormatArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, T other)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(CultureInfo.InvariantCulture, message, new { ArgName = ensureArg.ArgumentName, arg = ensureArg.Value, other = other });
         }

         return null;
      }
   }
}
