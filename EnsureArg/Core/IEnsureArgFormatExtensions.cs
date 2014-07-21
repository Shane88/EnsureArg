namespace EnsureArg.Core
{
   using System.Globalization;
   using SmartFormat;

   /// <summary>
   /// Provides helper methods for classes which define custom guard clause methods.
   /// This class contains method used by EnsureArg to format various types of exception messages.
   /// </summary>
   public static class IEnsureArgFormatExtensions
   {
      /// <summary>
      /// Provides formatting capabilities for exception message formatting.
      /// </summary>
      private static SmartFormatter formatter = Smart.CreateDefaultSmartFormat();

      /// <summary>
      /// Creates an exception message appropriate for an ArgumentNullException given the
      /// context of the ensureArg instance.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to format an exception message for.</param>
      /// <param name="exceptionMessage">An exception message to use which may provide place holders.
      /// The available place holders are: {argName} = ensureArg.ArgumentName, {arg} = ensureArg.Value.
      /// If this parameter is null the ensureArg.Exception message will be used.</param>
      /// <returns>A formatted exception message or null if no exception message was found.</returns>
      public static string FormatArgumentNullExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         return ensureArg.FormatArgumentExceptionMessage(exceptionMessage);
      }

      /// <summary>
      /// Creates an exception message appropriate for an ArgumentException given the
      /// context of the ensureArg instance.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to format an exception message for.</param>
      /// <param name="exceptionMessage">An exception message to use which may provide place holders.
      /// The available place holders are: {argName} = ensureArg.ArgumentName, {arg} = ensureArg.Value.
      /// If this parameter is null the ensureArg.Exception message will be used.</param>
      /// <returns>A formatted exception message or null if no exception message was found.</returns>
      public static string FormatArgumentExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(
               CultureInfo.InvariantCulture,
               message,
               new
               {
                  argName = ensureArg.ArgumentName,
                  arg = ensureArg.Value
               });
         }

         return null;
      }

      /// <summary>
      /// Creates an exception message appropriate for an InvalidEnumArgumentException given the
      /// context of the ensureArg instance.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to format an exception message for.</param>
      /// <param name="exceptionMessage">An exception message to use which may provide place holders.
      /// The available place holders are: {argName} = ensureArg.ArgumentName, {arg} = ensureArg.Value, {enumType} = typeof(T).
      /// If this parameter is null the ensureArg.Exception message will be used.</param>
      /// <returns>A formatted exception message or null if no exception message was found.</returns>
      public static string FormatInvalidEnumArgumentException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(
               CultureInfo.InvariantCulture,
               message,
               new
               {
                  argName = ensureArg.ArgumentName,
                  arg = ensureArg.Value,
                  enumType = typeof(T)
               });
         }

         return null;
      }

      /// <summary>
      /// Creates an exception message appropriate for an ArgumentNullException given the
      /// context of the ensureArg instance.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to format an exception message for.</param>
      /// <param name="min">The minimum value ensureArg.Value was outside to cause this error to be thrown.</param>
      /// <param name="max">The maximum value ensureArg.Value was outside to cause this error to be thrown.</param>
      /// <param name="exceptionMessage">An exception message to use which may provide place holders.
      /// The available place holders are: {argName} = ensureArg.ArgumentName, {arg} = ensureArg.Value, {min} = min, {max} = max.
      /// If this parameter is null the ensureArg.Exception message will be used.</param>
      /// <returns>A formatted exception message or null if no exception message was found.</returns>
      public static string FormatArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, T min, T max, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(
               CultureInfo.InvariantCulture,
               message,
               new
               {
                  argName = ensureArg.ArgumentName,
                  arg = ensureArg.Value,
                  min = min,
                  max = max
               });
         }

         return null;
      }

      /// <summary>
      /// Creates an exception message appropriate for an ArgumentNullException given the
      /// context of the ensureArg instance.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to format an exception message for.</param>
      /// <param name="other">Some other bounds that ensureArg.Value did not satisfy to cause this error to be thrown.</param>
      /// <param name="exceptionMessage">An exception message to use which may provide place holders.
      /// The available place holders are: {argName} = ensureArg.ArgumentName, {arg} = ensureArg.Value, {min} = min, {max} = max.
      /// If this parameter is null the ensureArg.Exception message will be used.</param>
      /// <returns>A formatted exception message or null if no exception message was found.</returns>
      public static string FormatArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, T other, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            return formatter.Format(
               CultureInfo.InvariantCulture,
               message,
               new
               {
                  argName = ensureArg.ArgumentName,
                  arg = ensureArg.Value,
                  other = other
               });
         }

         return null;
      }
   }
}
