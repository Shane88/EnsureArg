namespace EnsureArg
{
   using System;
   using System.Diagnostics.CodeAnalysis;

   public static class IEnsureArgEnumExtensions
   {
      [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly",
         Justification = "Since we cannot constrain a type parameter to System.Enum we must use this workaround. " +
         "The ArgumentException being thrown here is for the type parameter TEnum not being of type System.Enum.")]
      public static IEnsureArg<TEnum> IsValidEnumValue<TEnum>(
         this IEnsureArg<TEnum> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
         where TEnum : struct, IComparable, IFormattable // Closest we can get to System.Enum and be CLSCompliant.
      {
         ensureArg.ValidateIsNotNull();

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
