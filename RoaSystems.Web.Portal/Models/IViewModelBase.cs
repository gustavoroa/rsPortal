//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RoaSystems.Web.Portal.Models
//{
//    public class IViewModelBase
//    {
//    }
//}






using System.Collections.Generic;
//using RoaSystems.Core.Business;

namespace RoaSystems.Web.Portal.Models
{
    public enum CheckOutSteps
    {
        ViewCart,
        ShippingBilling,
        PaymentAndOrder,
        Complete
    }

    internal interface IViewModelBase
    {
        /// <summary>
        /// Gets or sets the name 
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the page title 
        /// </summary>
        string PageTitle { get; set; }

        /// <summary>
        /// Gets or sets the list of parameters passed to the view by the URL. 
        /// </summary>
        List<Parameter> UrlParameters { get; set; }

        /// <summary>
        /// Gets or sets the Canonical URL 
        /// </summary>
        string CanonicalUrl { get; set; }


        /// <summary>
        /// Gets or sets the list of JavaScript blocks to inject into the HTML View code...
        /// </summary>
        List<ScriptBlock> ThirdPartyJavaScriptBlocks { get; set; }

        string AdobeOpeningTag { get; set; }
        string AdobeClosingTag { get; set; }
    }
}