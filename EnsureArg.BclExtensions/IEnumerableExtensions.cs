namespace EnsureArg.BclExtensions
{
   using System.Collections;
   using System.Collections.Generic;

   /// <summary>
   /// Provides extension methods for <see cref="System.Collections.Generic.IEnumerable&lt;T&gt;" /> values.
   /// </summary>
   public static class IEnumerableExtensions
   {
      /// <summary>
      /// Indicates whether the specified collection is null or contains no items.
      /// </summary>
      /// <typeparam name="T">The type parameter for the collection.</typeparam>
      /// <param name="value">The collection to test.</param>
      /// <returns>
      /// True if the collection parameter is null or an empty collection; otherwise, false.
      /// </returns>
      public static bool IsNullOrEmpty<T>(this IEnumerable<T> value)
      {
         if (value == null)
         {
            return true;
         }

         {
            ICollection<T> collection = value as ICollection<T>;

            if (collection != null && collection.Count <= 0)
            {
               return true;
            }
         }

         {
            ICollection collection = value as ICollection;

            if (collection != null && collection.Count <= 0)
            {
               return true;
            }
         }

         using (IEnumerator<T> enumerator = value.GetEnumerator())
         {
            return !enumerator.MoveNext();
         }
      }

      /// <summary>
      /// Indicates whether the specified collection is not null and contains at least one item.
      /// </summary>
      /// <typeparam name="T">The type parameter for the collection.</typeparam>
      /// <param name="value">The collection to test.</param>
      /// <returns>True if the collection contains at least one parameter; otherwise, false.</returns>
      public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> value)
      {
         return !IsNullOrEmpty(value);
      }
   }
}
