using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoaSystems.Web.Portal.Models
{
    public class ViewModelFooter : IViewModelBase
    {
        public string CustomerId { get; set; }
        public string RkgId { get; set; }
        public string AssemblyVersion { get; set; }
        public string MachineName { get; set; }
        public string AdobeOpeningTag { get; set; }

        public string AdobeClosingTag { get; set; }
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public List<Parameter> UrlParameters { get; set; }
        public string CanonicalUrl { get; set; }
        //public User User { get; set; }
        public List<ScriptBlock> ThirdPartyJavaScriptBlocks { get; set; }
    }
}