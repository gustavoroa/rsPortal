using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoaSystems.Web.Portal.Models
{
    public abstract class PartialViewModelBase
    {
        /// <summary>
        /// Gets or sets the name 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of parameters passed to the view by the URL. 
        /// </summary>
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the Canonical URL 
        /// </summary>
        public string CanonicalUrl { get; set; }


        //public User User { get; set; }

        /// <summary>
        /// Gets or sets the list of JavaScript blocks to inject into the HTML View code...
        /// </summary>
        public List<ScriptBlock> ThirdPartyJavaScriptBlocks { get; set; }
    }
}