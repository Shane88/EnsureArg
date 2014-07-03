namespace EnsureArg.BclExtensions
{
   using System;

   /// <summary>
   /// Provides extension methods for <see cref="System.IDisposable" /> values.
   /// </summary>
   public static class IDisposableExtensions
   {
      /// <summary>
      /// Disposes the current instance if it is not null. If the current instance is null
      /// nothing will happen.
      /// </summary>
      /// <param name="disposable">The disposable instance to dispose.</param>
      public static void DisposeIfNotNull(this IDisposable disposable)
      {
         if (disposable != null)
         {
            disposable.Dispose();
         }
      }
   }
}
