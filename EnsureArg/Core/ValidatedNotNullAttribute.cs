namespace EnsureArg.Core
{
   using System;

   /// <summary>
   /// Used on method parameters to inform code analysis that the parameter has been validated as a
   /// non null value when it can't infer it.
   /// </summary>
   [AttributeUsage(AttributeTargets.Parameter)]
   internal sealed class ValidatedNotNullAttribute : Attribute
   {
   }
}
