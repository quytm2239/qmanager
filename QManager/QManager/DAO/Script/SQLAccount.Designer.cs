﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QManager.DAO.Script {
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
    internal class SQLAccount {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SQLAccount() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QManager.DAO.Script.SQLAccount", typeof(SQLAccount).Assembly);
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
        ///   Looks up a localized string similar to DELETE FROM `account` WHERE id = ?id.
        /// </summary>
        internal static string DELETE_BY_ID {
            get {
                return ResourceManager.GetString("DELETE_BY_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM `account` WHERE account = ?account.
        /// </summary>
        internal static string DELETE_BY_USERNAME {
            get {
                return ResourceManager.GetString("DELETE_BY_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM account.
        /// </summary>
        internal static string GET_ALL {
            get {
                return ResourceManager.GetString("GET_ALL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM account WHERE id = ?id.
        /// </summary>
        internal static string GET_BY_ID {
            get {
                return ResourceManager.GetString("GET_BY_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO `account`(`username`,`password`,`email`,`status`,`role`) VALUES(?username,?password,?email,?status,?role).
        /// </summary>
        internal static string INSERT {
            get {
                return ResourceManager.GetString("INSERT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?email.
        /// </summary>
        internal static string KEY_EMAIL {
            get {
                return ResourceManager.GetString("KEY_EMAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?id.
        /// </summary>
        internal static string KEY_ID {
            get {
                return ResourceManager.GetString("KEY_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?password.
        /// </summary>
        internal static string KEY_PASSWORD {
            get {
                return ResourceManager.GetString("KEY_PASSWORD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?role.
        /// </summary>
        internal static string KEY_ROLE {
            get {
                return ResourceManager.GetString("KEY_ROLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?status.
        /// </summary>
        internal static string KEY_STATUS {
            get {
                return ResourceManager.GetString("KEY_STATUS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ?username.
        /// </summary>
        internal static string KEY_USERNAME {
            get {
                return ResourceManager.GetString("KEY_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `account` SET `username` = ?username,`password` = ?password,`email` = ?email,`status` = ?status,`role` = ?role WHERE `id` = ?id.
        /// </summary>
        internal static string UPDATE_BY_ID {
            get {
                return ResourceManager.GetString("UPDATE_BY_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE `account` SET `username` = ?username,`password` = ?password,`email` = ?email,`status` = ?status,`role` = ?role WHERE `username` = ?username.
        /// </summary>
        internal static string UPDATE_BY_USERNAME {
            get {
                return ResourceManager.GetString("UPDATE_BY_USERNAME", resourceCulture);
            }
        }
    }
}