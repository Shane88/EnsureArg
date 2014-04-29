namespace EnsureArg
{
   public interface IEnsureArg<out T>
   {
      string ExceptionMessage { get; }

      string ArgumentName { get; }

      object[] ExceptionMessageFormatArgs { get; }

      T Value { get; }
   }
}
