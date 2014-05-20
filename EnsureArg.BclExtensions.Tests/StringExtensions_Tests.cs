namespace EnsureArg.BclExtensions.Tests
{
   using System.Collections.Generic;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class StringExtensions_Tests
   {
      [TestMethod]
      public void String_IsNullOrEmpty()
      {
         // Arrange.
         List<string> strings = new List<string>()
         {
            null,
            "",
            " ",
            "abc",
         };

         // Act\Assert.
         foreach (string value in strings)
         {
            value.IsNullOrEmpty().Should().Be(string.IsNullOrEmpty(value));
         }
      }

      [TestMethod]
      public void String_IsNullOrWhiteSpace()
      {
         // Arrange.
         List<string> strings = new List<string>()
         {
            null,
            "",
            " ",
            "abc",
         };

         // Act\Assert.
         foreach (string value in strings)
         {
            value.IsNullOrWhiteSpace().Should().Be(string.IsNullOrWhiteSpace(value));
         }
      }

      [TestMethod]
      public void String_IsNotNullOrEmpty()
      {
         // Arrange.
         List<string> strings = new List<string>()
         {
            null,
            "",
            " ",
            "abc",
         };

         // Act\Assert.
         foreach (string value in strings)
         {
            value.IsNotNullOrEmpty().Should().Be(!string.IsNullOrEmpty(value));
         }
      }

      [TestMethod]
      public void String_IsNotNullOrWhiteSpace()
      {
         // Arrange.
         List<string> strings = new List<string>()
         {
            null,
            "",
            " ",
            "abc",
         };

         // Act\Assert.
         foreach (string value in strings)
         {
            value.IsNotNullOrWhiteSpace().Should().Be(!string.IsNullOrWhiteSpace(value));
         }
      }
   }
}
