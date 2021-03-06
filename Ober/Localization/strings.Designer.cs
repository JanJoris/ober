﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ober.Tool.Localization {
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
    internal class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ober.Tool.Localization.strings", typeof(strings).Assembly);
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
        ///   Looks up a localized string similar to This command has not yet been implemented.
        /// </summary>
        internal static string CommandNotYetImplemented {
            get {
                return ResourceManager.GetString("CommandNotYetImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I&apos;m unable to load the config file at {0}, would you mind to verify if the file exists and is correctly configured?.
        /// </summary>
        internal static string ConfigError {
            get {
                return ResourceManager.GetString("ConfigError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Config file found at {0}.
        /// </summary>
        internal static string ConfigFound {
            get {
                return ResourceManager.GetString("ConfigFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to it seems the configfile at {0} is incomplete or malformed..
        /// </summary>
        internal static string ConfigMalformed {
            get {
                return ResourceManager.GetString("ConfigMalformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the config file cannot be found at {0}, would you mind adding one to proceed?.
        /// </summary>
        internal static string ConfigNotFound {
            get {
                return ResourceManager.GetString("ConfigNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully loaded config file..
        /// </summary>
        internal static string ConfigSuccess {
            get {
                return ResourceManager.GetString("ConfigSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to \nThe config file menu is:\n\nCredentials:\n\tClientId: &lt;clientid&gt;\n\tKey: &lt;key&gt;\n\tTenantId: &lt;tenantid&gt;.
        /// </summary>
        internal static string ConfigTemplate {
            get {
                return ResourceManager.GetString("ConfigTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error logging in, response statuscode = {0}.
        /// </summary>
        internal static string DebugLoginError {
            get {
                return ResourceManager.GetString("DebugLoginError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login unsuccessful, please provide the correct credentials..
        /// </summary>
        internal static string LoginError {
            get {
                return ResourceManager.GetString("LoginError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logging in.
        /// </summary>
        internal static string LoginProgress {
            get {
                return ResourceManager.GetString("LoginProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login successful!.
        /// </summary>
        internal static string LoginSuccess {
            get {
                return ResourceManager.GetString("LoginSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the submission could not be comitted..
        /// </summary>
        internal static string SubmitCommitError {
            get {
                return ResourceManager.GetString("SubmitCommitError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The submission has been successfully comitted, sir..
        /// </summary>
        internal static string SubmitCommitSuccess {
            get {
                return ResourceManager.GetString("SubmitCommitSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Committing submission.
        /// </summary>
        internal static string SubmitCommitting {
            get {
                return ResourceManager.GetString("SubmitCommitting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I was unable to create a new submission..
        /// </summary>
        internal static string SubmitCreateError {
            get {
                return ResourceManager.GetString("SubmitCreateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating new submission.
        /// </summary>
        internal static string SubmitCreating {
            get {
                return ResourceManager.GetString("SubmitCreating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I was unable to update the submission..
        /// </summary>
        internal static string SubmitUpdateError {
            get {
                return ResourceManager.GetString("SubmitUpdateError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating submission.
        /// </summary>
        internal static string SubmitUpdating {
            get {
                return ResourceManager.GetString("SubmitUpdating", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading package.
        /// </summary>
        internal static string SubmitUploading {
            get {
                return ResourceManager.GetString("SubmitUploading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uploading package.
        /// </summary>
        internal static string UploadingPackage {
            get {
                return ResourceManager.GetString("UploadingPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the provided packages file at {0} does not exist..
        /// </summary>
        internal static string ValidatePackageNonExistant {
            get {
                return ResourceManager.GetString("ValidatePackageNonExistant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the provided packages file at {0} does not contain any .appxupload package..
        /// </summary>
        internal static string ValidatePackageNoPackages {
            get {
                return ResourceManager.GetString("ValidatePackageNoPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to the provided packages file at {0} is not a zip file..
        /// </summary>
        internal static string ValidatePackageNoZip {
            get {
                return ResourceManager.GetString("ValidatePackageNoZip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Would you mind to verify the provided parameters and order again?.
        /// </summary>
        internal static string VerifyParameters {
            get {
                return ResourceManager.GetString("VerifyParameters", resourceCulture);
            }
        }
    }
}
