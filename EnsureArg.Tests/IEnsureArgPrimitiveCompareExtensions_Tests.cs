namespace EnsureArg.Tests
{
   using System;
   using EnsureArg;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IComparablePrimitiveExtensions_Tests
   {  
      [TestMethod]
      public void When_byteEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_byteEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_sbyteEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_shortEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ushortEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_intEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_uintEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_longEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_ulongEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_floatEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_doubleEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(5);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(15);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan(10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(5);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(15);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo(10);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(10, 20);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween(0, 10);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(20, 30);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(5, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(1, 9);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(10, 20);

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_decimalEnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo(0, 10);

         // Assert.
         action.ShouldNotThrow();
      }

  
   }
}
