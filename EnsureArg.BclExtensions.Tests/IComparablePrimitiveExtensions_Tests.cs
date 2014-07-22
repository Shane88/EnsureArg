namespace EnsureArg.BclExtensions.Tests
{
   using System;
   using EnsureArg.BclExtensions;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IComparablePrimitiveExtensions_Tests
   {  
      private static T GetValue<T>(int value)
      {
         object newVal = null;
   
         if (typeof(T) == typeof(DateTime))
         {
            newVal = new DateTime(value);
         }
         else 
         {
            newVal = Convert.ChangeType(value, typeof(T));
         }
   
         return (T)newVal;
      }

      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<byte>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<byte>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<byte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<byte>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<byte>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<byte>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<byte>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<byte>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<byte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<byte>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<byte>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<byte>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<byte>(20), GetValue<byte>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<byte>(5), GetValue<byte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<byte>(1), GetValue<byte>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_min_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<byte>(10), GetValue<byte>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetween_is_called_with_max_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<byte>(0), GetValue<byte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<byte>(20), GetValue<byte>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<byte>(5), GetValue<byte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<byte>(1), GetValue<byte>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<byte>(10), GetValue<byte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_byteIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         byte value = GetValue<byte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<byte>(0), GetValue<byte>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<sbyte>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<sbyte>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<sbyte>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<sbyte>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<sbyte>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<sbyte>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<sbyte>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<sbyte>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<sbyte>(20), GetValue<sbyte>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<sbyte>(5), GetValue<sbyte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<sbyte>(1), GetValue<sbyte>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<sbyte>(10), GetValue<sbyte>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetween_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetween(GetValue<sbyte>(0), GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<sbyte>(20), GetValue<sbyte>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<sbyte>(5), GetValue<sbyte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<sbyte>(1), GetValue<sbyte>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<sbyte>(10), GetValue<sbyte>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_sbyteIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<sbyte>(0), GetValue<sbyte>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<short>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<short>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<short>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<short>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<short>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<short>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<short>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<short>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<short>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<short>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<short>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<short>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetween(GetValue<short>(20), GetValue<short>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetween(GetValue<short>(5), GetValue<short>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetween(GetValue<short>(1), GetValue<short>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_min_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetween(GetValue<short>(10), GetValue<short>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetween_is_called_with_max_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetween(GetValue<short>(0), GetValue<short>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<short>(20), GetValue<short>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<short>(5), GetValue<short>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<short>(1), GetValue<short>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<short>(10), GetValue<short>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_shortIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         short value = GetValue<short>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<short>(0), GetValue<short>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ushort>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ushort>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ushort>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ushort>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ushort>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ushort>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ushort>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ushort>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ushort>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ushort>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ushort>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ushort>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ushort>(20), GetValue<ushort>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ushort>(5), GetValue<ushort>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ushort>(1), GetValue<ushort>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_min_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ushort>(10), GetValue<ushort>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetween_is_called_with_max_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ushort>(0), GetValue<ushort>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ushort>(20), GetValue<ushort>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ushort>(5), GetValue<ushort>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ushort>(1), GetValue<ushort>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ushort>(10), GetValue<ushort>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ushortIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ushort>(0), GetValue<ushort>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<int>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<int>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<int>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<int>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<int>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<int>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<int>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<int>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<int>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<int>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<int>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<int>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetween(GetValue<int>(20), GetValue<int>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetween(GetValue<int>(5), GetValue<int>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetween(GetValue<int>(1), GetValue<int>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_min_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetween(GetValue<int>(10), GetValue<int>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetween_is_called_with_max_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetween(GetValue<int>(0), GetValue<int>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<int>(20), GetValue<int>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<int>(5), GetValue<int>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<int>(1), GetValue<int>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<int>(10), GetValue<int>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_intIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         int value = GetValue<int>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<int>(0), GetValue<int>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<uint>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<uint>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<uint>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<uint>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<uint>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<uint>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<uint>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<uint>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<uint>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<uint>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<uint>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<uint>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetween(GetValue<uint>(20), GetValue<uint>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetween(GetValue<uint>(5), GetValue<uint>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetween(GetValue<uint>(1), GetValue<uint>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_min_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetween(GetValue<uint>(10), GetValue<uint>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetween_is_called_with_max_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetween(GetValue<uint>(0), GetValue<uint>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<uint>(20), GetValue<uint>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<uint>(5), GetValue<uint>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<uint>(1), GetValue<uint>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<uint>(10), GetValue<uint>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_uintIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         uint value = GetValue<uint>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<uint>(0), GetValue<uint>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<long>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<long>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<long>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<long>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<long>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<long>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<long>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<long>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<long>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<long>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<long>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<long>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetween(GetValue<long>(20), GetValue<long>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetween(GetValue<long>(5), GetValue<long>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetween(GetValue<long>(1), GetValue<long>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_min_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetween(GetValue<long>(10), GetValue<long>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetween_is_called_with_max_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetween(GetValue<long>(0), GetValue<long>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<long>(20), GetValue<long>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<long>(5), GetValue<long>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<long>(1), GetValue<long>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<long>(10), GetValue<long>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_longIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         long value = GetValue<long>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<long>(0), GetValue<long>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ulong>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ulong>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<ulong>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ulong>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ulong>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<ulong>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ulong>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ulong>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<ulong>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ulong>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ulong>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<ulong>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ulong>(20), GetValue<ulong>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ulong>(5), GetValue<ulong>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ulong>(1), GetValue<ulong>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_min_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ulong>(10), GetValue<ulong>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetween_is_called_with_max_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetween(GetValue<ulong>(0), GetValue<ulong>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ulong>(20), GetValue<ulong>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ulong>(5), GetValue<ulong>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ulong>(1), GetValue<ulong>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ulong>(10), GetValue<ulong>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_ulongIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<ulong>(0), GetValue<ulong>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<float>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<float>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<float>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<float>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<float>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<float>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<float>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<float>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<float>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<float>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<float>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<float>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetween(GetValue<float>(20), GetValue<float>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetween(GetValue<float>(5), GetValue<float>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetween(GetValue<float>(1), GetValue<float>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_min_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetween(GetValue<float>(10), GetValue<float>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetween_is_called_with_max_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetween(GetValue<float>(0), GetValue<float>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<float>(20), GetValue<float>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<float>(5), GetValue<float>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<float>(1), GetValue<float>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<float>(10), GetValue<float>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_floatIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         float value = GetValue<float>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<float>(0), GetValue<float>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<double>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<double>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<double>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<double>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<double>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<double>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<double>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<double>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<double>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<double>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<double>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<double>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetween(GetValue<double>(20), GetValue<double>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetween(GetValue<double>(5), GetValue<double>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetween(GetValue<double>(1), GetValue<double>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_min_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetween(GetValue<double>(10), GetValue<double>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetween_is_called_with_max_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetween(GetValue<double>(0), GetValue<double>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<double>(20), GetValue<double>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<double>(5), GetValue<double>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<double>(1), GetValue<double>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<double>(10), GetValue<double>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_doubleIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         double value = GetValue<double>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<double>(0), GetValue<double>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<decimal>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<decimal>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<decimal>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<decimal>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<decimal>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<decimal>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<decimal>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<decimal>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<decimal>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<decimal>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<decimal>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<decimal>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetween(GetValue<decimal>(20), GetValue<decimal>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetween(GetValue<decimal>(5), GetValue<decimal>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetween(GetValue<decimal>(1), GetValue<decimal>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_min_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetween(GetValue<decimal>(10), GetValue<decimal>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetween_is_called_with_max_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetween(GetValue<decimal>(0), GetValue<decimal>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<decimal>(20), GetValue<decimal>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<decimal>(5), GetValue<decimal>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<decimal>(1), GetValue<decimal>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<decimal>(10), GetValue<decimal>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_decimalIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<decimal>(0), GetValue<decimal>(10));

         // Assert.
         result.Should().Be(true);
      }


      [TestMethod]
      public void When_DateTimeIsGreaterThan_is_called_with_a_larger_value()
      {
         // Assert.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<DateTime>(5));

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_DateTimeIsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<DateTime>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThan(GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<DateTime>(5));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<DateTime>(15));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsGreaterThanOrEqualTo(GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<DateTime>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<DateTime>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThan(GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<DateTime>(5));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<DateTime>(15));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsLessThanOrEqualTo(GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsBetween_is_called_with_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetween(GetValue<DateTime>(20), GetValue<DateTime>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetween(GetValue<DateTime>(5), GetValue<DateTime>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsBetween_is_called_with_higher_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetween(GetValue<DateTime>(1), GetValue<DateTime>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetween_is_called_with_min_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetween(GetValue<DateTime>(10), GetValue<DateTime>(20));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetween_is_called_with_max_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetween(GetValue<DateTime>(0), GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<DateTime>(20), GetValue<DateTime>(30));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<DateTime>(5), GetValue<DateTime>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<DateTime>(1), GetValue<DateTime>(9));

         // Assert.
         result.Should().Be(false);
      }

      [TestMethod]
      public void When_DateTimeIsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<DateTime>(10), GetValue<DateTime>(20));

         // Assert.
         result.Should().Be(true);
      }

      [TestMethod]
      public void When_DateTimeIsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(10);

         // Act.
         bool result = value.IsBetweenOrEqualTo(GetValue<DateTime>(0), GetValue<DateTime>(10));

         // Assert.
         result.Should().Be(true);
      }

  
   }
}
