﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureCAT.Samples.TransientFaultHandling.Properties {
    using System;
    
    
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
    internal class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AzureCAT.Samples.TransientFaultHandling.Properties.ExceptionMessages", typeof(ExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to The specified argument {0} cannot be initialized with its default value..
        /// </summary>
        internal static string ArgumentCannotBeDefault {
            get {
                return ResourceManager.GetString("ArgumentCannotBeDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be greater than its ceiling value of {1}..
        /// </summary>
        internal static string ArgumentCannotBeGreaterThanBaseline {
            get {
                return ResourceManager.GetString("ArgumentCannotBeGreaterThanBaseline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be initialized with a negative value..
        /// </summary>
        internal static string ArgumentCannotBeNegative {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be initialized with a zero or negative value..
        /// </summary>
        internal static string ArgumentCannotBeZeroOrNegative {
            get {
                return ResourceManager.GetString("ArgumentCannotBeZeroOrNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of the argument {0} provided for the enumeration {1} is invalid..
        /// </summary>
        internal static string InvalidEnumValue {
            get {
                return ResourceManager.GetString("InvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action has exceeded its defined retry limit..
        /// </summary>
        internal static string RetryLimitExceeded {
            get {
                return ResourceManager.GetString("RetryLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified string argument {0} must not be empty..
        /// </summary>
        internal static string StringCannotBeEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified type {0} is not compatible with {1}..
        /// </summary>
        internal static string TypeNotCompatible {
            get {
                return ResourceManager.GetString("TypeNotCompatible", resourceCulture);
            }
        }
    }
}
