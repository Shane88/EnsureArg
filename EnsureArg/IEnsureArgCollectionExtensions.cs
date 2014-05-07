﻿namespace EnsureArg
{
   using System.Collections.Generic;
   using EnsureArg.Common;

   public static class IEnsureArgCollectionExtensions
   {
      public static IEnsureArg<ICollection<T>> IsNotEmpty<T>(
         this IEnsureArg<ICollection<T>> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (ensureArg.Value.IsNullOrEmpty())
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
