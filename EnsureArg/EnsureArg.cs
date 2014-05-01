namespace EnsureArg
{
   public class EnsureArg<T> : IEnsureArg<T>
   {
      public EnsureArg(T value)
         : this(value, string.Empty, null, null)
      {
      }

      public EnsureArg(T value, string name)
         : this(value, name, null, null)
      {
      }

      public EnsureArg(T value, string name, string exceptionMessage)
         : this(value, name, exceptionMessage, null)
      {
      }

      public EnsureArg(T value, string name, string exceptionMessage, params object[] formatArgs)
      {
         this.Value = value;
         this.ArgumentName = name;
         this.ExceptionMessage = exceptionMessage;
         this.ExceptionMessageFormatArgs = formatArgs;
      }

      public string ExceptionMessage { get; set; }

      public string ArgumentName { get; set; }

      public object[] ExceptionMessageFormatArgs { get; set; }

      public T Value { get; set; }
   }
}
