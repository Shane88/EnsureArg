namespace EnsureArg.Tests
{
   using System;
   using System.ComponentModel;
   using EnsureArg.Core;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;
   using NSubstitute;

   [TestClass]
   public class IEnsureArgExtensions_Tests
   {
      [TestMethod]
      public void When_And_is_called_the_same_EnsureArg_is_returned()
      {
         // Arrange.
         object value = new object();

         IEnsureArg<object> ensureArg = Ensure.Arg(value);

         // Act.
         IEnsureArg<object> returnedEnsureArg = ensureArg.And();

         // Assert.
         ensureArg.Should().BeSameAs(returnedEnsureArg);
      }

      [TestMethod]
      public void When_a_InvalidEnumArgumentException_is_thrown_with_a_message()
      {
         // Arrange.
         IEnsureArg<MyTestEnum> ensureArg = Substitute.For<IEnsureArg<MyTestEnum>>();
         ensureArg.Value.Returns((MyTestEnum)(-1));
         ensureArg.ArgumentName.Returns("myEnum");

         // Act.
         Action action = () =>
            ensureArg.ThrowInvalidEnumArgumentException("my custom message");

         // Assert.
         action.ShouldThrow<InvalidEnumArgumentException>()
               .And
               .Message.Should().Be("my custom message");
      }

      [TestMethod]
      public void When_an_ArgumentException_is_thrown()
      {
         // Arrange.
         IEnsureArg<object> ensureArg = Substitute.For<IEnsureArg<object>>();
         ensureArg.Value.Returns(new object());
         ensureArg.ArgumentName.Returns("myObject");

         // Act.
         Action action = () =>
            ensureArg.ThrowArgumentException(null);

         // Assert.
         action.ShouldThrow<ArgumentException>()
               .And
               .ParamName.Should().Be("myObject");
      }

      [TestMethod]
      public void When_an_ArgumentOutOfRangeException_is_thrown_named_place_holders_are_correct()
      {
         // Arrange.
         IEnsureArg<int> ensureArg = Substitute.For<IEnsureArg<int>>();
         ensureArg.Value.Returns(3);
         ensureArg.ArgumentName.Returns("myInt");

         // Act.
         Action action = () =>
            ensureArg.ThrowArgumentOutOfRangeException(1, 5, "Expected {ArgName} to be between {min} and {max} but was {arg}");

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>()
               .And
               .Message.Should().StartWith("Expected myInt to be between 1 and 5 but was 3");
      }

      [TestMethod]
      public void When_an_ArgumentOutOfRangeException_is_thrown_with_a_null_value()
      {
         // Arrange.
         IEnsureArg<object> ensureArg = Substitute.For<IEnsureArg<object>>();
         ensureArg.ArgumentName.Returns((string)null);

         // Act.
         Action action = () =>
            ensureArg.ThrowArgumentOutOfRangeException(null, null, null);

         // Assert.
         action.ShouldThrow<ArgumentOutOfRangeException>()
               .And
               .Message.Should().NotBeNull();
      }

      public class Person
      {
         public int Age { get; set; }
      }
   }
}
