namespace EnsureArg.BclExtensions
{
   public static class StringExtensions
   {
      /// <summary>
      /// Indicates whether the specified string is null or an System.String.Empty string.
      /// </summary>
      /// <param name="value">The string to test.</param>
      /// <returns>true if the value parameter is null or an empty string (""); otherwise, false.</returns>
      public static bool IsNullOrEmpty(this string value)
      {
         return string.IsNullOrEmpty(value);
      }

      /// <summary>
      /// Indicates whether the specified string is not null or an System.String.Empty string.
      /// </summary>
      /// <param name="value">The string to test.</param>
      /// <returns>
      /// true if the value parameter is not null or an empty string (""); otherwise, false.
      /// </returns>
      public static bool IsNotNullOrEmpty(this string value)
      {
         return !string.IsNullOrEmpty(value);
      }

      /// <summary>
      /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
      /// </summary>
      /// <param name="value">The string to test.</param>
      /// <returns>
      /// true if the value parameter is null or System.String.Empty, or if value consists
      /// exclusively of white-space characters.
      /// </returns>
      public static bool IsNullOrWhiteSpace(this string value)
      {
         return string.IsNullOrWhiteSpace(value);
      }

      /// <summary>
      /// Indicates whether a specified string is not null, empty, or consists only of white-space characters.
      /// </summary>
      /// <param name="value">The string to test.</param>
      /// <returns>
      /// true if the value parameter is not null or System.String.Empty, or if value consists
      /// exclusively of white-space characters.
      /// </returns>
      public static bool IsNotNullOrWhiteSpace(this string value)
      {
         return !string.IsNullOrWhiteSpace(value);
      }
   }
}
