﻿namespace EnsureArg.Core
{
   using System;
   using System.ComponentModel;
   using System.Globalization;

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
         throw new ArgumentException(ensureArg.FormatArgumentExceptionMessage(exceptionMessage), ensureArg.ArgumentName);
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
         throw new ArgumentNullException(ensureArg.ArgumentName, ensureArg.FormatArgumentNullExceptionMessage(exceptionMessage));
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
         string message = ensureArg.FormatInvalidEnumArgumentException(exceptionMessage);

         if (message == null)
         {
            int enumValue = Convert.ToInt32(ensureArg.Value, CultureInfo.InvariantCulture);
            throw new InvalidEnumArgumentException(ensureArg.ArgumentName, enumValue, ensureArg.Value.GetType());
         }

         throw new InvalidEnumArgumentException(message);
      }

      /// <summary>
      /// Throws a System.ArgumentOutOfRangeException with the specified message. The parameter name
      /// for the exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="min">The minimum value ensureArg.Value was outside to cause this error to be thrown.</param>
      /// <param name="max">The maximum value ensureArg.Value was outside to cause this error to be thrown.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, T min, T max, string exceptionMessage = null)
      {
         string message = ensureArg.FormatArgumentOutOfRangeException(min, max, exceptionMessage);
         throw new ArgumentOutOfRangeException(ensureArg.ArgumentName, ensureArg.Value, message);
      }

      /// <summary>
      /// Throws a System.ArgumentOutOfRangeException with the specified message. The parameter name
      /// for the exception will be the value of ensureArg.ArgumentName.
      /// </summary>
      /// <typeparam name="T">The type parameter of the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">The IEnsureArg instance to throw an exception for.</param>
      /// <param name="other">Some other bounds that ensureArg.Value did not satisfy to cause this error to be thrown.</param>
      /// <param name="exceptionMessage">
      /// The message to use in the exception. If no exception message is supplied then
      /// ensureArg.ExceptionMessage will be used.
      /// </param>
      public static void ThrowArgumentOutOfRangeException<T>(this IEnsureArg<T> ensureArg, T other, string exceptionMessage = null)
      {
         string message = ensureArg.FormatArgumentOutOfRangeException(other, exceptionMessage);
         throw new ArgumentOutOfRangeException(ensureArg.ArgumentName, ensureArg.Value, message);
      }
   }
}
