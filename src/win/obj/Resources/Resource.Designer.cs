﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MuteFm.obj.Resources {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MuteFm.obj.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to var nextPrevTrack = function(delta)
        ///{
        ///	if (delta === 0) {
        ///		return &quot;zero invalid&quot;;
        ///	}
        ///	var tracks = document.getElementsByTagName(&quot;li&quot;);
        ///	for (i = 0; i &lt; tracks.length; i++)
        ///	{
        ///		if (tracks[i].id === &quot;addhere&quot;)
        ///		{
        ///			var index = delta + i;
        ///			if (delta &lt; 0) index--;
        ///			if (((index &lt; 0) || (index &gt;= tracks.length)) || (tracks[index].id.indexOf(&quot;song_&quot;) != 0)) {
        ///				return &quot;out of bounds&quot;;
        ///			}
        ///
        ///			tracks[index].getElementsByClassName(&quot;title&quot;)[0].click();
        ///			return &quot;&quot;;
        ///		}
        ///	}
        ///};
        ///.
        /// </summary>
        internal static string burnfm_nextprevtrack {
            get {
                return ResourceManager.GetString("burnfm_nextprevtrack", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon favicon {
            get {
                object obj = ResourceManager.GetObject("favicon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
