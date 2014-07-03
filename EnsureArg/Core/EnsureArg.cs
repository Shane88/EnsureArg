namespace EnsureArg.Core
{
   /// <summary>
   /// Encapsulates values required to perform guard clause validation and throw suitably
   /// constructed exceptions.
   /// </summary>
   /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
   internal sealed class EnsureArg<T> : IEnsureArg<T>
   {
      // TODO: Make class internal.

      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      public EnsureArg(T value)
         : this(value, string.Empty, null)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value and name.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      public EnsureArg(T value, string name)
         : this(value, name, null)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value, name, and exception message.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      /// <param name="exceptionMessage">
      /// The message to use when throwing and exception after a guard condition has failed.
      /// </param>
      public EnsureArg(T value, string name, string exceptionMessage)
      {
         this.Value = value;
         this.ArgumentName = name;
         this.ExceptionMessage = exceptionMessage;
      }

      /// <summary>
      /// Gets the exception message that will be used if an exception is thrown.
      /// </summary>
      public string ExceptionMessage { get; private set; }

      /// <summary>
      /// Gets the argument name that this IEnsureArg instance represents. This will be used
      /// to provide more information in exception messages where possible.
      /// </summary>
      public string ArgumentName { get; private set; }

      /// <summary>
      /// Gets the value this IEnsureArg instance represents. This is the value guard clause
      /// methods will use when evaluating their guard conditions.
      /// </summary>
      public T Value { get; private set; }
   }
}
