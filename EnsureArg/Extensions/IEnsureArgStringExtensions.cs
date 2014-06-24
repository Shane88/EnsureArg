namespace EnsureArg
{
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on strings.
   /// </summary>
   public static class IEnsureArgStringExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not null or an
      /// System.String.Empty string. If it is null then an ArgumentNullException will be thrown. If
      /// the string is empty then an ArgumentException will be thrown.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <param name="formatArgs">Option exception message formatting arguments.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is an empty string ("").</exception>
      public static IEnsureArg<string> IsNotNullOrEmpty(
         this IEnsureArg<string> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (string.IsNullOrEmpty(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not null, empty, or
      /// consists only of white-space characters. If it is null then an ArgumentNullException will
      /// be thrown. If the string is empty or contains only white-space characters then an
      /// ArgumentException will be thrown.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <param name="formatArgs">Option exception message formatting arguments.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">
      /// ensureArg.Value is an empty string ("") or only contains white-space characters.
      /// </exception>
      public static IEnsureArg<string> IsNotNullOrWhiteSpace(
         this IEnsureArg<string> ensureArg,
         string exceptionMessage = null,
         params object[] formatArgs)
      {
         ensureArg.IsNotNull(exceptionMessage, formatArgs);

         if (string.IsNullOrWhiteSpace(ensureArg.Value))
         {
            ensureArg.ThrowArgumentException(exceptionMessage, formatArgs);
         }

         return ensureArg;
      }
   }
}
