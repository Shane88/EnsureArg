﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnsureArgAnalyzers {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EnsureArgAnalyzers.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first argument to Ensure.Arg is not a parameter to the containg method.
        /// </summary>
        internal static string AnalyzerDescription1 {
            get {
                return ResourceManager.GetString("AnalyzerDescription1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The second argument to Ensure.Arg does not match the name of the first argument.
        /// </summary>
        internal static string AnalyzerDescription2 {
            get {
                return ResourceManager.GetString("AnalyzerDescription2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update string literal to use nameof operator.
        /// </summary>
        internal static string AnalyzerDescription3 {
            get {
                return ResourceManager.GetString("AnalyzerDescription3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure.Arg must have a follow up call such as .IsNotNull().
        /// </summary>
        internal static string AnalyzerDescription4 {
            get {
                return ResourceManager.GetString("AnalyzerDescription4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument &apos;{0}&apos; is not a parameter to the method &apos;{1}&apos;.
        /// </summary>
        internal static string AnalyzerMessageFormat1 {
            get {
                return ResourceManager.GetString("AnalyzerMessageFormat1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The second argument of &apos;{0}&apos; should match the first argument of &apos;{1}&apos; .
        /// </summary>
        internal static string AnalyzerMessageFormat2 {
            get {
                return ResourceManager.GetString("AnalyzerMessageFormat2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The second argument &apos;{0}&apos; can be updated to use the nameof operator.
        /// </summary>
        internal static string AnalyzerMessageFormat3 {
            get {
                return ResourceManager.GetString("AnalyzerMessageFormat3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure.Arg must have a follow up call such as .IsNotNull().
        /// </summary>
        internal static string AnalyzerMessageFormat4 {
            get {
                return ResourceManager.GetString("AnalyzerMessageFormat4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument is not a parameter of the containing method.
        /// </summary>
        internal static string AnalyzerTitle1 {
            get {
                return ResourceManager.GetString("AnalyzerTitle1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Second argument is not valid.
        /// </summary>
        internal static string AnalyzerTitle2 {
            get {
                return ResourceManager.GetString("AnalyzerTitle2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update string literal to use nameof operator.
        /// </summary>
        internal static string AnalyzerTitle3 {
            get {
                return ResourceManager.GetString("AnalyzerTitle3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ensure.Arg must have a follow up call.
        /// </summary>
        internal static string AnalyzerTitle4 {
            get {
                return ResourceManager.GetString("AnalyzerTitle4", resourceCulture);
            }
        }
    }
}
