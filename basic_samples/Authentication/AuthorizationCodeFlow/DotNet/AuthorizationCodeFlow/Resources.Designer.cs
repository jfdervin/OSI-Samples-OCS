﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthorizationCodeFlow {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AuthorizationCodeFlow.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Address cannot be null or empty.
        /// </summary>
        internal static string AddressRequired {
            get {
                return ResourceManager.GetString("AddressRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration issue.
        /// </summary>
        internal static string ConfigIssue {
            get {
                return ResourceManager.GetString("ConfigIssue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration is null.
        /// </summary>
        internal static string ConfigNull {
            get {
                return ResourceManager.GetString("ConfigNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make request:.
        /// </summary>
        internal static string MakeRequest {
            get {
                return ResourceManager.GetString("MakeRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options cannot be null.
        /// </summary>
        internal static string OptionsRequired {
            get {
                return ResourceManager.GetString("OptionsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prompting for login via a browser....
        /// </summary>
        internal static string PromptingLogin {
            get {
                return ResourceManager.GetString("PromptingLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request failed.
        /// </summary>
        internal static string RequestFailed {
            get {
                return ResourceManager.GetString("RequestFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request succeeded.
        /// </summary>
        internal static string RequestSucceeded {
            get {
                return ResourceManager.GetString("RequestSucceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to +-----------------------+
        ///|  Sign in with OIDC    |
        ///+-----------------------+.
        /// </summary>
        internal static string SignInWithOidc {
            get {
                return ResourceManager.GetString("SignInWithOidc", resourceCulture);
            }
        }
    }
}