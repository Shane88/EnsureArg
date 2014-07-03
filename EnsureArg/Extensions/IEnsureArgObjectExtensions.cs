namespace EnsureArg
{
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on objects.
   /// </summary>
   public static class IEnsureArgObjectExtensions
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
      public static IEnsureArg<T> IsNotNull<T>(this IEnsureArg<T> ensureArg, string exceptionMessage = null)
         where T : class
      {
         // TODO: With this type constrained to a class it cannot be called from an unconstrained type context.
         ensureArg.ValidateEnsureArgIsNotNull();

         if (ensureArg.Value == null)
         {
            ensureArg.ThrowArgumentNullException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
