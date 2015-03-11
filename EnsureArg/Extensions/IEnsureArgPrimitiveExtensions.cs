namespace EnsureArg
{
   using System;
   using EnsureArg.BclExtensions;
   using EnsureArg.Core;

   /// <summary>
   /// Contains IEnsureArg extension methods for performing checks on primitive types.
   /// </summary>
   public static class PrimitiveExtensions
   {
      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Byte" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Byte" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<byte> IsNotDefaultValue(
         this IEnsureArg<byte> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.SByte" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.SByte" /></exception>
      [CLSCompliant(false)]
      public static IEnsureArg<sbyte> IsNotDefaultValue(
         this IEnsureArg<sbyte> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Int16" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Int16" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<short> IsNotDefaultValue(
         this IEnsureArg<short> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.UInt16" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.UInt16" /></exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ushort> IsNotDefaultValue(
         this IEnsureArg<ushort> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Int32" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Int32" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<int> IsNotDefaultValue(
         this IEnsureArg<int> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.UInt32" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.UInt32" /></exception>
      [CLSCompliant(false)]
      public static IEnsureArg<uint> IsNotDefaultValue(
         this IEnsureArg<uint> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Int64" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Int64" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<long> IsNotDefaultValue(
         this IEnsureArg<long> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.UInt64" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.UInt64" /></exception>
      [CLSCompliant(false)]
      public static IEnsureArg<ulong> IsNotDefaultValue(
         this IEnsureArg<ulong> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Single" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Single" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<float> IsNotDefaultValue(
         this IEnsureArg<float> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Double" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Double" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<double> IsNotDefaultValue(
         this IEnsureArg<double> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Decimal" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Decimal" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<decimal> IsNotDefaultValue(
         this IEnsureArg<decimal> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.DateTime" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.DateTime" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<DateTime> IsNotDefaultValue(
         this IEnsureArg<DateTime> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }

      /// <summary>
      /// Checks whether the value contained in the IEnsureArg instance is not the default value for the <see cref="System.Guid" /> type.
      /// </summary>
      /// <param name="ensureArg">The IEnsureArg instance, usually created from an Ensure.Arg() call.</param>
      /// <param name="exceptionMessage">Optional exception message to use if the null check fails. This exception message will override the message supplied in the Ensure.Arg() call, if any.</param>
      /// <returns>The ensureArg instance.</returns>
      /// <exception cref="System.ArgumentNullException">ensureArg.Value is null.</exception>
      /// <exception cref="System.ArgumentException">ensureArg.Value is equal to the default value for <see cref="System.Guid" /></exception>
      [CLSCompliant(true)]
      public static IEnsureArg<Guid> IsNotDefaultValue(
         this IEnsureArg<Guid> ensureArg,
         string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();
         if (!ensureArg.Value.IsNotDefaultValue())
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }
}
