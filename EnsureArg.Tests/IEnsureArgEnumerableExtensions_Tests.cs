namespace EnsureArg.Tests
{
   using System;
   using System.Collections;
   using System.Collections.Generic;
   using System.Linq;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IEnsureArgEnumerableExtensions_Tests
   {
      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_null_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = null;

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentNullException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>().Select(o => o);

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_valid_generic_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>()
         {
            null
         }.Select(o => o);

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotNullOrEmpty();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_generic_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new List<object>();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
      }

      [TestMethod]
      public void When_IsNotEmpty_is_called_with_a_empty_ICollection_as_IEnumerable()
      {
         // Arrange.
         IEnumerable<object> objects = new WeirdClassThatImplementsGenericIEnumerableButNonGenericICollection();

         // Act.
         Action action = () =>
            Ensure.Arg(objects).IsNotNullOrEmpty();

         // Assert.
         action.ShouldThrow<ArgumentException>();
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
