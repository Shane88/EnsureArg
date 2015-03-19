using System;
using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following set of attributes.
// Change these attribute values to modify the information associated with an assembly.
[assembly: AssemblyTitle("EnsureArg")]
[assembly: AssemblyDescription(
@"A lightweight and extensible guard clause library. 

Example:
Ensure.Arg(param1, ""param1"").IsNotNull();

The library is easily extensible through the use of extension methods. Even the main Ensure.Arg(...) call can be overridden to whatever you prefer e.g. Verify.That(...)

See the project site for many more examples")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Shane Taylor")]
[assembly: AssemblyProduct("EnsureArg")]
[assembly: AssemblyCopyright("Copyright ©  2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible to COM components. If
// you need to access a type in this assembly from COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("e42c8772-f611-4655-9d78-3e1c3ba0ad9e")]

// Version information for an assembly consists of the following four values:
//
// Major Version Minor Version Build Number Revision
//
// You can specify all the values or you can default the Build and Revision Numbers by using the '*'
// as shown below: [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.1.0")]
[assembly: AssemblyFileVersion("1.1.0")]
[assembly: CLSCompliant(true)]
