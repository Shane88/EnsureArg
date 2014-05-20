namespace EnsureArg.BclExtensions.Tests
{
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class ArrayExtensions_Tests
   {
      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_null_array()
      {
         // Arrange.
         object[] objects = null;

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_an_empty_array()
      {
         // Arrange.
         object[] objects = new object[] { };

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_populated_array()
      {
         // Arrange.
         object[] objects = new object[]
         {
            new object()
         };

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_null_array()
      {
         // Arrange.
         object[] objects = null;

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_an_empty_array()
      {
         // Arrange.
         object[] objects = new object[] { };

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_populated_array()
      {
         // Arrange.
         object[] objects = new object[]
         {
            new object()
         };

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }
   }
}
