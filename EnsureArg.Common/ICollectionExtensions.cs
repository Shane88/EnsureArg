namespace EnsureArg.Common
{
   using System;
   using System.Collections.Generic;

   public static class ICollectionExtensions
   {
      public static bool IsEmpty<T>(this ICollection<T> collection)
      {
         return collection.Count <= 0;
      }

      public static bool IsNotEmpty<T>(this ICollection<T> collection)
      {
         return collection.Count > 0;
      }
   }
}
