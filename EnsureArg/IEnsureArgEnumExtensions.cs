namespace EnsureArg
{
   using System;
   using System.Diagnostics.CodeAnalysis;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on Enumeration types.
   /// </summary>
   public static class IEnsureArgEnumExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not null and contains a
      /// valid enumeration value for the specified enumeration type.
      /// </summary>
      /// <example>
      /// public enum ValidationType
      /// {
      ///   Default,
      ///   Strict
      /// }
      /// <para>
      /// // Valid C#, validationType is an invalid enum value at this point,
      /// // but it can be used as if it were a valid one.
      /// ValidationType validationType = (ValidationType)123;
      /// </para>
      /// // Will throw InvalidEnumArgumentException.
      /// Ensure.Arg(validationType).IsValidEnumValue();
      /// </example>
      /// <typeparam name="TEnum">
      /// The type of the value contained in the IEnsureArg instance. This should be an Enum type.
      /// </typeparam>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <param name="formatArgs">Option exception message formatting arguments.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly",
         Justification = "Since we cannot constrain a type parameter to System.Enum we must use this workaround. " +
         "The ArgumentException being thrown here is for the type parameter TEnum not being of type System.Enum.")]
      public static IEnsureArg<TEnum> IsValidEnumValue<TEnum>(
         this IEnsureArg<TEnum> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
         where TEnum : struct, IComparable, IFormattable // Closest we can get to System.Enum and be CLSCompliant.
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         Type enumType = ensureArg.Value.GetType();

         if (!enumType.IsEnum)
         {
            throw new ArgumentException("TEnum must be an enumerated type", "TEnum");
         }

         if (!Enum.IsDefined(enumType, ensureArg.Value))
         {
            ensureArg.ThrowInvalidEnumArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
