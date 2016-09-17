using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Description.Attribute;
using System.Threading.Tasks;

namespace RoaSystems.Server
{
    public enum AdobePrimaryCategoryType
    {
        //[Description("home page")]
        HomePage = 0,
        //[Description("blinds")]
        Blinds,
        //[Description("wallpaper")]
        Wallpaper,
        //[Description("my account")]
        MyAccount
    }
    public enum AdobePageType
    {
        //[Description("home page")]
        HomePage = 0,
        //[Description("Search Results")]
        SearchResults,
        //[Description("Manufacturer Page")]
        ManufacturerPage,
        //[Description("Style List")]
        StyleList,
        //[Description("Collection List")]
        CollectionList,
        //[Description("Product Detail")]
        ProductDetail,
        //[Description("Blinds Options")]
        BlindsOptions,
        //[Description("Account")]
        Account,
        //[Description("Worksheet")]
        Worksheet
    }

    public class AbobeSubCategory
    {
        public int Index { get; set; }
        public string Value { get; set; }
    }


    public class AdobeController : IAdobeController
    {
        private readonly Customer _loggedInCustomer;

        public AdobeController(Customer loggedInCustomer)
        {
            _loggedInCustomer = loggedInCustomer;
        }

        public string GetAdobeCreateNewWorksheetTag()
        {
            var email = GetHashedEmailOfLoggedInUser();
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            string jsStr = @"
            <script type=""text/javascript""> 
                digitalData={ 
                  page:{ 
                     pageInfo:{ 
                       pageName:""cart summary page | worksheet"", 
                       pageLoadEvent: ""worksheetview"", 
                       newWorksheetCreated: ""yes""
                     }, 
                     category:{ 
                          pageType:""cart"", 
                          primaryCategory:""cart summary"", 
                          subCategory1:""cart summary|worksheet"", 
                          subCategory2:""cart summary|worksheet"" 
                     }
                  }, 
                  user:{ 
                     userInfo:{ 
                       authStatus:""" + guestStatus + @""", 
                       userID:""" + email + @"""
                     } 
                  }, 
                  cart:{cartType:""worksheet""} 
                };                   
           </script>
            ";
            return jsStr;
        }

        public string GetAdobeSocialMediaEventTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendFormat(@"
            <script type=""text/javascript"">    
                var globalAdobePageName = null;
                function globalPushSocialLinkAdobe(_EventName,_EventAction,_TrackName){{ 
                    if((typeof _satellite)=='undefined' ){{console.log('_satellite is null');return; }}
                    var pageName = globalAdobePageName;
                    if(globalAdobePageName == null){{
                        if((typeof digitalData)!='undefined'){{ try{{pageName = digitalData.page.pageInfo.pageName;}}catch(e){{}} }}else digitalData=[];
                        if(pageName=='' || pageName==null) pageName=  document.title + ' - ' + window.location.href;  
                        globalAdobePageName = pageName;
                    }}
                    if(!digitalData.event) digitalData.event =[];  
                    digitalData.event.length = 0;                  
                    digitalData.event.push({{
                        eventInfo:{{
                            eventName: _EventName,
                            eventPage: pageName,
                            eventAction: _EventAction
                        }},
                        userInfo:{{
                            authStatus: ""{0}"",
                            userID: ""{1}""
                        }}
                    }});
                    console.log(pageName);
                    console.log(digitalData);
                    console.log(_TrackName);
                    _satellite.track(_TrackName);
                }};
                function pushHeadAdobe(SocialNetworkName){{ 
                    var _eventAction = ""header nav|social follow us|"" + SocialNetworkName;
                    globalPushSocialLinkAdobe(""social click"",_eventAction,""social-link"");
                }};   
            </script>
            ", guestStatus
             , email);
            return str.ToString();
        }
        private string GetSubmitLoginAndRegisterEvent()
        {
            var str = new StringBuilder();
            str.Append(@"      
               digitalData.event =[];
               function loginPushEvent(){        
                    
                  digitalData.event.push({ 
                        eventInfo:{ 
                        eventName:""login cta"", 
                        eventPage:""my account landing page"", 
                        eventType:""returning customer|login start"" 
                        } 
                   }); 
                   _satellite.track(""login-start"");
                  console.log(digitalData);
               };
               function registerPushEvent(){
                    
                    
                    digitalData.event.push({ 
                        eventInfo:{ 
                        eventName:""submit cta"", 
                        eventPage:""my account landing page"", 
                        eventAction:""new customer register start"" 
                    } 
                    }); 
                    
                    _satellite.track(""register-start"");
              };
            ");
            return str.ToString();
        }
        public string GetAdobeRegisterPageTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendFormat(@"
            <script type=""text/javascript"">  
                   digitalData={{ 
                        page:{{
                            pageInfo:{{ 
                                pageName:""my account|landing page"" 
                            }}, 
                            category:{{ 
                                pageType:""account"", 
                                primaryCategory:""my account"", 
                                subCategory1:""my account|landing page"", 
                                subCategory2:""my account|landing page"" 
                            }}
                        }}, 
                        user:{{ 
                            userInfo:{{ 
                                authStatus:""{0}"", 
                                userID:""{1}"" 
                            }}
                        }} 
                   }};
                 {2}
            </script>
            ", guestStatus
             , email
             , GetSubmitLoginAndRegisterEvent());
            return str.ToString();
        }

        public string GetAdobeRegistrationSuccessTag()
        {
            //var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            // ReSharper disable once FormatStringProblem
            var str = @"
            <script type=""text/javascript"">  
                 digitalData={
page:{
pageInfo:{
pageName:""my account|new customer registration|success"",
pageLoadEvent:""register success"",
promoSignUpCheck: ""yes""//should be set only when promo checkbox is selected
},
category:{
pageType:""account"",
primaryCategory:""my account"",
subCategory1:""my account| new customer registration"",
subCategory2:""my account| new customer registration|success""
}
},
user:{
userInfo:{
authStatus:'" + guestStatus + "'," +
"userID:'" + email + "'}}};</script>";

            return str;
        }

        public string GetAdobeLoginSuccessTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendFormat(@"
            <script type=""text/javascript"">  
                    digitalData={{ 
                          page:{{ 
                                pageInfo:{{ 
                                    pageName:""my account|customer login|success"", 
                                    pageLoadEvent:""login success""
                                }}, 
                                category:{{ 
                                    pageType:""account"", 
                                    primaryCategory:""my account"", 
                                    subCategory1:""my account| customer logion"", 
                                    subCategory2:""my account| customer logion | sucess"" 
                                }} 
                           }}, 
                           user:{{ 
                                    userInfo:{{ 
                                        authStatus:""{0}"", 
                                        userID:""{1}"" 
                                    }}
                           }} 
                    }};                
            </script>
            ", guestStatus
             , email
            );
            return str.ToString();
        }


        public string GetAdobeBlindsProductDetailPageTag(string productid)
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("var title = document.getElementsByTagName(\"title\")[0].innerHTML;");
            str.AppendLine("var allSpans = document.getElementsByTagName('span');");
            str.AppendLine("var onlyItemProps = [];");
            str.AppendLine("var count = 0;");
            str.AppendLine("");
            str.AppendLine("    for(var i = 0; i < allSpans.length; i ++) {");
            str.AppendLine("");
            str.AppendLine("        if(allSpans[i].getAttribute(\"itemprop\") === 'name') {");
            str.AppendLine("            count ++;");
            str.AppendLine("            onlyItemProps.push(allSpans[i].innerHTML);");
            str.AppendLine("        }");
            str.AppendLine("    }");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName: onlyItemProps[0] + '|' + onlyItemProps[1] + '|' + onlyItemProps[2] + '|' + onlyItemProps[3] ,");
            str.AppendLine("pageLoadEvent:\"productview\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"Product details\",");
            str.AppendLine("primaryCategory:\"Blinds\",");
            str.AppendLine("subCategory1:onlyItemProps[0],");
            str.AppendLine("subCategory2:onlyItemProps[1],");
            str.AppendLine("subCategory3:onlyItemProps[2],");
            str.AppendLine("subCategory4:onlyItemProps[3]");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("product:{");
            str.AppendLine("productInfo:{");
            str.AppendLine("sku: '" + productid + "'");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("};");

            str.AppendLine(GetAddtoCartPushEvent(productid, email));
            str.AppendLine("</script>");

            return str.ToString();
        }

        private static string GetAddtoCartPushEvent(string productid, string email)
        {
            var str = new StringBuilder();
            str.AppendLine("digitalData.event =[];");
            str.AppendLine("function AdobeAddToCartPushEvent(obj) {");
            str.AppendLine("if(obj){");
            str.AppendLine("    var _val=(obj.value)? obj.value:obj.innerHTML;");
            str.AppendLine("    if (_val.toLowerCase().indexOf(\"update\") > -1){window.console.log('update event.'); return; }");
            str.AppendLine("};");
            str.AppendLine("digitalData.event.push({");
            str.AppendLine("eventInfo:{");
            str.AppendLine("eventName:\"cta\",");
            str.AppendLine("eventAction:\"add to cart\",");
            str.AppendLine("eventPage:onlyItemProps[0] + '|' + onlyItemProps[1] + '|' + onlyItemProps[2] + '|' + onlyItemProps[3] ");
            str.AppendLine("},");
            str.AppendLine("product:{");
            str.AppendLine("addToCartLocaton:onlyItemProps[0] + '|' + onlyItemProps[1] + '|' + onlyItemProps[2] + '|' + onlyItemProps[3] ,");
            str.AppendLine("productInfo:[");
            str.AppendLine("{");
            str.AppendLine("productType: 'regular',");
            str.AppendLine("sku: '" + productid + "'");
            str.AppendLine("}]");
            str.AppendLine("}, ");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("});");
            str.AppendLine("_satellite.track(\"add-to-cart\");");
            str.AppendLine("}");

            return str.ToString();
        }


        public string GetAdobeProductListPageTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("var title = document.getElementsByTagName(\"title\")[0].innerHTML;");

            str.AppendLine("var allSpans = document.getElementsByTagName('span');");

            str.AppendLine("var onlyItemProps = [];");
            str.AppendLine("var count = 0;");
            str.AppendLine("");
            str.AppendLine("    for(var i = 0; i < allSpans.length; i ++) {");
            str.AppendLine("");
            str.AppendLine("        if(allSpans[i].getAttribute(\"itemprop\") === 'name') {");
            str.AppendLine("            count ++;");
            str.AppendLine("            onlyItemProps.push(allSpans[i].innerHTML);");
            str.AppendLine("        }");
            str.AppendLine("    }");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:onlyItemProps[0] + '|' + onlyItemProps[1],");
            str.AppendLine("pageLoadEvent:\"productview\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"Style List\",");
            str.AppendLine("primaryCategory:\"Blinds\",");
            str.AppendLine("subCategory1:onlyItemProps[0],");
            str.AppendLine("subCategory2:onlyItemProps[1]");
            //str.AppendLine("subCategory3:onlyItemProps[2],");
            //str.AppendLine("subCategory4:onlyItemProps[3]");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("};");
            str.AppendLine("</script>");

            return str.ToString();
        }

        public string GetAdobeCollectionListPageTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("var title = document.getElementsByTagName(\"title\")[0].innerHTML;");
            str.AppendLine("var allSpans = document.getElementsByTagName('span');");
            str.AppendLine("var onlyItemProps = [];");
            str.AppendLine("var count = 0;");
            str.AppendLine("");
            str.AppendLine("    for(var i = 0; i < allSpans.length; i ++) {");
            str.AppendLine("");
            str.AppendLine("        if(allSpans[i].getAttribute(\"itemprop\") === 'name') {");
            str.AppendLine("            count ++;");
            str.AppendLine("            onlyItemProps.push(allSpans[i].innerHTML);");
            str.AppendLine("        }");
            str.AppendLine("    }");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:onlyItemProps[0] + '|' + onlyItemProps[1] + '|' + onlyItemProps[2],");
            str.AppendLine("pageLoadEvent:\"productview\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"Collection List\",");
            str.AppendLine("primaryCategory:\"Blinds\",");
            str.AppendLine("subCategory1:onlyItemProps[0],");
            str.AppendLine("subCategory2:onlyItemProps[1],");
            str.AppendLine("subCategory3:onlyItemProps[2]");
            //str.AppendLine("subCategory4:onlyItemProps[3]");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("};");
            str.AppendLine("</script>");

            return str.ToString();
        }



        public string GetAdobeOrderCompletePageTag(List<CriteoProduct> listofCriteoProductIds, string couponString) //Order placedOrder, string couponString)
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            //
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("digitalData = {");
            str.AppendLine("            page: {");
            str.AppendLine("                pageInfo: {");
            str.AppendLine("                    pageName: \"order checkout|order confirmation\",");
            str.AppendLine("                    pageLoadEvent: \"purchase\"");
            str.AppendLine("                },");
            str.AppendLine("                category: {");
            str.AppendLine("                    pageType: \"checkout\",");
            str.AppendLine("                    primaryCategory: \"order checkout\",");
            str.AppendLine("                    subCategory1: \"order checkout|order confirmation\",");
            str.AppendLine("                    subCategory2: \"order checkout|order confirmation\"");
            str.AppendLine("                }");
            str.AppendLine("            },");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("            transaction: {");
            //str.AppendLine("transactionID:\"" + placedOrder.OrderNum + "\",");

            decimal orderBeforDiscountTotal = decimal.Zero;
            var couponCodeList = new List<string>();
            var itemTagForOrderedItems = GetItemsTagForOrderedItems(listofCriteoProductIds, ref couponCodeList, ref orderBeforDiscountTotal);

            str.AppendLine("item:[");
            str.AppendLine(itemTagForOrderedItems);
            str.AppendLine("],");

            str.AppendLine("                attributes: {");
            //str.AppendLine("paymentMethod:\"" + placedOrder.PaymentMethod + "\",");
            //if (!string.IsNullOrEmpty(placedOrder.CardType))
            //{
            //    var cardType = CreditCardType.GetCreditCardType(int.Parse(placedOrder.CardType)).CardType;
            //    str.AppendLine("paymentSubMethod:\"" + cardType + "\",");
            //}

            str.AppendLine("                    paymentGateway: \"Citrus\",");
            str.AppendLine("                    shippingMethod: \"free US mail/second day shipping/next day shipping\",");
            str.AppendLine("voucherAvailed:\"" + (couponCodeList.Count > 0 ? "yes" : "no") + "\"");
            str.AppendLine("                },");
            str.AppendLine("                total: {");
            //str.AppendLine("totalCartRevenue:" + Math.Round(placedOrder.OrderTotal, 2) + ",");
            //str.AppendLine("voucherCode:\"" + string.Join(",", couponCodeList.ToArray()) + "\",");
            str.AppendLine("voucherCode:\"" + couponString + "\",");
            str.AppendLine("totalDiscount:\"\",");
            //str.AppendLine("totalTaxPaid:" + Math.Round(placedOrder.OrderTax, 2) + ",");
            //str.AppendLine("totalShippingPaid:" + Math.Round(placedOrder.OrderShippingCosts, 2) + ",");
            str.AppendLine("actualCostPaid:0.00");
            str.AppendLine("                }");
            str.AppendLine("            }");
            str.AppendLine("        };");
            str.AppendLine("</script>");



            return str.ToString();

        }

        public string GetAdobeManufacturerTag()
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("var title = document.getElementsByTagName(\"title\")[0].innerHTML;");
            //str.AppendLine("var allSpans = document.getElementsByTagName('span');");
            //str.AppendLine("var onlyItemProps = [];");
            //str.AppendLine("var count = 0;");
            //str.AppendLine("");
            //str.AppendLine("    for(var i = 0; i < allSpans.length; i ++) {");
            //str.AppendLine("");
            //str.AppendLine("        if(allSpans[i].getAttribute(\"itemprop\") === 'name') {");
            //str.AppendLine("            count ++;");
            //str.AppendLine("            onlyItemProps.push(allSpans[i].innerHTML);");
            //str.AppendLine("        }");
            //str.AppendLine("    }");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:'Blinds manufacturer page',");
            str.AppendLine("pageLoadEvent:\"productview\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"Manufacturer Page\",");
            str.AppendLine("primaryCategory:\"Blinds\",");
            str.AppendLine("subCategory1: document.getElementsByTagName(\"h1\")[0].innerHTML ");
            //str.AppendLine("subCategory2:onlyItemProps[1],");
            //str.AppendLine("subCategory3:onlyItemProps[2]");
            //str.AppendLine("subCategory4:onlyItemProps[3]");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("};");
            str.AppendLine("</script>");

            return str.ToString();
        }

        private static string GetItemsTagForOrderedItems(IEnumerable<CriteoProduct> listofCriteoProductIds, ref List<string> couponCodeList, ref decimal orderBeforDiscountTotal)
        {
            var returnstr = "";

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var listofCriteoProductId in listofCriteoProductIds)
            {
                if (!string.IsNullOrEmpty(listofCriteoProductId.CPN_CODE) && !couponCodeList.Contains(listofCriteoProductId.CPN_CODE)) couponCodeList.Add(listofCriteoProductId.CPN_CODE);
                if (!string.IsNullOrEmpty(listofCriteoProductId.CPN_CODE2) && !couponCodeList.Contains(listofCriteoProductId.CPN_CODE2)) couponCodeList.Add(listofCriteoProductId.CPN_CODE2);
                if (!string.IsNullOrEmpty(listofCriteoProductId.CPN_CODE3) && !couponCodeList.Contains(listofCriteoProductId.CPN_CODE3)) couponCodeList.Add(listofCriteoProductId.CPN_CODE3);
                if (!string.IsNullOrEmpty(listofCriteoProductId.CPN_CODE4) && !couponCodeList.Contains(listofCriteoProductId.CPN_CODE4)) couponCodeList.Add(listofCriteoProductId.CPN_CODE4);
                orderBeforDiscountTotal += listofCriteoProductId.LineTotalBeforeDiscounts;

                returnstr +=
                    string.Format("{{ quantity:{0}, price:{1}, productInfo:{{ productType:\"{4}\", sku:\" {2} \", recommendationType:\"<RecommendationType>\", anchorProductSku:\"{3}\"}}}}", listofCriteoProductId.Quantity, listofCriteoProductId.Price, listofCriteoProductId.ProductId, listofCriteoProductId.ProductId, listofCriteoProductId.ProductType) + ",";
            }

            //remove the trailing commas
            returnstr = returnstr.TrimEnd(',');
            return returnstr;
        }



        public string GetAdobeHomePageTag()
        {

            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:\"home page\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"home\",");
            str.AppendLine("primaryCategory:\"home page\",");
            str.AppendLine("subCategory1:\"home page\",");
            str.AppendLine("subCategory2:\"home page\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("};");
            str.AppendLine("</script>");

            return str.ToString();
        }

        public string GetAdobePageTag(string pageName, AdobePageType pageType, AdobePrimaryCategoryType primaryCategoryType, List<AbobeSubCategory> subCategoryList)
        {
            return GetAdobePageTag(pageName, pageType, primaryCategoryType, subCategoryList, null);
        }
        public string GetAdobePageTag(string pageName, AdobePageType pageType, AdobePrimaryCategoryType primaryCategoryType, List<AbobeSubCategory> subCategoryList, string productid)
        {

            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine(string.Format("pageName:\"{0}\"", pageName));
            str.AppendLine("},");
            str.AppendLine("category:{");
            //str.AppendLine(string.Format("pageType:\"{0}\",", GetEnumDes(pageType)));
            //str.AppendLine(string.Format("primaryCategory:\"{0}\",", GetEnumDes(primaryCategoryType)));

            var pushOnlyItemPropsArrayStr = new StringBuilder();
            AbobeSubCategory endSubCategory = null;
            if (subCategoryList.Count > 0) endSubCategory = subCategoryList[subCategoryList.Count - 1];
            var iIndex = 0;
            foreach (var subCategory in subCategoryList)
            {
                if (subCategory == endSubCategory)
                {
                    if (subCategory != null)
                        str.AppendLine(string.Format("subCategory{0}:\"{1}\"", subCategory.Index, subCategory.Value.Replace("\"", "\\\"")));
                }
                else
                    str.AppendLine(string.Format("subCategory{0}:\"{1}\",", subCategory.Index, subCategory.Value.Replace("\"", "\\\"")));

                if (subCategory != null)
                {
                    var props = subCategory.Value.Replace("\"", "\\\"");
                    if (iIndex > 0) props = props.Replace(subCategoryList[iIndex - 1].Value, string.Empty).Replace("|", string.Empty).Trim();
                    props = props.Replace("\"", "\\\"");
                    pushOnlyItemPropsArrayStr.AppendFormat("onlyItemProps.push(\"{0}\");", props);
                }
                pushOnlyItemPropsArrayStr.AppendLine(string.Empty);
                iIndex++;
            }

            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("}");
            str.AppendLine("};");

            if (pageType == AdobePageType.ProductDetail && !string.IsNullOrEmpty(productid))
            {
                str.AppendLine("product:{");
                str.AppendLine("productInfo:{");
                str.AppendLine("sku: '" + productid + "'");
                str.AppendLine("}");
                str.AppendLine("var onlyItemProps = [];");
                str.Append(pushOnlyItemPropsArrayStr);
                str.AppendLine(GetAddtoCartPushEvent(productid, email));
            }

            str.AppendLine("</script>");

            return str.ToString();
        }

        public string GetAdobeCartPagTag(List<CriteoProduct> listofCriteoProductIds, string pageName)
        {
            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:\"cart summary page|shopping cart\",");
            str.AppendLine("pageLoadEvent:\"cartview\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"cart\",");
            str.AppendLine("primaryCategory:\"cart summary\",");
            str.AppendLine("subCategory1:\"cart summary|shopping cart\",");
            str.AppendLine("subCategory2:\"cart summary|shopping cart\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("cart:{");
            str.AppendLine("cartType:\"shoppingcart\",");
            var productList = GetProductStringForBasket(listofCriteoProductIds);
            str.AppendLine("item:[");

            str.AppendLine(productList);
            str.AppendLine("]");

            str.AppendLine("}");
            str.AppendLine("};");
            str.AppendLine("</script>");
            return str.ToString();

        }

        public string GetAdobeCheckOutPaymentPagTag(List<CriteoProduct> listofCriteoProductIds, string pageName)
        {

            var str = new StringBuilder();
            var email = GetHashedEmailOfLoggedInUser();
            str.AppendLine("<script type=\"text/javascript\">");
            str.AppendLine("digitalData={");
            str.AppendLine("page:{");
            str.AppendLine("pageInfo:{");
            str.AppendLine("pageName:\"order checkout|payment and order\",");
            str.AppendLine("pageLoadEvent:\"checkout payment\"");
            str.AppendLine("},");
            str.AppendLine("category:{");
            str.AppendLine("pageType:\"checkout\",");
            str.AppendLine("primaryCategory:\"order checkout\",");
            str.AppendLine("subCategory1:\"order checkout|payment and order\",");
            str.AppendLine("subCategory2:\"order checkout|payment and order\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("user:{");
            str.AppendLine("userInfo:{");
            var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
            str.AppendLine("authStatus:\"" + guestStatus + "\",");
            str.AppendLine("userID:\"" + email + "\"");
            str.AppendLine("}");
            str.AppendLine("},");
            str.AppendLine("cart:{");
            str.AppendLine("cartType:\"shoppingcart\",");
            var productList = GetProductStringForBasket(listofCriteoProductIds);
            str.AppendLine("item:[");

            str.AppendLine(productList);
            str.AppendLine("]");

            str.AppendLine("}");
            str.AppendLine("};");
            str.AppendLine("</script>");
            return str.ToString();
        }


        //public string GetAdobeCheckOutPaymentPagTag(List<CriteoProduct> listofCriteoProductIds, ShoppingCartType cartType)
        //{
        //    var pageName = string.Empty;
        //    var pageView = string.Empty;
        //    var pagePrimaryCategory = string.Empty;
        //    switch (cartType)
        //    {
        //        case ShoppingCartType.Default:
        //        case ShoppingCartType.ShoppingCart:
        //            pageName = "\"cart summary page|shopping cart\"";
        //            pageView = "\"cartview\"";
        //            pagePrimaryCategory = "\"cart summary\"";
        //            break;
        //        case ShoppingCartType.OrderCheckout:
        //            pageName = "\"order checkout|shipping and billing address\"";
        //            pageView = "\"checkout-start\"";
        //            pagePrimaryCategory = "\"order checkout\"";
        //            break;
        //        case ShoppingCartType.WishCart:
        //            pageName = "\"cart summary page|wishlist\"";
        //            pageView = "\"wishlistview\"";
        //            pagePrimaryCategory = "\"cart\"";
        //            break;
        //        case ShoppingCartType.RecurringCart:
        //            break;
        //        case ShoppingCartType.GiftRegistryCart:
        //            break;
        //        case ShoppingCartType.Samples:
        //            break;
        //        case ShoppingCartType.Quote:
        //            break;
        //        case ShoppingCartType.SaveForLater:
        //            pageName = "\"cart summary page|saved cart\"";
        //            pageView = "\"savedcartview\"";
        //            pagePrimaryCategory = "\"cart summary\"";
        //            break;
        //        case ShoppingCartType.WorkSheet:
        //            pageName = "\"cart summary page|worksheet\"";
        //            pageView = "\"worksheetview\"";
        //            pagePrimaryCategory = "\"cart summary\"";
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException("cartType", cartType, null);
        //    }


        //    var str = new StringBuilder();
        //    var email = GetHashedEmailOfLoggedInUser();
        //    str.AppendLine("<script type=\"text/javascript\">");
        //    str.AppendLine("digitalData={");
        //    str.AppendLine("page:{");
        //    str.AppendLine("pageInfo:{");
        //    str.AppendLine("pageName:" + pageName + ",");
        //    str.AppendLine("pageLoadEvent:" + pageView);
        //    str.AppendLine("},");
        //    str.AppendLine("category:{");
        //    str.AppendLine("pageType:\"cart\",");
        //    str.AppendLine("primaryCategory:" + pagePrimaryCategory + ",");
        //    str.AppendLine("subCategory1:" + pageName + ",");
        //    str.AppendLine("subCategory2:" + pageName);
        //    str.AppendLine("}");
        //    str.AppendLine("},");
        //    str.AppendLine("user:{");
        //    str.AppendLine("userInfo:{");
        //    var guestStatus = string.IsNullOrEmpty(email) ? "guest" : "registered";
        //    str.AppendLine("authStatus:\"" + guestStatus + "\",");
        //    str.AppendLine("userID:\"" + email + "\"");
        //    str.AppendLine("}");
        //    str.AppendLine("},");
        //    str.AppendLine("cart:{");
        //    str.AppendLine("cartType:\"" + cartType + "\",");
        //    var productList = GetProductStringForBasket(listofCriteoProductIds);
        //    str.AppendLine("item:[");

        //    str.AppendLine(productList);
        //    str.AppendLine("]");

        //    str.AppendLine("}");
        //    str.AppendLine("};");
        //    str.AppendLine("</script>");
        //    return str.ToString();
        //}

        private string GetProductStringForBasket(IEnumerable<CriteoProduct> listofCriteoProductIds)
        {
            //{ id: "142462", price: 29.09, quantity: 20},{ id: "142461", price: 29.09, quantity: 10}
            var returnstr = "";
            if (listofCriteoProductIds == null) return returnstr;
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var listofCriteoProductId in listofCriteoProductIds)
            {
                returnstr += "{productInfo:{ sku:\"" + listofCriteoProductId.ProductId + "\",productType:\"" + listofCriteoProductId.ProductType.Replace("'", "") + "\"}},";
            }

            //remove the trailing commas
            returnstr = returnstr.TrimEnd(',');

            return returnstr;
        }

        private string GetHashedEmailOfLoggedInUser()
        {
            if ((_loggedInCustomer != null) && (!_loggedInCustomer.IsAnonymous))
            {
                return StringHasher.HashThisString(_loggedInCustomer.Email);
            }
            return null;
        }


        //private static string GetEnumDes(Enum en)
        //{
        //    var type = en.GetType();
        //    var memInfo = type.GetMember(en.ToString());
        //    if (memInfo.Length <= 0) return en.ToString();
        //    var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        //    return attrs.Length > 0 ? ((DescriptionAttribute)attrs[0]).Description : en.ToString();
        //}
    }
}
