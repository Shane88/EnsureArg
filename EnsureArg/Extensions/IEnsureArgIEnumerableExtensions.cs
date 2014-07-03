namespace EnsureArg
{
   using System.Collections.Generic;
   using EnsureArg.BclExtensions;
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on <see
   /// cref="IEnumerable&lt;T&gt;" /> values.
   /// </summary>
   public static class IEnsureArgIEnumerableExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is null or contains no
      /// items. If it is null then an ArgumentNullException will be thrown. If the collection is
      /// empty then an ArgumentException will be thrown.
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
      /// <exception cref="System.ArgumentException">
      /// ensureArg.Value contain no items in the collection.
      /// </exception>
      public static IEnsureArg<IEnumerable<T>> IsNotNullOrEmpty<T>(
         this IEnsureArg<IEnumerable<T>> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.IsNotNull(exceptionMessage);

         if (ensureArg.Value.IsNullOrEmpty())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
