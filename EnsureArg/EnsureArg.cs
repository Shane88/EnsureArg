namespace EnsureArg
{
   public class EnsureArg<T> : IEnsureArg<T>
   {
      public EnsureArg()
      {
         this.ArgumentName = string.Empty;
      }

      public EnsureArg(T value)
         : this(value, string.Empty, null)
      {
      }

      public EnsureArg(T value, string name)
         : this(value, name, null)
      {
      }

      public EnsureArg(T value, string name, string exceptionMessage)
      {
         this.Value = value;
         this.ArgumentName = name;
         this.ExceptionMessage = exceptionMessage;
      }

      public string ExceptionMessage { get; set; }

      public string ArgumentName { get; set; }

      public T Value { get; set; }
   }
}
