namespace EnsureArg.Tests
{
   using System;
   using System.Collections;
   using System.Collections.Generic;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgCollectionExtensions_Tests
   {
      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_generic_List()
      {
         // Arrange.
         List<object> objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_generic_List()
      {
         // Arrange.
         List<object> objects = new List<object>();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_generic_List()
      {
         // Arrange.
         List<object> objects = new List<object>()
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_List()
      {
         // Arrange.
         ArrayList objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_List()
      {
         // Arrange.
         ArrayList objects = new ArrayList();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_List()
      {
         // Arrange.
         ArrayList objects = new ArrayList()
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_generic_IList()
      {
         // Arrange.
         IList<object> objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_generic_IList()
      {
         // Arrange.
         IList<object> objects = new List<object>();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_generic_IList()
      {
         // Arrange.
         IList<object> objects = new List<object>()
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_generic_ICollection()
      {
         // Arrange.
         ICollection<object> objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_generic_ICollection()
      {
         // Arrange.
         ICollection<object> objects = new List<object>();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_generic_ICollection()
      {
         // Arrange.
         ICollection<object> objects = new List<object>()
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_ICollection()
      {
         // Arrange.
         ICollection objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_ICollection()
      {
         // Arrange.
         ICollection objects = new List<object>();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_ICollection()
      {
         // Arrange.
         ICollection objects = new List<object>()
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_array()
      {
         // Arrange.
         object[] objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_array()
      {
         // Arrange.
         object[] objects = new object[] { };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_array()
      {
         // Arrange.
         object[] objects = new object[]
         {
            null
         };

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotEmpty();

         // Assert.
         action.ShouldNotThrow();
      }
   }
}
