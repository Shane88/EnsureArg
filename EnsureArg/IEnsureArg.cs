namespace EnsureArg
{
   public interface IEnsureArg<T>
   {
      string ExceptionMessage { get; set; }

      string ArgumentName { get; set; }

      T Value { get; set; }
   }
}
