namespace EnsureArg
{
   public static class Ensure
   {
      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value)
      {
         return new EnsureArg<T>(value);
      }

      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name)
      {
         return new EnsureArg<T>(value, name);
      }

      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name, string exceptionMessage)
      {
         return new EnsureArg<T>(value, name, exceptionMessage);
      }

      public static IEnsureArg<T> Arg<T>([ValidatedNotNull] T value, string name, string exceptionMessage, params object[] formatArgs)
      {
         return new EnsureArg<T>(value, name, exceptionMessage, formatArgs);
      }
   }
}
