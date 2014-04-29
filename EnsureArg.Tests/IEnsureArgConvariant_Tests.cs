namespace EnsureArg.Tests
{
   using System;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgConvariant_Tests
   {
      [TestMethod]
      public void When_a_derived_class_is_used_it_can_access_base_IEnsureArg_extension_methods()
      {
         // Arrange.
         MyConvariantTestDerivedClass derived = new MyConvariantTestDerivedClass();

         // Act.
         Action action = () =>
            Ensure.Arg(derived, "derived").HasValidBaseProperty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }
   }

   public class MyConvariantTestBaseClass
   {
      public string BaseProperty { get; set; }
   }

   public class MyConvariantTestDerivedClass : MyConvariantTestBaseClass
   {
      public string DerivedProperty { get; set; }
   }

   public static class MyConvariantTestBaseClassExtensions
   {
      public static IEnsureArg<MyConvariantTestBaseClass> HasValidBaseProperty(this IEnsureArg<MyConvariantTestBaseClass> ensureArg)
      {
         if (ensureArg.Value.BaseProperty != "BaseProperty")
         {
            throw new ArgumentException();
         }

         return ensureArg;
      }
   }
}
