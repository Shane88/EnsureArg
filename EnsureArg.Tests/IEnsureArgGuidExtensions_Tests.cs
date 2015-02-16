namespace EnsureArg.Tests
{
   using System;
   using EnsureArg;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgGuidExtensions_Tests
   {
      [TestMethod]
      public void When_EnsureArg_IsNotEmptyGuid_is_called_with_a_non_empty_value()
      {
         // Arrange.
         Guid value = Guid.NewGuid();

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotEmptyGuid();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsNotEmptyGuid_is_called_with_an_empty_value()
      {
         // Arrange.
         Guid value = Guid.Empty;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotEmptyGuid();

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }
   }
}
