namespace EnsureArg.Common
{
   using System;
   using System.Collections.Generic;

   public static class ICollectionExtensions
   {
      public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
      {
         return collection == null || collection.Count <= 0;
      }

      public static bool IsNotNullOrEmpty<T>(this ICollection<T> collection)
      {
         return collection != null && collection.Count > 0;
      }
   }
}
