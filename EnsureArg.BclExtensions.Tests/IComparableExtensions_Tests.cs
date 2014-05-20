namespace EnsureArg.BclExtensions.Tests
{
   using System;
   using EnsureArg.BclExtensions;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IComparableExtensions_Tests
   {
      [TestMethod]
      public void When_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_IsLessThan_is_called_with_a_null_value()
      {
         // Arrange.
         IComparable<int> value = null;

         // Act.
         Action action = () =>
            value.IsLessThan(2);

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsLessThan_is_called_with_a_null_other_value()
      {
         // Arrange.
         IComparable<string> value = "theValue";

         // Act.
         Action action = () =>
            value.IsLessThan(null);

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }
   }
}
