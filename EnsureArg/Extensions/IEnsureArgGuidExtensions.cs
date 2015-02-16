namespace EnsureArg
{
   using System;
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on <see
   /// cref="System.Guid" /> values.
   /// </summary>
   public static class IEnsureArgGuidExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is a non-empty Guid.
      /// </summary>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <param name="exceptionMessage">
      /// Optional exception message to use if the empty check fails. This exception message will
      /// override the message supplied in the Ensure.Arg() call, if any.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg is null.</exception>
      /// <exception cref="System.ArgumentOutOfRangeException">
      /// ensureArg.Value is an empty Guid.
      /// </exception>
      public static IEnsureArg<Guid> IsNotEmptyGuid(
         this IEnsureArg<Guid> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (ensureArg.Value.Equals(Guid.Empty))
         {
            ensureArg.ThrowArgumentOutOfRangeException(Guid.Empty, exceptionMessage);
         }

         return ensureArg;
      }
   }
}
