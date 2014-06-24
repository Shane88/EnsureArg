namespace EnsureArg.BclExtensions.Tests
{
   using System;
   using FluentAssertions;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   [TestClass]
   public class IDisposableExtensions_Tests
   {
      [TestMethod]
      public void When_DisposeIfNotNull_is_called_with_null()
      {
         // Arrange.
         IDisposable disposable = null;

         // Act.
         Action action = () =>
            disposable.DisposeIfNotNull();

         // Assert.
         action.ShouldNotThrow();
      }

      [TestMethod]
      public void When_DisposeIfNotNull_is_called_with_not_null()
      {
         // Arrange.
         DisposableSpy spy = new DisposableSpy();

         // Act.
         spy.DisposeIfNotNull();

         // Assert.
         spy.WasDisposed.Should().BeTrue();
      }

      private class DisposableSpy : IDisposable
      {
         public bool WasDisposed = false;

         public void Dispose()
         {
            WasDisposed = true;
         }
      }
   }
}
