namespace EnsureArg.Tests
{
   using System;
   using System.ComponentModel;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgEnumExtensions_Tests
   {
      public enum MyEnum
      {
         DefaultValue,
         AnotherValue
      }

      [TestMethod]
      public void When_enum_value_is_invalid_an_InvalidEnumArgumentException_is_thrown()
      {
         // Arrange.
         MyEnum value = (MyEnum)(-1);

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsValidEnumValue();

         // Assert.
         action.ShouldThrow<InvalidEnumArgumentException>();
      }

      [TestMethod]
      public void When_IsValidEnumValue_is_called_with_an_invalid_type_parameter()
      {
         // Arrange.
         int value = 3;

         // Act.
         Action action = () =>
            Ensure.Arg(value, "value").IsValidEnumValue();

         // Arrange.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_a_valid_enum_value_is_passed_to_IsValidEnumValue()
      {
         MyEnum value = MyEnum.AnotherValue;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsValidEnumValue();

         // Assert.
         action.ShouldNotThrow();
      }
   }
}
