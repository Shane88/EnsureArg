namespace EnsureArg
{
   /// <summary>
   /// Provides methods which are designed to give a fluent syntax to the EnsureArg library.
   /// Typically these methods do nothing but provide a more English like API.
   /// </summary>
   public static class IEnsureArgFluentExtensions
   {
      /// <summary>
      /// Allows a more English like fluent API for chaining multiple IEnsureArg extension methods
      /// together. This method does nothing but return the passed in IEnsureArg instance.
      /// </summary>
      /// <typeparam name="T">The type of the value contained in the IEnsureArg instance.</typeparam>
      /// <param name="ensureArg">
      /// The IEnsureArg instance, usually created from an Ensure.Arg() call.
      /// </param>
      /// <returns>The ensureArg instance.</returns>
      public static IEnsureArg<T> And<T>(this IEnsureArg<T> ensureArg)
      {
         return ensureArg;
      }
   }
}
