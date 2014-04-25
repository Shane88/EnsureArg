namespace EnsureArg
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;

   public static class IEnsureArgEnumExtensions
   {
      public static IEnsureArg<Enum> IsValidEnumValue(IEnsureArg<Enum> ensureArg, string exceptionMessage = null, params object[] formatArgs)
      {
         Type enumType = ensureArg.Value.GetType();

         if (!Enum.IsDefined(enumType, ensureArg.Value))
         {
            ensureArg.ThrowInvalidEnumArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
