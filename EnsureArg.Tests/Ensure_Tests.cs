namespace EnsureArg.Tests
{
   using System;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class Ensure_Tests
   {
      [TestMethod]
      public void When_Ensure_Arg_is_called_with_value_param()
      {
         // Arrange.
         object testObject = new object();

         // Act.
         IEnsureArg<object> ensureArg = Ensure.Arg(testObject);

         // Assert.
         ensureArg.Value.Should().BeSameAs(testObject);
      }

      [TestMethod]
      public void When_Ensure_Arg_is_called_with_value_and_name_params()
      {
         // Arrange.
         object testObject = new object();

         // Act.
         IEnsureArg<object> ensureArg = Ensure.Arg(testObject, "testObject");

         // Assert.
         ensureArg.Value.Should().BeSameAs(testObject);
         ensureArg.ArgumentName.Should().Be("testObject");
      }

      [TestMethod]
      public void When_Ensure_Arg_is_called_with_a_null_argument_name()
      {
         // Arrange.
         object testObject = null;

         IEnsureArg<object> ensureArg = Ensure.Arg(testObject, null);

         // Act.
         Action action = () =>
            ensureArg.IsNotNull();

         // Assert.
         ensureArg.ArgumentName.Should().Be(null);

         action.ShouldThrow<ArgumentNullException>()
               .And.ParamName.Should().BeNull();
      }

      [TestMethod]
      public void When_Ensure_Arg_is_called_with_value_and_name_and_message_params()
      {
         // Arrange.
         object testObject = new object();

         // Act.
         IEnsureArg<object> ensureArg = Ensure.Arg(testObject, "thisIsATestObject", "my custom message");

         // Assert.
         ensureArg.Value.Should().BeSameAs(testObject);
         ensureArg.ArgumentName.Should().Be("thisIsATestObject");
         ensureArg.ExceptionMessage.Should().Be("my custom message");
      }

      [TestMethod]
      public void When_Ensure_Arg_is_called_with_value_and_name_and_message_and_format_params()
      {
         // Arrange.
         object testObject = new object();
         string[] formatArgs = new string[]
         {
            "is",
            "message"
         };

         // Act.
         IEnsureArg<object> ensureArg = Ensure.Arg(testObject, "testObject", "this {0} a custom {1}", formatArgs);

         // Assert.
         ensureArg.Value.Should().BeSameAs(testObject);
         ensureArg.ArgumentName.Should().Be("testObject");
         ensureArg.ExceptionMessage.Should().Be("this {0} a custom {1}");
         ensureArg.ExceptionMessageFormatArgs.Should().ContainInOrder(formatArgs);
      }

      [TestMethod]
      public void When_ValidateIsNotNull_is_called_with_null()
      {
         // Arrange. Act.
         Action action = () =>
            ((IEnsureArg<object>)null).ValidateEnsureArgIsNotNull();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }
   }
}
