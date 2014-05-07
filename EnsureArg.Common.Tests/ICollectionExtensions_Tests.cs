namespace EnsureArg.Common.Tests
{
   using System.Collections.Generic;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class ICollectionExtensions_Tests
   {
      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_null_list()
      {
         // Arrange.
         ICollection<object> objects = null;

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_an_empty_list()
      {
         // Arrange.
         ICollection<object> objects = new List<object>();

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_populated_list()
      {
         // Arrange.
         ICollection<object> objects = new List<object>()
         {
            new object()
         };

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_null_list()
      {
         // Arrange.
         ICollection<object> objects = null;

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_an_empty_list()
      {
         // Arrange.
         ICollection<object> objects = new List<object>();

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_populated_list()
      {
         // Arrange.
         ICollection<object> objects = new List<object>()
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
