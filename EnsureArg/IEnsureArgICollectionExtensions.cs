namespace EnsureArg
{
   using System.Collections.Generic;
   using EnsureArg.BclExtensions;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on <see
   /// cref="ICollection&lt;T&gt;" /> values.
   /// </summary>
   public static class IEnsureArgICollectionExtensions
   {
      /// <summary>
      /// Checks whether value contained in the IEnsureArg instance is null or contains no items. If
      /// it is null then an ArgumentNullException will be thrown. If the collection is empty then
      /// an ArgumentException will be thrown.
      /// </summary>
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
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
      /// ensureArg.Value contain no items in the collection.
      /// </exception>
      public static IEnsureArg<ICollection<T>> IsNotNullOrEmpty<T>(
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
