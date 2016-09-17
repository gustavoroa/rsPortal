using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoaSystems.Web.Portal.Models
{
    public class HomeViewModel : IViewModelBase
    {
        public string Name { get; set; }
        public string PageTitle { get; set; }
        public List<Parameter> UrlParameters { get; set; }
        public string CanonicalUrl { get; set; }
        //public User User { get; set; }
        public List<ScriptBlock> ThirdPartyJavaScriptBlocks { get; set; }
        public string AdobeOpeningTag { get; set; }
        public string AdobeClosingTag { get; set; }
    }
}