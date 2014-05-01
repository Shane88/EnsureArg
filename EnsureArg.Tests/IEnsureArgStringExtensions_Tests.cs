namespace EnsureArg.Tests
{
   using System;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgStringExtensions_Tests
   {
      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_null_string()
      {
         // Arrange.
         string value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_empty_string()
      {
         // Arrange.
         string value = "";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_valid_string()
      {
         // Arrange.
         string value = "abc";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotNullOrWhiteSpace_is_called_with_a_null_string()
      {
         // Arrange.
         string value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrWhiteSpace();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotNullOrWhiteSpace_is_called_with_a_empty_string()
      {
         // Arrange.
         string value = "";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrWhiteSpace();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotNullOrWhiteSpace_is_called_with_a_valid_string()
      {
         // Arrange.
         string value = "abc";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrWhiteSpace();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotNullOrWhiteSpace_is_called_with_a_whitespace_string()
      {
         // Arrange.
         string value = "  ";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNullOrWhiteSpace();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }
   }
}
