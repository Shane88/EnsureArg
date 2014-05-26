﻿namespace EnsureArg.Core
{
   /// <summary>
   /// Encapsulates values required to perform guard clause validation and throw suitably
   /// constructed exceptions.
   /// </summary>
   /// <typeparam name="T">The type which the EnsureArg instance will represent.</typeparam>
   public class EnsureArg<T> : IEnsureArg<T>
   {
      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      public EnsureArg(T value)
         : this(value, string.Empty, null, null)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value and name.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      public EnsureArg(T value, string name)
         : this(value, name, null, null)
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
         : this(value, name, exceptionMessage, null)
      {
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="EnsureArg&lt;T&gt;" /> class with the
      /// specified value, name, exception message and formatting arguments.
      /// </summary>
      /// <param name="value">The value which will be evaluated in subsequent method calls.</param>
      /// <param name="name">The name of the argument the represents the value.</param>
      /// <param name="exceptionMessage">
      /// The message to use when throwing and exception after a guard condition has failed.
      /// </param>
      /// <param name="formatArgs">The formatting arguments to apply to the exception message.</param>
      public EnsureArg(T value, string name, string exceptionMessage, params object[] formatArgs)
      {
         this.Value = value;
         this.ArgumentName = name;
         this.ExceptionMessage = exceptionMessage;
         this.ExceptionMessageFormatArgs = formatArgs;
      }

      /// <summary>
      /// Gets or sets the exception message that will be used if an exception is thrown.
      /// </summary>
      public string ExceptionMessage { get; set; }

      /// <summary>
      /// Gets or sets the argument name that this IEnsureArg instance represents. This will be used
      /// to provide more information in exception messages where possible.
      /// </summary>
      public string ArgumentName { get; set; }

      /// <summary>
      /// Gets or sets the formatting arguments that can be used in conjunction with the
      /// ExceptionMessage. This will be passed into string.Format along with the exception message.
      /// </summary>
      public object[] ExceptionMessageFormatArgs { get; set; }

      /// <summary>
      /// Gets or sets the value this IEnsureArg instance represents. This is the value guard clause
      /// methods will use when evaluating their guard conditions.
      /// </summary>
      public T Value { get; set; }
   }
}