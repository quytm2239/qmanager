﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QManager.Services.HTTP_API {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class APIGlossary {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal APIGlossary() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QManager.Services.HTTP_API.APIGlossary", typeof(APIGlossary).Assembly);
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
        ///   Looks up a localized string similar to /auth/all-department.
        /// </summary>
        internal static string API_GET_ALL_DEPARTMENT {
            get {
                return ResourceManager.GetString("API_GET_ALL_DEPARTMENT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /public/login.
        /// </summary>
        internal static string API_LOGIN {
            get {
                return ResourceManager.GetString("API_LOGIN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to password.
        /// </summary>
        internal static string KEY_PASSWORD {
            get {
                return ResourceManager.GetString("KEY_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to username.
        /// </summary>
        internal static string KEY_USERNAME {
            get {
                return ResourceManager.GetString("KEY_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to data.
        /// </summary>
        internal static string RES_KEY_DATA {
            get {
                return ResourceManager.GetString("RES_KEY_DATA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to message.
        /// </summary>
        internal static string RES_KEY_MESSAGE {
            get {
                return ResourceManager.GetString("RES_KEY_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to success.
        /// </summary>
        internal static string RES_KEY_SUCCESS {
            get {
                return ResourceManager.GetString("RES_KEY_SUCCESS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to token.
        /// </summary>
        internal static string RES_KEY_TOKEN {
            get {
                return ResourceManager.GetString("RES_KEY_TOKEN", resourceCulture);
            }
        }
    }
}
