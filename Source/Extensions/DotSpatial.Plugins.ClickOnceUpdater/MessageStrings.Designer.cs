﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotSpatial.Plugins.ClickOnceUpdater {
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
    internal class MessageStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessageStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotSpatial.Plugins.ClickOnceUpdater.MessageStrings", typeof(MessageStrings).Assembly);
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
        ///   Looks up a localized string similar to The application has been upgraded, and will now restart..
        /// </summary>
        internal static string ApplicationUpgradeRestartNow {
            get {
                return ResourceManager.GetString("ApplicationUpgradeRestartNow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: {0}.
        /// </summary>
        internal static string CantCheckForNewVersionClickOnceDeploymentIsCorrupt {
            get {
                return ResourceManager.GetString("CantCheckForNewVersionClickOnceDeploymentIsCorrupt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The new version of the application cannot be downloaded at this time. 
        ///
        ///Please check your network connection, or try again later. Error: {0}.
        /// </summary>
        internal static string CantDownloadNewVersion {
            get {
                return ResourceManager.GetString("CantDownloadNewVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This application cannot be updated. It is likely not a ClickOnce application. Error: {0}.
        /// </summary>
        internal static string CantUpdateLikelyNotAClickOnceApplicationError {
            get {
                return ResourceManager.GetString("CantUpdateLikelyNotAClickOnceApplicationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Checking for updates..
        /// </summary>
        internal static string CheckingForUpdates {
            get {
                return ResourceManager.GetString("CheckingForUpdates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This application has detected a mandatory update from your current version to version {0}. The application will now install the update and restart..
        /// </summary>
        internal static string DetectedMandatoryUpdateWillNowInstallAndRestart {
            get {
                return ResourceManager.GetString("DetectedMandatoryUpdateWillNowInstallAndRestart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Available.
        /// </summary>
        internal static string UpdateAvailable {
            get {
                return ResourceManager.GetString("UpdateAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Found..
        /// </summary>
        internal static string UpdateFound {
            get {
                return ResourceManager.GetString("UpdateFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update installed..
        /// </summary>
        internal static string UpdateInstalled {
            get {
                return ResourceManager.GetString("UpdateInstalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating.
        /// </summary>
        internal static string Updating {
            get {
                return ResourceManager.GetString("Updating", resourceCulture);
            }
        }
    }
}
