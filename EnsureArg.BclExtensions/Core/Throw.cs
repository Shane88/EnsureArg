namespace EnsureArg.BclExtensions.Core
{
   using System;
   using EnsureArg.Core;

   /// <summary>
   /// Helper class to reduce the boiler plate code of validating public arguments.
   /// </summary>
   internal static class Throw
   {
      /// <summary>
      /// Throws an ArgumentNullException if value is null.
      /// </summary>
      /// <typeparam name="T">The type of the parameter to test.</typeparam>
      /// <param name="value">The value to check for null.</param>
      /// <param name="parameterName">The parameter name of the value.</param>
      public static void IfNull<T>([ValidatedNotNull] T value, string parameterName)
      {
         if (value == null)
         {
            throw new ArgumentNullException(parameterName);
         }
      }
   }
}
