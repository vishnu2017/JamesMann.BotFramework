﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JamesMann.BotFramework.Middleware {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JamesMann.BotFramework.Middleware.Resource", typeof(Resource).Assembly);
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
        ///  &quot;$schema&quot;: &quot;http://adaptivecards.io/schemas/adaptive-card.json&quot;,
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.0&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;TextBlock&quot;,
        ///      &quot;text&quot;: &quot;Please select your appointment and confirm&quot;
        ///    },
        ///    {
        ///      &quot;type&quot;: &quot;Input.ChoiceSet&quot;,
        ///      &quot;id&quot;: &quot;chosenRoom&quot;,
        ///      &quot;style&quot;: &quot;expanded&quot;,
        ///      &quot;isMultiSelect&quot;: false,
        ///      &quot;value&quot;: &quot;1&quot;,
        ///      &quot;choices&quot;: $(choices),
        ///    }
        ///  ],
        ///  &quot;actions&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;Action.Submit&quot;,
        ///      &quot;title&quot;: &quot;OK&quot;
        ///    }
        ///  ] [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AdaptiveCardChoiceTemplate {
            get {
                return ResourceManager.GetString("AdaptiveCardChoiceTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;$schema&quot;: &quot;http://adaptivecards.io/schemas/adaptive-card.json&quot;,
        ///  &quot;type&quot;: &quot;AdaptiveCard&quot;,
        ///  &quot;version&quot;: &quot;1.0&quot;,
        ///  &quot;body&quot;: [
        ///    {
        ///      &quot;type&quot;: &quot;Container&quot;,
        ///      &quot;items&quot;: [
        ///        {
        ///          &quot;type&quot;: &quot;TextBlock&quot;,
        ///          &quot;text&quot;: &quot;Appointment Confirmation&quot;,
        ///          &quot;weight&quot;: &quot;bolder&quot;,
        ///          &quot;size&quot;: &quot;medium&quot;
        ///        },
        ///        {
        ///          &quot;type&quot;: &quot;ColumnSet&quot;,
        ///          &quot;columns&quot;: [
        ///
        ///            {
        ///              &quot;type&quot;: &quot;Column&quot;,
        ///              &quot;width&quot;: &quot;stretch&quot;,
        ///              &quot;items&quot;: [
        ///           [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AdaptiveCardRoomTemplate {
            get {
                return ResourceManager.GetString("AdaptiveCardRoomTemplate", resourceCulture);
            }
        }
    }
}
