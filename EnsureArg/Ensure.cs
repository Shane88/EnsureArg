namespace EnsureArg
{
   // TODO: Examples.

   /// <summary>
   /// Static class which provides factories for creating new <see cref="IEnsureArg&lt;T&gt;" />
   /// instance which can be used to perform guard clause checks using extension methods via a
   /// fluent API.
   /// </summary>
   public static class Ensure
   {
      /// <summary>
      /// Returns a new instance of the <see cref="IEnsureArg&lt;T&gt;" /> class with the specified
      /// value, name, exception message and formatting arguments.
      /// </summary>
      /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <returns>A new <see cref="IEnsureArg&lt;T&gt;" /> instance.</returns>
      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value)
      {
         return new EnsureArg<T>(value);
      }

      /// <summary>
      /// Returns a new instance of the <see cref="IEnsureArg&lt;T&gt;" /> class with the specified
      /// value, name, exception message and formatting arguments.
      /// </summary>
      /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      /// <returns>A new <see cref="IEnsureArg&lt;T&gt;" /> instance.</returns>
      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name)
      {
         return new EnsureArg<T>(value, name);
      }

      /// <summary>
      /// Returns a new instance of the <see cref="IEnsureArg&lt;T&gt;" /> class with the specified
      /// value, name, exception message and formatting arguments.
      /// </summary>
      /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      /// <param name="exceptionMessage">
      /// The message to use when throwing and exception after a guard condition has failed.
      /// </param>
      /// <returns>A new <see cref="IEnsureArg&lt;T&gt;" /> instance.</returns>
      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name, string exceptionMessage)
      {
         return new EnsureArg<T>(value, name, exceptionMessage);
      }

      /// <summary>
      /// Returns a new instance of the <see cref="IEnsureArg&lt;T&gt;" /> class with the specified
      /// value, name, exception message and formatting arguments.
      /// </summary>
      /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      /// <param name="exceptionMessage">
      /// The message to use when throwing and exception after a guard condition has failed.
      /// </param>
      /// <param name="formatArgs">The formatting arguments to apply to the exception message.</param>
      /// <returns>A new <see cref="IEnsureArg&lt;T&gt;" /> instance.</returns>
      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name, string exceptionMessage, params object[] formatArgs)
      {
         return new EnsureArg<T>(value, name, exceptionMessage, formatArgs);
      }
   }
}
