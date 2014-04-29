namespace EnsureArg.Tests
{
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

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
         IEnsureArg<string> ensureArg = new EnsureArg<string>(
            "somestring",
            "someParameterName",
            "Custom Exception message with parameter name place holder {ParamName}");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Custom Exception message with parameter name place holder someParameterName");
      }

      [TestMethod]
      public void When_an_exception_message_with_a_property_placeholder_is_used_it_is_replaced_correctly()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = new EnsureArg<Person>(
            new Person() { Age = 29 },
            "person",
            "Expected person to be at least 30 but was {arg.Age}");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was 29");
      }

      [TestMethod]
      public void When_an_exception_message_with_a_property_placeholder_is_used_with_a_null_value_it_is_ignored()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = new EnsureArg<Person>(
            null,
            "person",
            "Expected person to be at least 30 but was {arg.Age}");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was ");
      }

      [TestMethod]
      public void When_an_exception_message_is_created_with_stringFormat_first()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = new EnsureArg<Person>(
            new Person() { Age = 29 },
            "person",
            string.Format("Expected {0} to be at least 30 but was {{arg.Age}}", "person"));

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected person to be at least 30 but was 29");
      }

      [TestMethod]
      public void When_an_exception_has_both_numeric_and_named_placeholders()
      {
         // Arrange.
         IEnsureArg<Person> ensureArg = new EnsureArg<Person>(
            new Person() { Age = 29 },
            "personParamName",
            "Expected {ParamName}.Age to be at least 30 but was {arg.Age}. {{0}}",
            "For more details see API documentation");

         // Act.
         string message = ensureArg.GetExceptionMessage(null);

         // Assert.
         message.Should().Be("Expected personParamName.Age to be at least 30 but was 29. For more details see API documentation");
      }

      private class Person
      {
         public int Age { get; set; }
      }
   }
}
