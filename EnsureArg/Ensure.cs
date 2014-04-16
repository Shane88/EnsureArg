namespace EnsureArg
{
   public static class Ensure
   {
      public static IEnsureArg<T> Arg<T>(T value)
      {
         return new EnsureArg<T>(value);
      }

      public static IEnsureArg<T> Arg<T>(T value, string name)
      {
         return new EnsureArg<T>(value, name);
      }

      public static IEnsureArg<T> Arg<T>(T value, string name, string exceptionMessage)
      {
         return new EnsureArg<T>(value, name, exceptionMessage);
      }
   }
}
