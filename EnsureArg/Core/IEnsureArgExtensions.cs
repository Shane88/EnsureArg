namespace EnsureArg.Core
{
   using System;
   using System.ComponentModel;
   using System.Globalization;
   using SmartFormat;

   /// <summary>
   /// Provides helper methods for classes which define custom guard clause methods by creating
   /// IEnsureArg extension methods.
   /// </summary>
   public static class IEnsureArgExtensions
   {
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

      /// <summary>
      /// Gets a formatted exception message for the specified IEnsureArg instance. If an exception
      /// message is supplied it will be used, if not ensureArg.ExceptionMessage will be used.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to get the exception message for.</param>
      /// <param name="exceptionMessage">The message to use or null to use ensureArg.ExceptionMessage.</param>
      /// <returns>The formatted exception message.</returns>
      public static string GetExceptionMessage<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         string message = exceptionMessage ?? ensureArg.ExceptionMessage;

         if (message != null)
         {
            // TODO: What other useful values could we provide to the error message formatter here?
            SmartFormatter formatter = Smart.CreateDefaultSmartFormat();
            message = formatter.Format(CultureInfo.InvariantCulture, message, new { ArgName = ensureArg.ArgumentName, arg = ensureArg.Value });
         }

         return message;
      }

      /// <summary>
      /// Throws a System.ArgumentException with the specified message. The parameter name for the
      /// exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowArgumentException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentException(ensureArg.GetExceptionMessage(exceptionMessage), ensureArg.ArgumentName);
      }

      /// <summary>
      /// Throws a System.ArgumentNullException with the specified message. The parameter name for
      /// the exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowArgumentNullException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentNullException(ensureArg.ArgumentName, ensureArg.GetExceptionMessage(exceptionMessage));
      }

      /// <summary>
      /// Throws a System.ArgumentOutOfRangeException with the specified message. The parameter name
      /// for the exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, string exceptionMessage)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         throw new ArgumentOutOfRangeException(ensureArg.ArgumentName, ensureArg.Value, ensureArg.GetExceptionMessage(exceptionMessage));
      }

      /// <summary>
      /// Throws a System.ComponentModel.InvalidEnumArgumentException with the specified message.
      /// The parameter name for the exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="TEnum">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowInvalidEnumArgumentException<TEnum>(
         this IEnsureArg<TEnum> ensureArg,
         string exceptionMessage)
         where TEnum : struct, IComparable, IFormattable // Closest we can get to System.Enum and be CLSCompliant.
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         string message = ensureArg.GetExceptionMessage(exceptionMessage);

         if (message == null)
         {
            int enumValue = Convert.ToInt32(ensureArg.Value, CultureInfo.InvariantCulture);
            throw new InvalidEnumArgumentException(ensureArg.ArgumentName, enumValue, ensureArg.Value.GetType());
         }

         throw new InvalidEnumArgumentException(message);
      }
   }
}
