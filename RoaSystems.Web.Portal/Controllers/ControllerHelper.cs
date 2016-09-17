//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RoaSystems.Web.Portal.Controllers
//{
//    public class ControllerHelper
//    {
//    }
//}


using System.Collections.Generic;
using System.Collections.Specialized;
using RoaSystems.Core;
//using RoaSystems.Core.Context;
using RoaSystems.Server;
using RoaSystems.Web.Portal.Models;


namespace RoaSystems.Web.Portal.Controllers
{
    public interface IControllerHelper
    {
        List<ScriptBlock> GetScriptBlocks();
        List<Parameter> GetPassedParameters(NameValueCollection pQueryString);
        string GetCustomerId();
        string GetAdobeOpeningTag();
        string GetAdobeClosingTag();
    }

    /// <summary>
    /// This is to hold the common method that are useful in any controller. For e.g. The logged in Customer is available as a property called CurrentCustomer
    /// </summary>
    public class ControllerHelper : IControllerHelper
    {


        //private readonly IAdobeController _adobeController;

        //public ControllerHelper(IAdobeController adobeController)
        //{
        //    _adobeController = adobeController;
        //}

        public ControllerHelper()
        {
            //_adobeController = adobeController;
        }

        //public string SetAdobeTagOnPage(string pageName, AdobePageType pageType, AdobePrimaryCategoryType primaryCategoryType, List<AbobeSubCategory> subCategoryList)
        //{

        //    return _adobeController.GetAdobePageTag(pageName, pageType, primaryCategoryType, subCategoryList);
        //}


        /// <summary>
        /// Gets the list to the passed parameters to the current controller.
        /// </summary>
        /// <returns>A list of the passed Parameter objects</returns>
        public List<Parameter> GetPassedParameters(NameValueCollection pQueryString)
        {
            var result = new List<Parameter>();
            if (pQueryString.HasKeys())
            {
                foreach (var key in pQueryString.AllKeys)
                {
                    var parameter = new Parameter
                    {
                        Name = key,
                        Value = pQueryString[key]
                    };
                    result.Add(parameter);
                }
            }
            return result;
        }

        public string GetCustomerId()
        {
            var customerId = "SB ";

            //if (CustomContext.Current.SecurityController.Customer != null)
            //{
            //    customerId += CustomContext.Current.SecurityController.Customer.CustomerID.ToString();
            //}
            return customerId;
        }


        public List<ScriptBlock> GetScriptBlocks()
        {
            var scriptBlock = new List<ScriptBlock>();
           //{
           //    new ScriptBlock
           //    {
           //     Name = "Adobe Tag",
           //     Value = _adobeController.GetAdobeHomePageTag()
           //    }
           // };

            return scriptBlock;
        }

        public string GetAdobeOpeningTag()
        {
            var adobeSourceLocation = ""; // Config.AdobeSourceLocation;
            return ""; //Config.AdobeTrackingEnabled
                //? string.Format("<script type=\"text/javascript\" src=\"{0}\"></script>", adobeSourceLocation)
                //: "";


        }

        public string GetAdobeClosingTag()
        {
            return "";/* Config.AdobeTrackingEnabled
                ? "<script type=\"text/javascript\">_satellite.pageBottom();</script>"
                : "";*/
        }
    }
}
