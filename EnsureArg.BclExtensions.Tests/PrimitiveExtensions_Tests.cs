namespace EnsureArg.BclExtensions.Tests
{
   using System;
   using EnsureArg.BclExtensions;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class PrimitiveExtensions_Tests
   {
      private static T GetValue<T>(int value)
      {
         object newVal = null;

         if (typeof(T) == typeof(DateTime))
         {
            newVal = new DateTime(value);
         }
         else if (typeof(T) == typeof(Guid))
         {
            newVal = Guid.NewGuid();
         }
         else 
         {
            newVal = Convert.ChangeType(value, typeof(T));
         }

         return (T)newVal;
      }

      [TestMethod]
      public void When_byte_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         byte value = default(byte);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_byte_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         byte value = GetValue<byte>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_byte_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         byte value = default(byte);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_byte_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         byte value = GetValue<byte>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_sbyte_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         sbyte value = default(sbyte);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_sbyte_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_sbyte_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         sbyte value = default(sbyte);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_sbyte_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         sbyte value = GetValue<sbyte>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_short_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         short value = default(short);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_short_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         short value = GetValue<short>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_short_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         short value = default(short);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_short_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         short value = GetValue<short>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ushort_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         ushort value = default(ushort);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ushort_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_ushort_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         ushort value = default(ushort);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_ushort_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         ushort value = GetValue<ushort>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_int_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         int value = default(int);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_int_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         int value = GetValue<int>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_int_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         int value = default(int);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_int_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         int value = GetValue<int>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_uint_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         uint value = default(uint);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_uint_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         uint value = GetValue<uint>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_uint_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         uint value = default(uint);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_uint_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         uint value = GetValue<uint>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_long_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         long value = default(long);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_long_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         long value = GetValue<long>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_long_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         long value = default(long);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_long_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         long value = GetValue<long>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ulong_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         ulong value = default(ulong);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_ulong_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_ulong_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         ulong value = default(ulong);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_ulong_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         ulong value = GetValue<ulong>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_float_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         float value = default(float);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_float_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         float value = GetValue<float>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_float_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         float value = default(float);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_float_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         float value = GetValue<float>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_double_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         double value = default(double);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_double_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         double value = GetValue<double>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_double_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         double value = default(double);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_double_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         double value = GetValue<double>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_decimal_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         decimal value = default(decimal);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_decimal_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_decimal_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         decimal value = default(decimal);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_decimal_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         decimal value = GetValue<decimal>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_DateTime_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         DateTime value = default(DateTime);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_DateTime_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_DateTime_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         DateTime value = default(DateTime);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_DateTime_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         DateTime value = GetValue<DateTime>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_Guid_IsDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         Guid value = default(Guid);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_Guid_IsDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         Guid value = GetValue<Guid>(1);

         // Act.
         bool result = value.IsDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_Guid_IsNotDefaultValue_is_called_with_the_default_value()
      {
         // Arrange.
         Guid value = default(Guid);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_Guid_IsNotDefaultValue_is_called_with_a_non_default_value()
      {
         // Arrange.
         Guid value = GetValue<Guid>(1);

         // Act.
         bool result = value.IsNotDefaultValue();

         // Assert.
         result.Should().BeTrue();
      }
   }
}
