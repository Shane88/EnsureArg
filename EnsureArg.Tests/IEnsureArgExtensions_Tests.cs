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
      public void When_an_exception_message_with_a_paramName_placeholder_is_used_it_is_replaced_correctly()
      {
         // Arrange.
         IEnsureArg<string> ensureArg = Substitute.For<IEnsureArg<string>>();
         ensureArg.Value.Returns("some string");
         ensureArg.ArgumentName.Returns("someParameterName");
         ensureArg.ExceptionMessage.Returns("Custom Exception message with parameter name place holder {ArgName}");
         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Custom Exception message with parameter name place holder someParameterName");
      }

      [TestMethod]
      public void When_an_exception_message_with_a_property_placeholder_is_used_it_is_replaced_correctly()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = Substitute.For<IEnsureArg<Person>>();
         ensureArg.Value.Returns(new Person() { Age = 29 });
         ensureArg.ArgumentName.Returns("person");
         ensureArg.ExceptionMessage.Returns("Expected person to be at least 30 but was {arg.Age}");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was 29");
      }

      [TestMethod]
      public void When_an_exception_message_with_a_property_placeholder_is_used_with_a_null_value_it_is_ignored()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = Substitute.For<IEnsureArg<Person>>();
         ensureArg.Value.Returns((Person)null);
         ensureArg.ArgumentName.Returns("person");
         ensureArg.ExceptionMessage.Returns("Expected person to be at least 30 but was {arg.Age}");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was ");
      }

      [TestMethod]
      public void When_an_exception_message_is_created_with_stringFormat_first()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = Substitute.For<IEnsureArg<Person>>();
         ensureArg.Value.Returns(new Person() { Age = 29 });
         ensureArg.ArgumentName.Returns("person");
         ensureArg.ExceptionMessage.Returns(string.Format("Expected {0} to be at least 30 but was {{arg.Age}}", "person"));

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was 29");
      }

      [TestMethod]
      public void When_an_exception_has_named_placeholders()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = Substitute.For<IEnsureArg<Person>>();
         ensureArg.Value.Returns(new Person() { Age = 29 });
         ensureArg.ArgumentName.Returns("personParamName");
         ensureArg.ExceptionMessage.Returns("Expected {ArgName}.Age to be at least 30 but was {arg.Age}.");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected personParamName.Age to be at least 30 but was 29.");
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

      public class Person
      {
         public int Age { get; set; }
      }
   }
}
