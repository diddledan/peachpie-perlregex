﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Peachpie.Library.RegularExpressions.Resources {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Peachpie.Library.RegularExpressions.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Delimiter must not be alphanumeric or backslash.
        /// </summary>
        internal static string delimiter_alnum_backslash {
            get {
                return ResourceManager.GetString("delimiter_alnum_backslash", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignoring unsupported pattern modifier &apos;{0}&apos; in perl regular expression.
        /// </summary>
        internal static string modifier_not_supported {
            get {
                return ResourceManager.GetString("modifier_not_supported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignoring unknown pattern modifier &apos;{0}&apos; in perl regular expression.
        /// </summary>
        internal static string modifier_unknown {
            get {
                return ResourceManager.GetString("modifier_unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pattern modifier &apos;{0}&apos; is ignored due to use of modifier &apos;{1}&apos; in perl regular expression.
        /// </summary>
        internal static string modifiers_inconsistent {
            get {
                return ResourceManager.GetString("modifiers_inconsistent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREG_PATTERN_ORDER and PREG_SET_ORDER flags are mutually exclusive.
        /// </summary>
        internal static string preg_match_pattern_set_order {
            get {
                return ResourceManager.GetString("preg_match_pattern_set_order", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No ending delimiter &apos;{0}&apos; found.
        /// </summary>
        internal static string preg_no_end_delimiter {
            get {
                return ResourceManager.GetString("preg_no_end_delimiter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regular expression cannot end with &apos;(&apos;.
        /// </summary>
        internal static string regexp_cannot_end_with_open_bracket {
            get {
                return ResourceManager.GetString("regexp_cannot_end_with_open_bracket", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regular expression cannot end with &apos;\\&apos;.
        /// </summary>
        internal static string regexp_cannot_end_with_two_backslashes {
            get {
                return ResourceManager.GetString("regexp_cannot_end_with_two_backslashes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nothing to repeat - duplicate quantifier at offset {0} in matching part of regular expression..
        /// </summary>
        internal static string regexp_duplicate_quantifier {
            get {
                return ResourceManager.GetString("regexp_duplicate_quantifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty regular expression.
        /// </summary>
        internal static string regular_expression_empty {
            get {
                return ResourceManager.GetString("regular_expression_empty", resourceCulture);
            }
        }
    }
}