namespace EnsureArg.Examples
{
   using System;
   using System.Collections.Generic;
   using System.Data;
   using EnsureArg.Core;

   public class WikiExamples
   {
      public void DoThing(object a, object b, object c)
      {
         if (a == null)
         {
            throw new ArgumentNullException("a");
         }

         if (b == null)
         {
            throw new ArgumentNullException("b");
         }

         if (c == null)
         {
            throw new ArgumentNullException("c");
         }
      }

      /*
      public void DoThing(object a, object b, object c)
      {
         Ensure.Arg(a, "a").IsNotNull();
         Ensure.Arg(b, "b").IsNotNull();
         Ensure.Arg(c, "c").IsNotNull();
      }
       */

      public void EvaluateStudent(Student student)
      {
         // Ensure the student argument is not null.
         // If it is a ArgumentNullException will be thrown with the correct parameter name.
         Ensure.Arg(student, "student").IsNotNull();
      }

      public int CountDigits(string digits)
      {
         // Ensure the digits argument is not null or an empty string.
         // If it is null an ArgumentNullException will be thrown.
         // If it is empty an ArgumentException will be thrown.
         Ensure.Arg(digits, "digits").IsNotNullOrEmpty();

         return 0;
      }

      public void LogText(IEnumerable<string> strings)
      {
         // Ensure the strings argument is not null or an empty collection.
         // If it is a null an ArgumentNullException will be thrown.
         // If it is an empty collection an ArgumentException will be thrown.
         Ensure.Arg(strings, "strings").IsNotNullOrEmpty();
      }

      public void LogText(int startIndex, int endIndex, params string[] strings)
      {
         // Ensure the startIndex argument is less than or equal to endIndex.
         // If startIndex is greater to endIndex then an
         // ArgumentOutOfRangeException will be thrown.
         // Also supports IsLessThan, IsGreaterThan, and IsGreaterThanOrEqualTo.
         Ensure.Arg(startIndex, "startIndex").IsLessThanOrEqualTo(endIndex);
      }

      public void LogText(int startIndex, params string[] strings)
      {
         // Ensures the startIndex argument is greater than or equal to 0
         // and it is less than or equal to strings.Length - 1.
         // If these conditions are not meet an ArgumentOutOfRangeException will be thrown.
         // Also supports Ensure.Arg().IsBetween();
         Ensure.Arg(startIndex, "startIndex").IsBetweenOrEqualTo(0, strings.Length - 1);
      }

      public void LogIn(IUser user)
      {
         // Will throw an ArgumentException if the User.IsAuthenticated is false with the message "User is not authenticated".
         Ensure.Arg(user, "user", "User is not authenticated").IsAuthenticated();
      }

      public void EnumerateCollection<T>(ICollection<T> collection, int startIndex, int endIndex)
      {
         Ensure.Arg(collection, "collection").IsNotNullOrEmpty();

         Ensure.Arg(collection.Count, "collection").IsGreaterThan(startIndex).IsLessThanOrEqualTo(endIndex);
      }

      public void EatApple(Apple apple)
      {
         // Conditions are evaluated in order of method calls.
         // If first condition fails and throws an exception subsequent conditions will not be evaluated.
         Ensure.Arg(apple, "apple")
            .IsNotNull()
            .IsNotEaten()
            .IsRipe();
      }

      public void EatAppleWithAndMethodCall(Apple apple)
      {
         // Using Optional And() syntax.
         Ensure.Arg(apple, "apple").IsNotNull().And().IsNotEaten().And().IsRipe();
      }

      public void VerifyTest(object a)
      {
         Verify.That(a, "a").IsNotNull();
      }

      public void RangeTest(int index, int startIndex, int endIndex)
      {
         Ensure.Arg(index, "index", "Expected {argName} to be between {min} and {max} but was {arg}")
            .IsBetween(startIndex, endIndex);

         // Given index = 1, startIndex = 3, and endIndex = 5 the above code
         // throws an ArgumentOutOfRangeException with a message of
         // "Expected index to be between 3 and 5 but was 1"
      }

      public void LessThanTest(int min, int max)
      {
         Ensure.Arg(min, "min", "Expected {argName} to be less than max but min was {arg} and max was {other}")
            .IsLessThan(max);

         // Given index = 1, startIndex = 3, and endIndex = 5 the above code
         // throws an ArgumentOutOfRangeException with a message of
         // "Expected min to be less than max but min was 5 and max was 1"
      }

      public void DrawShape(Shape shape)
      {
         Ensure.Arg(shape, "shape")
            .IsValidEnumValue("{argName} was not a valid {enumType.Name} value. Actual value was {arg}");

         // Given a invalid shape of 45, such as calling DrawShape((Shape)45);
         // The above code throws an InvalidEnumArgumentException with a message of 
         // "shape was not a valid Shape value. Actual value was 45"
      }

      public enum Shape
      {
         Square,
         Circle,
         Triangle
      }
   }

   public class Student
   {
   }

   public class Apple
   {
   }

   public interface IUser
   {
      bool IsAuthenticated { get; }
   }

   public static class Extensions
   {
      public static IEnsureArg<Apple> IsNotEaten(this IEnsureArg<Apple> ensureArg)
      {
         return ensureArg;
      }

      public static IEnsureArg<Apple> IsRipe(this IEnsureArg<Apple> ensureArg)
      {
         return ensureArg;
      }

      public static IDbDataParameter CreateParameter(this IDbCommand command, DbType dbType)
      {
         Ensure.Arg(command, "command").IsNotNull();

         // Ensure dbType is a valid enumeration value for the DbType enum type.
         // If it is not then an InvalidEnumArgumentException will be thrown.
         Ensure.Arg(dbType, "dbType").IsValidEnumValue();

         return null;
      }

      public static IEnsureArg<IUser> IsAuthenticated(this IEnsureArg<IUser> ensureArg, string exceptionMessage = null)
      {
         ensureArg.ValidateEnsureArgIsNotNull();

         if (!ensureArg.Value.IsAuthenticated)
         {
            ensureArg.ThrowArgumentException(exceptionMessage);
         }

         return ensureArg;
      }
   }

   public static class Verify
   {
      public static IEnsureArg<T> That<T>(T value, string name)
      {
         // Wrap Ensure.Arg.
         return Ensure.Arg(value, name);
      }      
   }
}
