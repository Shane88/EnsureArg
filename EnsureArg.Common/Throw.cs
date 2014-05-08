namespace EnsureArg.Common
{
   using System;

   internal static class Throw
   {
      public static void IfNull(object value, string parameterName)
      {
         if (value == null)
         {
            throw new ArgumentNullException(parameterName);
         }
      }
   }
}
