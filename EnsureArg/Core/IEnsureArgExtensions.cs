namespace EnsureArg.Core
{
   using System;
   using System.ComponentModel;
   using System.Globalization;
   using SmartFormat;

   public static class IEnsureArgExtensions
   {
      /// <summary>
      /// Allows a more English like fluent API for chaining multiple IEnsureArg extension methods
      /// together. This method does nothing but return the passed in IEnsureArg instance.
      /// </summary>
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      public static IEnsureArg<T> And<T>(this IEnsureArg<T> ensureArg)
      {
         return ensureArg;
      }

      /// <summary>
      /// Validates that the IEnsureArg instance is not null.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to check.</param>
      public static void ValidateEnsureArgIsNotNull<T>(this IEnsureArg<T> ensureArg)
      {
         if (ensureArg == null)
         {
            throw new ArgumentNullException("ensureArg");
         }
      }

      public static string GetExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

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
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentException(ensureArg.GetExceptionMessage(exceptionMessage, formatArgs), ensureArg.ArgumentName);
      }

      public static void ThrowArgumentNullException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentNullException(ensureArg.ArgumentName, ensureArg.GetExceptionMessage(exceptionMessage, formatArgs));
      }

      public static void ThrowArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage, params object[] formatArgs)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentOutOfRangeException(ensureArg.ArgumentName, ensureArg.Value, ensureArg.GetExceptionMessage(exceptionMessage, formatArgs));
      }

      public static void ThrowInvalidEnumArgumentException<TEnum>(
         this IEnsureArg<TEnum> ensureArg,
         string exceptionMessage,
         params object[] formatArgs)
         where TEnum : struct, IComparable, IFormattable // Closest we can get to System.Enum and be CLSCompliant.
      {
         ensureArg.ValidateEnsureArgIsNotNull();
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
