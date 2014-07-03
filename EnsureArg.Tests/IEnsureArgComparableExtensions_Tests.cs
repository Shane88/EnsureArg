namespace EnsureArg.Tests
{
   using System;
   using EnsureArg;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgComparableExtensions_Tests
   {
      [TestMethod]
      public void When_EnsureArg_IsLessThan_is_called_with_a_larger_value()
      {
         // Arrange.
         string value = "7";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan("5");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsLessThan_is_called_with_a_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan("15");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsLessThan_is_called_with_a_same_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThan("10");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsLessThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         string value = "7";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo("5");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsLessThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo("15");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsLessThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsLessThanOrEqualTo("10");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThan_is_called_with_a_larger_value()
      {
         // Arrange.
         string value = "7";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan("5");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThan_is_called_with_a_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan("15");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThan_is_called_with_a_same_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThan("10");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_larger_value()
      {
         // Arrange.
         string value = "7";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo("5");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo("15");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsGreaterThanOrEqualTo_is_called_with_a_same_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsGreaterThanOrEqualTo("10");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetween_is_called_with_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween("20", "30");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetween_is_called_with_in_between_value()
      {
         // Arrange.
         string value = "5";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween("1", "9");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetween_is_called_with_higher_value()
      {
         // Arrange.
         string value = "8";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween("1", "4");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetween_is_called_with_min_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween("10", "20");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetween_is_called_with_max_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetween("0", "10");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetweenOrEqualTo_is_called_with_lower_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo("20", "30");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetweenOrEqualTo_is_called_with_in_between_value()
      {
         // Arrange.
         string value = "5";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo("1", "9");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetweenOrEqualTo_is_called_with_higher_value()
      {
         // Arrange.
         string value = "9";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo("1", "8");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetweenOrEqualTo_is_called_with_min_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo("10", "20");

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_EnsureArg_IsBetweenOrEqualTo_is_called_with_max_value()
      {
         // Arrange.
         string value = "10";

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsBetweenOrEqualTo("0", "10");

         // Assert.
         action.ShouldNotThrow();
      }
   }
}
