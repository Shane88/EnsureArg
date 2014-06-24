namespace EnsureArg
{
   using System.Collections.Generic;

   /// <summary>
   /// Defines an interface which guard clause methods can use to validate a value and throw a
   /// suitably constructed exception.
   /// </summary>
   /// <typeparam name="T">The type which the IEnsureArg instance will represent.</typeparam>
   public interface IEnsureArg<out T>
   {
      /// <summary>
      /// Gets the exception message that will be used if an exception is thrown.
      /// </summary>
      string ExceptionMessage { get; }

      /// <summary>
      /// Gets the argument name that this IEnsureArg instance represents. This will be used to
      /// provide more information in exception messages where possible.
      /// </summary>
      string ArgumentName { get; }

      /// <summary>
      /// Gets the value this IEnsureArg instance represents. This is the value guard clause methods
      /// will use when evaluating their guard conditions.
      /// </summary>
      T Value { get; }
   }
}
