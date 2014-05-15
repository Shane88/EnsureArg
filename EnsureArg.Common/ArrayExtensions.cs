namespace EnsureArg.Common
{
   public static class ArrayExtensions
   {
      /// <summary>
      /// Indicates whether the specified array is null or contains no items.
      /// </summary>
      /// <typeparam name="T">The type parameter for the array.</typeparam>
      /// <param name="array">The array to test.</param>
      /// <returns>True if the array parameter is null or an empty array; otherwise, false.</returns>
      public static bool IsNullOrEmpty<T>(this T[] array)
      {
         return array == null || array.Length <= 0;
      }

      /// <summary>
      /// Indicates whether the specified array is not null and contains at least one item.
      /// </summary>
      /// <typeparam name="T">The type parameter for the array.</typeparam>
      /// <param name="array">The array to test.</param>
      /// <returns>True if the array contains at least one parameter; otherwise, false.</returns>
      public static bool IsNotNullOrEmpty<T>(this T[] array)
      {
         return array != null && array.Length > 0;
      }
   }
}
