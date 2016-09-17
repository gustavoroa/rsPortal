using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoaSystems.Server
{
    public interface IAdobeController
    {
        string GetAdobeHomePageTag();
        string GetAdobeBlindsProductDetailPageTag(string productid);
        string GetAdobeProductListPageTag();

        string GetAdobeCollectionListPageTag();
        string GetAdobeOrderCompletePageTag(List<CriteoProduct> listofCriteoProductIds, Order placedOrder, string couponString);
        string GetAdobeManufacturerTag();

        string GetAdobePageTag(string pageName, AdobePageType pageType, AdobePrimaryCategoryType primaryCategoryType, List<AbobeSubCategory> subCategoryList);
        string GetAdobePageTag(string pageName, AdobePageType pageType, AdobePrimaryCategoryType primaryCategoryType, List<AbobeSubCategory> subCategoryList, string productid);
        string GetAdobeSocialMediaEventTag();
        string GetAdobeCreateNewWorksheetTag();
        string GetAdobeRegisterPageTag();
        string GetAdobeRegistrationSuccessTag();
        string GetAdobeLoginSuccessTag();

        string GetAdobeCartPagTag(List<CriteoProduct> listofCriteoProductIds, string pageName);

        string GetAdobeCheckOutPaymentPagTag(List<CriteoProduct> listofCriteoProductIds, string pageName);
        string GetAdobeCheckOutPaymentPagTag(List<CriteoProduct> listofCriteoProductIds, Core.Controllers.ShoppingCartType cartType);
    }

    public interface ISilverPopController
    {
        string GetOrderCompleteTag(List<CriteoProduct> listofCriteoProductIds, Order placedOrder);
    }

    public class SilverPopController : ISilverPopController
    {
        public string GetOrderCompleteTag(List<CriteoProduct> listofCriteoProductIds, Order placedOrder)
        {
            //return "<script>ewt.cot({action:'Purchase',detail:'Blueberry Ice Cream',amount:'1.24'});</script>";
            var returnstr = "<script>";
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var listofCriteoProductId in listofCriteoProductIds)
            {
                returnstr += "ewt.cot({action:'Purchase',detail:'" + listofCriteoProductId.ProductId + "',amount:'" + listofCriteoProductId.Price + "'}),";
            }

            //remove the trailing commas
            returnstr = returnstr.TrimEnd(',');
            returnstr += "</script>";
            return returnstr;
        }
    }
}
}
