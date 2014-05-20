namespace EnsureArg.BclExtensions.Tests
{
   using System;
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnumerableExtensions_Tests
   {
      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_null_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = null;

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_empty_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>().Select(o => o);

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_valid_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>()
         {
            null
         }.Select(o => o);

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_empty_generic_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>();

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNullOrEmpty_is_called_with_a_empty_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new WeirdClassThatImplementsGenericIEnumerableButNonGenericICollection();

         // Act.
         bool result = objects.IsNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_null_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = null;

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_empty_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>().Select(o => o);

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_valid_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>()
         {
            null
         }.Select(o => o);

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeTrue();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_empty_generic_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>();

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      [TestMethod]
      public void When_IsNotNullOrEmpty_is_called_with_a_empty_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new WeirdClassThatImplementsGenericIEnumerableButNonGenericICollection();

         // Act.
         bool result = objects.IsNotNullOrEmpty();

         // Assert.
         result.Should().BeFalse();
      }

      private class WeirdClassThatImplementsGenericIEnumerableButNonGenericICollection : IEnumerable<object>, ICollection
      {
         public IEnumerator<object> GetEnumerator()
         {
            throw new NotImplementedException();
         }

         IEnumerator IEnumerable.GetEnumerator()
         {
            throw new NotImplementedException();
         }

         public void CopyTo(Array array, int index)
         {
            throw new NotImplementedException();
         }

         public int Count
         {
            get { return 0; }
         }

         public bool IsSynchronized
         {
            get { throw new NotImplementedException(); }
         }

         public object SyncRoot
         {
            get { throw new NotImplementedException(); }
         }
      }
   }
}
