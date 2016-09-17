//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RoaSystems.Server
//{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;
    //using RoaSystems.Core.Business;
    using RoaSystems.Server.Cryptography;

    namespace RoaSystems.Server
    {
        [Serializable()]
        public class CriteoProduct
        {
            //id:" + " \"{0}\", price: {1}, quantity: 
            public string ProductId { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string ProductType { get; set; }

            //for order
            public string CPN_CODE { get; set; }
            public string CPN_CODE2 { get; set; }
            public string CPN_CODE3 { get; set; }
            public string CPN_CODE4 { get; set; }
            public decimal LineTotalBeforeDiscounts { get; set; }
        }
        public static class StringHasher
        {
            /// <summary>
            /// If you chose to pass hashed email addresses, use the following syntax (replace sample values highlighted in red) and make sure that the addresses are converted to lower case, 
            /// trimmed, converted to UTF-8 and finally hashed using the MD5 algorithm before they are passed into the tag: {event: "setHashedEmail", email: ["32312c1b6865d1adf04f79e2b731a49e"]}
            /// </summary>
            /// <param name="email"></param>
            /// <returns></returns>
            public static string HashThisString(string email)
            {
                IMd5Hasher md5Hasher = new Md5Hasher();
                using (var md5Hash = MD5.Create())
                {
                    string hash = md5Hasher.GetMd5Hash(md5Hash, email);
                    return hash;
                }

            }
        }



        public interface ICriteoController
        {
            string GetCriteoHomePageTag();
            string GetCriteoProductPageTag(List<string> listofCriteoProductIds);
            string GetCriteoProductDetailPageTag(string productid);
        }

        public class CriteoController : ICriteoController
        {
            //private readonly Customer _loggedInCustomer;
            // ReSharper disable once NotAccessedField.Local
            private readonly IMd5Hasher _md5Hasher;

            //public CriteoController(Customer loggedInCustomer, IMd5Hasher md5Hasher)
            //{
            //    _loggedInCustomer = loggedInCustomer;
            //    _md5Hasher = md5Hasher;
            //}

        public CriteoController(IMd5Hasher md5Hasher)
        {
            //_loggedInCustomer = loggedInCustomer;
            _md5Hasher = md5Hasher;
        }

        public string GetCriteoHomePageTag()
            {

                var str = new StringBuilder();

                str.AppendLine("<script type=\"text/javascript\" src=\"//static.criteo.net/js/ld/ld.js\" async=\"true\"></script>");
                str.AppendLine("<script type=\"text/javascript\">");
                str.AppendLine("window.criteo_q = window.criteo_q || [];");
                str.AppendLine("var deviceType= /iPad/.test(navigator.userAgent)?\"t\":/Mobile|iP(hone|od)|Android|BlackBerry|IEMobile|Silk/.test(navigator.userAgent)?\"m\":\"d\";");
                str.AppendLine("window.criteo_q.push(");
                str.AppendLine("{ event: \"setAccount\", account: 21623},");
                str.AppendLine("{ event: \"setSiteType\", type: deviceType},");
                var hashedEmail = GetHashedEmailOfLoggedInUser();
                str.AppendLine("{ event: \"setHashedEmail\", email: [\"" + hashedEmail + "\"]},");
                str.AppendLine("{ event: \"viewHome\"});");
                str.AppendLine("</script>");

                return str.ToString();
            }



            /// <summary>
            /// returns the email of the user if user is logged in
            /// </summary>
            /// <returns></returns>
            private string GetHashedEmailOfLoggedInUser()
            {
                //if ((_loggedInCustomer != null) && (!_loggedInCustomer.IsAnonymous))
                //{
                //    return StringHasher.HashThisString(_loggedInCustomer.Email);
                //}

                return null;
            }


            public string GetCriteoProductPageTag(List<string> listofCriteoProductIds)
            {
                var str = new StringBuilder();

                str.AppendLine("<script type=\"text/javascript\" src=\"//static.criteo.net/js/ld/ld.js\" async=\"true\"></script>");
                str.AppendLine("<script type=\"text/javascript\">");
                str.AppendLine("window.criteo_q = window.criteo_q || [];");
                str.AppendLine("var deviceType= /iPad/.test(navigator.userAgent)?\"t\":/Mobile|iP(hone|od)|Android|BlackBerry|IEMobile|Silk/.test(navigator.userAgent)?\"m\":\"d\";");
                str.AppendLine("window.criteo_q.push(");
                str.AppendLine("{ event: \"setAccount\", account: 21623},");
                str.AppendLine("{ event: \"setSiteType\", type: deviceType},");
                var hashedEmail = GetHashedEmailOfLoggedInUser();
                str.AppendLine("{ event: \"setHashedEmail\", email: [\"" + hashedEmail + "\"]},");
                var productList = GetProductList(listofCriteoProductIds);
                str.AppendLine("{ event: \"viewList\", item: [ " + productList + "] });");
                str.AppendLine("</script>");

                return str.ToString();
            }

            public string GetCriteoProductDetailPageTag(string productid)
            {
                var str = new StringBuilder();

                str.AppendLine("<script type=\"text/javascript\" src=\"//static.criteo.net/js/ld/ld.js\" async=\"true\"></script>");
                str.AppendLine("<script type=\"text/javascript\">");
                str.AppendLine("window.criteo_q = window.criteo_q || [];");
                str.AppendLine("var deviceType= /iPad/.test(navigator.userAgent)?\"t\":/Mobile|iP(hone|od)|Android|BlackBerry|IEMobile|Silk/.test(navigator.userAgent)?\"m\":\"d\";");
                str.AppendLine("window.criteo_q.push(");
                str.AppendLine("{ event: \"setAccount\", account: 21623},");
                str.AppendLine("{ event: \"setSiteType\", type: deviceType},");
                var hashedEmail = GetHashedEmailOfLoggedInUser();
                str.AppendLine("{ event: \"setHashedEmail\", email: [\"" + hashedEmail + "\"]},");

                str.AppendLine("{ event: \"viewItem\", item: \"" + productid + "\"" + "});");
                str.AppendLine("</script>");

                return str.ToString();
            }

            private static string GetProductStringForBasket(List<CriteoProduct> listofCriteoproductids)
            {
                //{ id: "142462", price: 29.09, quantity: 20},{ id: "142461", price: 29.09, quantity: 10}
                var returnstr = "";
                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var listofCriteoProductId in listofCriteoproductids)
                {
                    returnstr += string.Format("{{ id: '{0}' , price: {1} , quantity: {2} }},", listofCriteoProductId.ProductId, listofCriteoProductId.Price, listofCriteoProductId.Quantity);
                }

                //remove the trailing commas
                returnstr = returnstr.TrimEnd(',');
                return returnstr;
            }


            private static string GetProductStringForOrderComplete(List<CriteoProduct> listofCriteoproductids)//, Order placedOrder)
            {
                //{ id: "142462", price: 29.09, quantity: 20},{ id: "142461", price: 29.09, quantity: 10}
                var returnstr = "";
                // ReSharper disable once LoopCanBeConvertedToQuery
                //////foreach (var listofCriteoProductId in listofCriteoproductids)
                //////{
                //////    returnstr += string.Format("{{ id: '{0}' , price: {1} , quantity: {2} }},", listofCriteoProductId.ProductId, 0, listofCriteoProductId.Quantity);
                //////}

                //////returnstr += "{ id: \"TOTALVALUE\", price: " + placedOrder.OrderTotal + ", quantity: 1}";
                ////////remove the trailing commas
                //////returnstr = returnstr.TrimEnd(',');
                return returnstr;
            }

            private static string GetProductList(IEnumerable<string> listofCriteoProductIds)
            {
                var returnstr = "";

                // ReSharper disable once LoopCanBeConvertedToQuery
                foreach (var listofCriteoProductId in listofCriteoProductIds)
                {
                    returnstr += "\"" + listofCriteoProductId + "\"" + ",";
                }

                //remove the trailing commas
                returnstr = returnstr.TrimEnd(',');
                return returnstr;
            }

            public string GetCriteoCartPageTag(List<CriteoProduct> listofCriteoProductIds)
            {
                var str = new StringBuilder();

                str.AppendLine("<script type=\"text/javascript\" src=\"//static.criteo.net/js/ld/ld.js\" async=\"true\"></script>");
                str.AppendLine("<script type=\"text/javascript\">");
                str.AppendLine("window.criteo_q = window.criteo_q || [];");
                str.AppendLine("var deviceType= /iPad/.test(navigator.userAgent)?\"t\":/Mobile|iP(hone|od)|Android|BlackBerry|IEMobile|Silk/.test(navigator.userAgent)?\"m\":\"d\";");
                str.AppendLine("window.criteo_q.push(");
                str.AppendLine("{ event: \"setAccount\", account: 21623},");
                str.AppendLine("{ event: \"setSiteType\", type: deviceType},");
                var hashedEmail = GetHashedEmailOfLoggedInUser();
                str.AppendLine("{ event: \"setHashedEmail\", email: [\"" + hashedEmail + "\"]},");
                var productList = GetProductStringForBasket(listofCriteoProductIds);
                str.AppendLine("{ event: \"viewBasket\", item: [" + productList + "]});");
                str.AppendLine("</script>");

                return str.ToString();
            }


            public string GetCriteoOrderCompletePageTag(List<CriteoProduct> listofCriteoProductIds)//, Order placedOrder)
            {
                var str = new StringBuilder();

                str.AppendLine("<script type=\"text/javascript\" src=\"//static.criteo.net/js/ld/ld.js\" async=\"true\"></script>");
                str.AppendLine("<script type=\"text/javascript\">");
                str.AppendLine("window.criteo_q = window.criteo_q || [];");
                str.AppendLine("var deviceType= /iPad/.test(navigator.userAgent)?\"t\":/Mobile|iP(hone|od)|Android|BlackBerry|IEMobile|Silk/.test(navigator.userAgent)?\"m\":\"d\";");
                str.AppendLine("window.criteo_q.push(");
                str.AppendLine("{ event: \"setAccount\", account: 21623},");
                str.AppendLine("{ event: \"setSiteType\", type: deviceType},");
                var hashedEmail = GetHashedEmailOfLoggedInUser();
                str.AppendLine("{ event: \"setHashedEmail\", email: [\"" + hashedEmail + "\"]},");
                //var productList = GetProductStringForOrderComplete(listofCriteoProductIds, placedOrder);
                //str.AppendLine("{ event: \"trackTransaction\"," + "id: \"" + placedOrder.OrderNum + "\", item: [" + productList + "]});");
                str.AppendLine("</script>");

                return str.ToString();
            }
        }



    }

//}
