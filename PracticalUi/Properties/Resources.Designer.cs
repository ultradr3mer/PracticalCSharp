﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticalUi.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PracticalUi.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;Paragraphs&quot;: [
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;2.0 + 2.0&quot;,
        ///      &quot;Text&quot;: &quot;Since adding integer numbers was so much fun, how about we add numbers with decimal places.&quot;
        ///    },
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;2.0 * 3.0&quot;,
        ///      &quot;Text&quot;: &quot;Multiplying two numbers is not that different.&quot;
        ///    },
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;(6.0).GetType()&quot;,
        ///      &quot;Text&quot;: &quot;Numbers with a decimal point are of the type float, which is the keywo [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FloatLesson {
            get {
                return ResourceManager.GetString("FloatLesson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;Paragraphs&quot;: [
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;2 + 2&quot;,
        ///      &quot;Text&quot;: &quot;Programming does not need to be complicated. It can be as easy as adding two and two. Try it out yourself.&quot;
        ///    },
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;2 * 3&quot;,
        ///      &quot;Text&quot;: &quot;Multiplying two numbers is not that different.&quot;
        ///    },
        ///    {
        ///      &quot;IsScriptingVisible&quot;: true,
        ///      &quot;Code&quot;: &quot;(2).GetType()&quot;,
        ///      &quot;Text&quot;: &quot;Numbers without a decimal point are of the type Int32. The Int32  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IntegerLesson {
            get {
                return ResourceManager.GetString("IntegerLesson", resourceCulture);
            }
        }
    }
}
