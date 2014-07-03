namespace EnsureArg.BclExtensions.Tests
{
   using EnsureArg.BclExtensions;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IComparablePrimitiveExtensions_Tests
   {  
      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_min_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_max_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         byte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_min_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_max_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         short value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_min_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_max_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ushort value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         int value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_min_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_max_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         uint value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_min_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_max_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         long value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_min_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_max_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ulong value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_min_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_max_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         float value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_min_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_max_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         double value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThan(5);

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThan(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(5);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(15);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThan(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThan(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThan(10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(5);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(15);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsLessThanOrEqualTo(10);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetween(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetween(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetween(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_min_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetween(10, 20);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_max_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetween(0, 10);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(20, 30);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(5, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(1, 9);

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(10, 20);

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         decimal value = 10;

         // Act.
         bool result = value.IsBetweenOrEqualTo(0, 10);

         // Assert.
         result.Should().Be(true);
      }

  
   }
}
