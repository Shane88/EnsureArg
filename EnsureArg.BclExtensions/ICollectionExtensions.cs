namespace EnsureArg.BclExtensions
{
   using System.Collections.Generic;

   public static class ICollectionExtensions
   {
      /// <summary>
      /// Indicates whether the specified collection is null or contains no items.
      /// </summary>
      /// <typeparam name="T">The type parameter for the collection.</typeparam>
      /// <param name="collection">The collection to test.</param>
      /// <returns>
      /// True if the collection parameter is null or an empty collection; otherwise, false.
      /// </returns>
      public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
      {
         return collection == null || collection.Count <= 0;
      }

      /// <summary>
      /// Indicates whether the specified collection is not null and contains at least one item.
      /// </summary>
      /// <typeparam name="T">The type parameter for the collection.</typeparam>
      /// <param name="collection">The collection to test.</param>
      /// <returns>True if the collection contains at least one parameter; otherwise, false.</returns>
      public static bool IsNotNullOrEmpty<T>(this ICollection<T> collection)
      {
         return collection != null && collection.Count > 0;
      }
   }
}
