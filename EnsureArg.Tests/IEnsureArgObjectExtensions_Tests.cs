﻿namespace EnsureArg.Tests
{
   using System;
   using EnsureArg;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgObjectExtensions_Tests
   {
      [TestMethod]
      public void When_an_argument_is_null_then_an_ArgumentNullException_should_be_thrown()
      {
         // Arrange.
         object value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value).IsNotNull();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_an_ArgumentNullException_is_thrown_the_parameter_name_is_correct()
      {
         // Arrange.
         object value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value, "value").IsNotNull();

         // Assert.
         action.ShouldThrow<ArgumentNullException>()
            .And.ParamName.Should().Be("value");
      }

      [TestMethod]
      public void When_an_ArgumentNullException_is_thrown_the_exception_message_is_correct()
      {
         // Arrange.
         object value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value, "value", "my custom exception message").IsNotNull();

         // Assert.
         action.ShouldThrow<ArgumentNullException>()
            .And.Message.Should().Be("my custom exception message" + Environment.NewLine + "Parameter name: value");
      }

      [TestMethod]
      public void When_an_ArgumentNullException_is_thrown_with_an_overriden_exception_message_it_is_correct()
      {
         // Arrange.
         object value = null;

         // Act.
         Action action = () =>
            Ensure.Arg(value, "value", "my custom exception message")
               .IsNotNull("my other message");

         // Assert.
         action.ShouldThrow<ArgumentNullException>()
            .And.Message.Should().Be("my other message" + Environment.NewLine + "Parameter name: value");
      }

      [TestMethod]
      public void When_an_Argument_is_not_null()
      {
         // Arrange.
         object value = new object();

         // Act.
         Action action = () =>
            Ensure.Arg(value, "value").IsNotNull();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotNull_is_called_it_returns_the_EnsureArg_created_from_Ensure_Arg()
      {
         // Arrange.
         object value = new object();

         IEnsureArg<object> ensureArg = Ensure.Arg(value);

         // Act.
         IEnsureArg<object> returnedEnsureArg = ensureArg.IsNotNull();

         // Assert.
         ensureArg.Should().BeSameAs(returnedEnsureArg);
      }
   }
}
