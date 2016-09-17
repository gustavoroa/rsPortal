using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoaSystems.Web.Portal.Models
{
    public class ViewModelScripts
    {
        public string AdobeOpeningTag { get; set; }
        public string AdobeClosingTag { get; set; }
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public List<Parameter> Parameteros { get; set; }
        public string CanonicalUrl { get; set; }
        //public User User { get; set; }

        /// <summary>
        /// Gets or sets the list of JavaScript blocks to inject into the HTML View code...
        /// </summary>
        public List<ScriptBlock> ThirdPartyJavaScriptBlocks { get; set; }
    }
}