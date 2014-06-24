namespace EnsureArg
{
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on Nullable types.
   /// </summary>
   public static class IEnsureArgNullableExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not null. If it is null
      /// then an ArgumentNullException will be thrown.
      /// </summary>
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the null check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      public static IEnsureArg<T?> IsNotNull<T>(this IEnsureArg<T?> ensureArg, string exceptionMessage = null)
         where T : struct
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.HasValue)
         {
            ensureArg.ThrowArgumentNullException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
