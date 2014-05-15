namespace EnsureArg.Common
{
   using System;

   /// <summary>
   /// Helper class to reduce the boiler plate code of validating public arguments.
   /// </summary>
   internal static class Throw
   {
      /// <summary>
      /// Throws an ArgumentNullException if value is null.
      /// </summary>
      /// <param name="value">The value to check for null.</param>
      /// <param name="parameterName">The parameter name of the value.</param>
      public static void IfNull<T>(T value, string parameterName)
      {
         if (value == null)
         {
            throw new ArgumentNullException(parameterName);
         }
      }
   }
}
