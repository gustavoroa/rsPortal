using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace RoaSystems.Core
{
    public static class Config
    {
    }
}

/*
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace StevesBlinds.Core
{
    public static class Config
    {

        public static int DisneyManufacturerId
        {
            get
            {
                int returnValue = 27;

                if (ConfigurationManager.AppSettings["DisneyManufacturerId"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["DisneyManufacturerId"], out returnValue);
                }

                return returnValue;
            }
        }
        public static int DisneyRollerProductID
        {
            get
            {
                int returnValue = 203;

                if (ConfigurationManager.AppSettings["DisneyRollerProductID"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["DisneyRollerProductID"], out returnValue);
                }

                return returnValue;
            }
        }
        public static int DisneyCellularProductID
        {
            get
            {
                int returnValue = 202;

                if (ConfigurationManager.AppSettings["DisneyCellularProductID"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["DisneyCellularProductID"], out returnValue);
                }

                return returnValue;
            }
        }

        // Added value

        public static int CartItemCount
        {
            get
            {
                int Count = 0;

                if (ConfigurationManager.AppSettings["CartItemCount"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["CartItemCount"], out Count);
                }


                return Count;
            }
        }



        public static bool EnableABTest
        {
            get
            {
                bool returnValue = false; // default to FALSE

                if (ConfigurationManager.AppSettings["EnableABTest"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EnableABTest"], out returnValue);
                }

                return returnValue;
            }
        }

        public static int ABTestThreshold
        {
            get
            {
                int returnValue = 10; // default to 10%

                if (ConfigurationManager.AppSettings["ABTestThreshold"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["ABTestThreshold"], out returnValue);
                }

                return returnValue;
            }
        }

        public static bool EnableTieredCouponCalculations
        {
            get
            {
                bool returnValue = true; // default to TRUE

                if (ConfigurationManager.AppSettings["EnableTieredCouponCalculations"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EnableTieredCouponCalculations"], out returnValue);
                }

                return returnValue;
            }
        }

        public static bool EnableMiniCartPreload
        {
            get
            {
                bool returnValue = true; // default to TRUE

                if (ConfigurationManager.AppSettings["EnableMiniCartPreload"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EnableMiniCartPreload"], out returnValue);
                }

                return returnValue;
            }
        }

        public static bool SaveCartsInCache
        {
            get
            {
                bool returnValue = true; // default to TRUE

                if (ConfigurationManager.AppSettings["SaveCartsInCache"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["SaveCartsInCache"], out returnValue);
                }

                return returnValue;
            }
        }

        public static bool UseFrontOfficeDB
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["UseFrontOfficeDB"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["UseFrontOfficeDB"], out returnValue);
                }

                return returnValue;
            }
        }


        /// <summary>
        /// Check for Cookieless browsers
        /// </summary>
        public static bool CheckForCookielessBrowsers
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["CheckForCookielessBrowsers"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["CheckForCookielessBrowsers"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Include Min Max Options For Blinds
        /// </summary>
        public static bool IncludeMinMaxOptionsForBlinds
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["IncludeMinMaxOptionsForBlinds"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["IncludeMinMaxOptionsForBlinds"], out returnValue);
                }

                return returnValue;
            }
        }

        public static bool EnableOptionValueVideosForBlinds
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["EnableOptionValueVideosForBlinds"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EnableOptionValueVideosForBlinds"], out returnValue);
                }

                return returnValue;
            }
        }


        public static string SessionTimedCacheMasterKey
        {
            get
            {
                return ConfigurationManager.AppSettings["SessionTimedCacheMasterKey"];
            }
        }

        public static string PreferredHost
        {
            get
            {
                return ConfigurationManager.AppSettings["PreferredHost"];
            }
        }

        public static bool IsSiteDown
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["IsSiteDown"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["IsSiteDown"]);
                }

                return returnValue;
            }
        }

        public static string GoogleAnalyticsAccountEcomm
        {
            get
            {
                string returnValue = String.Empty;

                if (ConfigurationManager.AppSettings["GoogleAnalyticsAccountEcomm"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GoogleAnalyticsAccountEcomm"];
                }

                return returnValue;
            }
        }

        public static string GoogleAnalyticsAccountLegacy
        {
            get
            {
                string returnValue = String.Empty;

                if (ConfigurationManager.AppSettings["GoogleAnalyticsAccountLegacy"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GoogleAnalyticsAccountLegacy"];
                }

                return returnValue;
            }
        }

        public static string DeploymentSource
        {
            get
            {
                string returnValue = "Development";

                if (ConfigurationManager.AppSettings["DeploymentSource"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["DeploymentSource"];
                }

                return returnValue;
            }
        }
        public static bool AllowCsrConsole
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["AllowCsrConsole"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["AllowCsrConsole"]);
                }

                return returnValue;
            }
        }

        public static string AllowedBotsForHawk
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AllowedBotsForHawk"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AllowedBotsForHawk"];
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Header name to look for to define a secure page
        /// </summary>
        public static string SecureHeaderName
        {
            get
            {
                return ConfigurationManager.AppSettings["SecureHeaderName"];
            }
        }

        private static string _connectionStringName = null;
        public static string ConnectionStringName
        {
            get
            {
                return (string.IsNullOrEmpty(_connectionStringName)) ? ConfigurationManager.AppSettings["ConnectionStringName"] : _connectionStringName;
            }
            set
            {
                _connectionStringName = value;
            }
        }
        private static string _connectionStringNameFODB = null;

        public static string WallpaperImagePathRoot
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Wallpaper_ImagePathRoot"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_ImagePathRoot"];
                }

                return returnValue;
            }
        }

        public static string ConnectionStringNameFODB
        {
            get
            {
                return (string.IsNullOrEmpty(_connectionStringNameFODB)) ? ConfigurationManager.AppSettings["ConnectionStringNameFODB"] : _connectionStringNameFODB;
            }
            set
            {
                _connectionStringNameFODB = value;
            }
        }

        public static string EmailAddressForErrors
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["EmailAddressForErrors"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EmailAddressForErrors"].ToString().Trim();
                }

                return returnValue;
            }
        }

        /// <summary>
        /// The Threshold percentage of order.  If dollar amount is within this percent, a suggestion
        /// is made to inform that for only xx more dollars they can get this many extra rolls.
        /// </summary>
        public static decimal WallpaperSuggestionPercentThreshold
        {
            get
            {
                Decimal returnValue = 0;

                if (ConfigurationManager.AppSettings["WallpaperSuggestionPercentThreshold"] != null)
                {
                    returnValue = decimal.Parse(ConfigurationManager.AppSettings["WallpaperSuggestionPercentThreshold"]);
                }

                return returnValue;
            }
        }

        public static string ConnString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            }
        }

        public static string ConnStringFODB
        {
            get
            {
                return ConfigurationManager.ConnectionStrings[ConnectionStringNameFODB].ConnectionString;
            }
        }

        public static string FromEmailAddress
        {
            get
            {
                return ConfigurationManager.AppSettings["FromEmailAddress"];
            }
        }

        public static string SMTPServer
        {
            get
            {
                return ConfigurationManager.AppSettings["SMTPServer"];
            }
        }

        public static string BlindsEmailAFriendSubject
        {
            get
            {
                return ConfigurationManager.AppSettings["BlindsEmailAFriendSubject"];
            }
        }

        /// <summary>
        /// BL_ManufacturerID for the Steve's Blinds brand/manufacturer
        /// </summary>
        public static int StevesBlindsBrandID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesBlindsBrandID"].ToString());
            }
        }

        #region Steves_Designer_series

        /// <summary>
        /// BL_ManufacturerID for the Steve's Blinds Drapes brand/manufacturer
        /// </summary>
        public static int StevesDesignerProductsBrandID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProductsBrandID"].ToString());
            }
        }

        /// <summary>
        /// BL_ManufacturerID for the Steve's Blinds Drapes brand/manufacturer
        /// </summary>
        public static int StevesDesignerProducts_CurtainsAndDrapers_ProductID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProducts_CurtainsAndDrapers_ProductID"].ToString());
            }
        }
        /// <summary>
        /// BL_ManufacturerID for the Steve's Blinds Drapes brand/manufacturer
        /// </summary>
        public static int StevesDesignerProducts_Sheers_ProductID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProducts_Sheers_ProductID"].ToString());
            }
        }
        public static int StevesDesignerProducts_AdjustableRods_ProductID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProducts_AdjustableRods_ProductID"].ToString());
            }
        }
        public static int StevesDesignerProducts_CustomRods_ProductID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProducts_CustomRods_ProductID"].ToString());
            }
        }
        public static int StevesDesignerProducts_Accessories_ProductID
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["StevesDesignerProducts_Accessories_ProductID"].ToString());
            }
        }


        #endregion















        /// <summary>
        /// Is Debug Mode
        /// </summary>
        public static bool IsDebugMode
        {
            get
            {
                bool returnValue = false;

                bool.TryParse(ConfigurationManager.AppSettings["IsDebugMode"], out returnValue);

                return returnValue;
            }
        }

        /// <summary>
        /// Is Logging On
        /// </summary>
        public static bool IsLoggingOn
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["IsLoggingOn"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["IsLoggingOn"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// DumpServerVariablesOnError
        /// </summary>
        public static bool DumpServerVariablesOnError
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["DumpServerVariablesOnError"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["DumpServerVariablesOnError"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// DumpServerVariablesOnError
        /// </summary>
        public static bool DumpSessionStateOnError
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["DumpSessionStateOnError"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["DumpSessionStateOnError"], out returnValue);
                }

                return returnValue;
            }
        }
        public static bool DumpSessionStateObjectSizeAndCountOnError
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["DumpSessionStateObjectSizeAndCountOnError"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["DumpSessionStateObjectSizeAndCountOnError"], out returnValue);
                }

                return returnValue;
            }
        }


        public static bool SaveWallpaperSearchesInSession
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["SaveWallpaperSearchesInSession"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["SaveWallpaperSearchesInSession"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// EmailAllErrors
        /// </summary>
        public static bool EmailAllErrors
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["EmailAllErrors"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EmailAllErrors"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Default width for blinds configuration
        /// </summary>
        public static decimal BlindsDefaultWidth
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["BlindsDefaultWidth"].ToString());
            }
        }

        /// <summary>
        /// Defualt height for blinds configuration
        /// </summary>
        public static decimal BlindsDefaultHeight
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["BlindsDefaultHeight"].ToString());
            }
        }
        /// <summary>
        /// Default width for drapes configuration
        /// </summary>
        public static decimal DrapesDefaultWidth
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["DrapesDefaultWidth"].ToString());
            }
        }
        /// <summary>
        /// Defualt height for drapes configuration
        /// </summary>
        public static decimal DrapesDefaultHeight
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["DrapesDefaultHeight"].ToString());
            }
        }
        /// <summary>
        /// Default width for rods configuration
        /// </summary>
        public static decimal RodsDefaultWidth
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["RodsDefaultWidth"].ToString());
            }
        }

        /// <summary>
        /// Defualt height for rods configuration
        /// </summary>
        public static decimal RodsDefaultHeight
        {
            get
            {
                return decimal.Parse(ConfigurationManager.AppSettings["RodsDefaultHeight"].ToString());
            }
        }

        /// <summary>
        /// Pattern that will be replaced in image paths in debug mode
        /// </summary>
        public static string ImagePathRootReplacementPattern
        {
            get
            {
                if (ConfigurationManager.AppSettings["ImagePathRootReplacementPattern"] != null)
                {
                    return ConfigurationManager.AppSettings["ImagePathRootReplacementPattern"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Folder containing wallpaper images
        /// </summary>
        public static string WallpaperImageFolder
        {
            get
            {
                if (ConfigurationManager.AppSettings["WallpaperImageFolder"] != null)
                {
                    return ConfigurationManager.AppSettings["WallpaperImageFolder"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Whether to hold Viewstate in Session or not
        /// </summary>
        public static bool ViewStateInSession
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["ViewStateInSession"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ViewStateInSession"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// Folder containing all blinds images
        /// </summary>
        public static string BlindsImageFolder
        {
            get
            {
                if (ConfigurationManager.AppSettings["BlindsImageFolder"] != null)
                {
                    return ConfigurationManager.AppSettings["BlindsImageFolder"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Folder containing blinds misc images
        /// </summary>
        public static string BlindsMiscImageFolder
        {
            get
            {
                if (ConfigurationManager.AppSettings["BlindsMiscImageFolder"] != null)
                {
                    return ConfigurationManager.AppSettings["BlindsMiscImageFolder"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static bool DisableEventHandler
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["DisableEventHandler"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["DisableEventHandler"], out returnValue);
                }

                return returnValue;
            }
        }

        public static string SourceBlindsList
        {
            get
            {
                if (ConfigurationManager.AppSettings["SourceBlindsList"] != null)
                {
                    return ConfigurationManager.AppSettings["SourceBlindsList"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public static string TargetBlindsList
        {
            get
            {
                if (ConfigurationManager.AppSettings["TargetBlindsList"] != null)
                {
                    return ConfigurationManager.AppSettings["TargetBlindsList"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string SourceWallpaperList
        {
            get
            {
                if (ConfigurationManager.AppSettings["SourceWallpaperList"] != null)
                {
                    return ConfigurationManager.AppSettings["SourceWallpaperList"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        public static string TargetWallpaperList
        {
            get
            {
                if (ConfigurationManager.AppSettings["TargetWallpaperList"] != null)
                {
                    return ConfigurationManager.AppSettings["TargetWallpaperList"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string ImagePathRootUnc
        {
            get
            {
                if (ConfigurationManager.AppSettings["ImagePathRootUNC"] != null)
                {
                    return ConfigurationManager.AppSettings["ImagePathRootUNC"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string CachePathRootUnc
        {
            get
            {
                if (ConfigurationManager.AppSettings["CachePathRootUNC"] != null)
                {
                    return ConfigurationManager.AppSettings["CachePathRootUNC"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Virtual directory that will host cached blinds and wallpaper images
        /// </summary>
        public static string CachedImagesVDir
        {
            get
            {
                return ConfigurationManager.AppSettings["CachedImagesVDir"];
            }
        }

        public static string CachedImagesAmazonAWSDomain
        {
            get
            {
                return ConfigurationManager.AppSettings["CachedImagesAmazonAWSDomain"];
            }
        }

        public static bool EnableAmazonAWSCloudFront
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["EnableAmazonAWSCloudFront"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EnableAmazonAWSCloudFront"], out returnValue);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Encrypt Key
        /// </summary>
        public static string EncryptKey
        {
            get
            {
                //  Require this key

                if (ConfigurationManager.AppSettings["EncryptKey"] == null)
                {
                    throw new System.Security.SecurityException("Encryption key is not set");
                }

                return ConfigurationManager.AppSettings["EncryptKey"];
            }
        }

        /// <summary>
        /// Cart Cookie Name
        /// </summary>
        public static string CartCookieName
        {
            get
            {
                if (ConfigurationManager.AppSettings["CartCookieName"] != null)
                {
                    return ConfigurationManager.AppSettings["CartCookieName"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static int SeenIntroCookieExpirationDays
        {
            get
            {

                int returnValue = int.MinValue;
                if (ConfigurationManager.AppSettings["SeenIntroCookieExpirationDays"] != null)
                {
                    returnValue = int.Parse(ConfigurationManager.AppSettings["SeenIntroCookieExpirationDays"].ToString());
                }

                return returnValue;
            }
        }

        public static string SeenIntroCookieName
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["SeenIntroCookieKey"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SeenIntroCookieKey"];
                }

                return returnValue;
            }
        }

        public static string SeenFloatOverPanelCookieKey
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["SeenFloatOverPanelCookieKey"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SeenFloatOverPanelCookieKey"];
                }

                return returnValue;
            }
        }

        public static string CanSeeFloatOverPanelReminderCookieKey
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["CanSeeFloatOverPanelReminderCookieKey"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CanSeeFloatOverPanelReminderCookieKey"];
                }

                return returnValue;
            }
        }



        /// <summary>
        /// Freight distribution for wallpaper
        /// 
        /// 1) = oldway
        /// 2) = new way
        /// </summary>
        public static WallpaperFreightDistributionType WallpaperFreightDistributionMethod
        {
            get
            {
                WallpaperFreightDistributionType returnValue = WallpaperFreightDistributionType.TotalQuantity;

                if (ConfigurationManager.AppSettings["WallpaperFreightDistributionMethod"] != null)
                {
                    returnValue = (WallpaperFreightDistributionType)int.Parse(ConfigurationManager.AppSettings["WallpaperFreightDistributionMethod"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Flag indicating if the cart items should be cleared after an order
        /// </summary>
        public static bool ClearCartItemsAfterOrder
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["ClearCartItemsAfterOrder"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ClearCartItemsAfterOrder"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Returns the relative path to the images for topics/content
        /// </summary>
        public static string TopicImagesRealativePath
        {
            get
            {
                if (ConfigurationManager.AppSettings["TopicImagesRealativePath"] != null)
                {
                    return ConfigurationManager.AppSettings["TopicImagesRealativePath"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Returns the suffix that's appended to the most recent version of a topic item
        /// </summary>
        public static string TopicVersionSuffix
        {
            get
            {
                if (ConfigurationManager.AppSettings["TopicVersionSuffix"] != null)
                {
                    return ConfigurationManager.AppSettings["TopicVersionSuffix"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }


        /// <summary>
        /// If this parameter is part of the URL they came from a link in the amazon data feed.
        /// </summary>
        public static string AmazonReferrerIDParameter
        {
            get
            {
                if (ConfigurationManager.AppSettings["AmazonReferrerIDParameter"] != null)
                {
                    return ConfigurationManager.AppSettings["AmazonReferrerIDParameter"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }



        /// <summary>
        /// Indicator if the pixels should be rendred or not
        /// </summary>
        public static bool RenderRimmKaufmanPixel
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["RenderRimmKaufmanPixel"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["RenderRimmKaufmanPixel"]);
                }

                return returnValue;
            }
        }


        /// <summary>
        /// Indicator if the pixels should be rendred or not
        /// </summary>
        public static bool RenderRimmKaufmanPixelMicro
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["RenderRimmKaufmanPixelMicro"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["RenderRimmKaufmanPixelMicro"]);
                }

                return returnValue;
            }
        }


        public static bool RimmKaufmanInTestMode
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["RimmKaufmanInTestMode"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["RimmKaufmanInTestMode"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Account information for loading the RKG data from the customers
        /// </summary>
        public static string RimmKaufmanOfflineString
        {
            get
            {
                if (ConfigurationManager.AppSettings["RimmKaufmanOfflineString"] != null)
                {
                    return ConfigurationManager.AppSettings["RimmKaufmanOfflineString"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string RimmKaufmanPixelURL
        {
            get
            {
                if (ConfigurationManager.AppSettings["RimmKaufmanPixelURL"] != null)
                {
                    return ConfigurationManager.AppSettings["RimmKaufmanPixelURL"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string RimmKaufmanPixelURLMicro
        {
            get
            {
                if (ConfigurationManager.AppSettings["RimmKaufmanPixelURLMicro"] != null)
                {
                    return ConfigurationManager.AppSettings["RimmKaufmanPixelURLMicro"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public static string RimmKaufmanMerchantID
        {
            get
            {
                if (ConfigurationManager.AppSettings["RimmKaufmanMerchantID"] != null)
                {
                    return ConfigurationManager.AppSettings["RimmKaufmanMerchantID"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }



        /// <summary>
        /// Wallpaper Markup Percent as a whole number (value is over 1)
        /// </summary>
        public static decimal WallpaperMarkupPercent
        {
            get
            {
                if (ConfigurationManager.AppSettings["WallpaperMarkupPercent"] != null)
                {
                    return decimal.Parse(ConfigurationManager.AppSettings["WallpaperMarkupPercent"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Blinds Markup Percent as a whole number (value is over 1)
        /// </summary>
        public static decimal BlindMarkupPercent
        {
            get
            {
                if (ConfigurationManager.AppSettings["BlindMarkupPercent"] != null)
                {
                    return decimal.Parse(ConfigurationManager.AppSettings["BlindMarkupPercent"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// The server used for pinging customer actions
        /// </summary>
        public static string PingerServer
        {
            get
            {
                if (ConfigurationManager.AppSettings["PingerServer"] != null)
                {
                    return ConfigurationManager.AppSettings["PingerServer"].ToLower();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// The number of days an item can be in a customers cart before it reprices with the latest data
        /// </summary>
        public static int DaysInCartUntillReprice
        {
            get
            {
                if (ConfigurationManager.AppSettings["DaysInCartUntillReprice"] != null)
                {
                    return int.Parse(ConfigurationManager.AppSettings["DaysInCartUntillReprice"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Indicates if a CSR must login before using the site
        /// </summary>
        public static bool ForceCSRLogin
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["ForceCSRLogin"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ForceCSRLogin"]);
                }

                return returnValue;
            }
        }



        /// <summary>
        /// Indicates if the Steve welcome message should be used or not
        /// </summary>
        public static bool ShowRovionVideo
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["ShowRovionVideo"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ShowRovionVideo"]);
                }

                return returnValue;
            }
        }

        public static bool ShowOurStevesVideo
        {
            get
            {
                bool returnValue = false; // this will make it assume that we want rov video only

                if (ConfigurationManager.AppSettings["ShowOurStevesVideo"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ShowOurStevesVideo"]);
                }

                return returnValue;
            }

        }


        /// <summary>
        /// Which Rovion video to show if ShowRovionVideo == true
        /// </summary>
        public static string RovionVideo
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RovionVideo"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RovionVideo"].ToString();
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the build number and server name should show in the footer
        /// </summary>
        public static bool ShowAssemblyInfo
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["ShowAssemblyInfo"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ShowAssemblyInfo"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// The email address that will be used to BCC steve's employees
        /// </summary>
        public static string StevesBccEmailAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["StevesBccEmailAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["StevesBccEmailAddress"].ToString();
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the site should send an exception email on a 404 error
        /// </summary>
        public static bool EmailExceptionOn404
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["EmailExceptionOn404"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["EmailExceptionOn404"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// Indicates if the Bill Me later payment method is active.
        /// </summary>
        public static bool BillMeLaterIsActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["BillMeLaterIsActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["BillMeLaterIsActive"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the Bill Me later paycapture lite is active.
        /// </summary>
        public static bool BillMeLaterPayCaptureLiteIsActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["BillMeLaterPayCaptureLiteIsActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["BillMeLaterPayCaptureLiteIsActive"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the Bill Me later payment method is active.
        /// </summary>
        public static bool BillMeLaterDevMode
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["BillMeLaterDevMode"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["BillMeLaterDevMode"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the Google Checkout payment method is active.
        /// </summary>
        public static bool GoogleCheckoutEnabled
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["GoogleCheckoutEnabled"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["GoogleCheckoutEnabled"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Indicates if the Google Checkout payment method is active.
        /// </summary>
        public static bool PayPalEnabledForCSRs
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["PayPalEnabledForCSRs"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["PayPalEnabledForCSRs"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// Indicates if the Google Checkout payment method is active.
        /// </summary>
        public static bool PayPalEnabledFromCart
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["PayPalEnabledFromCart"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["PayPalEnabledFromCart"]);
                }

                return returnValue;
            }
        }

        /// <summary>
        /// tracking pixels for ebay and others
        /// </summary>
        public static bool TrackingPixels
        {
            get
            {
                var returnValue = false;

                if (ConfigurationManager.AppSettings["ECN_TrackingPixels"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ECN_TrackingPixels"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// Indicates if the criteo tracking is enabled
        /// </summary>
        public static bool CriteoEnabled
        {
            get
            {
                return ((ConfigurationManager.AppSettings["EnableCriteo"] != null) && bool.Parse(ConfigurationManager.AppSettings["EnableCriteo"]));
            }
        }

        /// <summary>
        /// Indicates if the Your Amigo tracking is active.
        /// </summary>
        public static bool YourAmigoEnabled
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["YourAmigoEnabled"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["YourAmigoEnabled"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// Indicates if the cache should be bypassed for wallpaper pricing adjustments
        /// </summary>
        public static bool ByPassCacheForWallpaperPriceAdjustments
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["ByPassCacheForWallpaperPriceAdjustments"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["ByPassCacheForWallpaperPriceAdjustments"]);
                }

                return returnValue;
            }
        }
        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string EmailCartLinkDomain
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["EmailCartLinkDomain"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EmailCartLinkDomain"];
                }

                return returnValue;
            }
        }

        public static string ForcedDomain
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["ForcedDomain"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["ForcedDomain"];
                }

                return returnValue;
            }
        }

        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string WallpaperStatusReportTempFolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WallpaperStatusReportTempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WallpaperStatusReportTempFolder"];
                }

                return returnValue;
            }
        }

        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string CollectEmailAddressesTempFolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddressesTempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddressesTempFolder"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddressesBobbyFilePath
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddressesBobbyFilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddressesBobbyFilePath"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddresseFromAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddresseFromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddresseFromAddress"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddresseDistList
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddresseDistList"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddresseDistList"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddresseDistListCC
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddresseDistListCC"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddresseDistListCC"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddresseAlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddresseAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddresseAlertAddress"];
                }

                return returnValue;
            }
        }
        public static string CollectEmailAddresseTxtAlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["CollectEmailAddresseTxtAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CollectEmailAddresseTxtAlertAddress"];
                }

                return returnValue;
            }
        }


        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string WASR_FromAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WASR_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WASR_FromAddress"];
                }

                return returnValue;
            }
        }
        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string WASR_ToAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WASR_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WASR_ToAddress"];
                }

                return returnValue;
            }
        }
        /// <summary>
        /// THis setting will determine the domain of the emailed link to a cart
        /// </summary>
        public static string WASR_CCAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WASR_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WASR_CCAddress"];
                }

                return returnValue;
            }
        }
        /// <summary>
        /// This will get the interval the scheduler will wait between checkes of the schjule table
        /// </summary>
        public static string ServiceScheduleTimerMilliseconds
        {
            get
            {
                string returnValue = "60000"; // default

                if (ConfigurationManager.AppSettings["ServiceScheduleTimerMilliseconds"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["ServiceScheduleTimerMilliseconds"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Include Min Max Options For Blinds
        /// </summary>
        public static string RunImageServiceHere
        {
            get
            {
                string returnValue = "no"; // default

                if (ConfigurationManager.AppSettings["RunImageServiceHere"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RunImageServiceHere"];
                }

                return returnValue;
            }

        }
        public static string RunScheduleServiceHere
        {
            get
            {
                string returnValue = "no"; // default

                if (ConfigurationManager.AppSettings["RunScheduleServiceHere"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RunScheduleServiceHere"];
                }

                return returnValue;
            }

        }


        #region Job Scheduler

        public static string JOB_SCHEDULER_LOG_PATH
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["JOB_SCHEDULER_LOG_PATH"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["JOB_SCHEDULER_LOG_PATH"].ToString();
                }

                return returnValue;
            }
        }

        #endregion

        #region Site Map Report

        /// <summary>
        ///  Begin - SiteMapReport - Section
        /// </summary>

        public static string SiteMapReportTempFolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportTempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportTempFolder"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportBobbyFilePath
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportBobbyFilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportBobbyFilePath"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportFromAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportFromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportFromAddress"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportDistList
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportDistList"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportDistList"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportDistListCC
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportDistListCC"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportDistListCC"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportAlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportAlertAddress"];
                }

                return returnValue;
            }
        }
        public static string SiteMapReportTxtAlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["SiteMapReportTxtAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["SiteMapReportTxtAlertAddress"];
                }

                return returnValue;
            }
        }

        #endregion

        #region Power reviews product feed

        public static string PR_ProductFeed_TargetWebservers
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_TargetWebservers"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_TargetWebservers"];
                }

                return returnValue;
            }
        }
        public static string PR_ProductFeed_FilePath
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_FilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_FilePath"];
                }

                return returnValue;
            }
        }

        public static string PR_ProductFeed_FromAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_FromAddress"];
                }

                return returnValue;
            }
        }
        public static string PR_ProductFeed_CCAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_CCAddress"];
                }

                return returnValue;
            }
        }
        public static string PR_ProductFeed_ToAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_ToAddress"];
                }

                return returnValue;
            }
        }
        public static string PR_ProductFeed_FileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_FileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_FileName"];
                }

                return returnValue;
            }
        }
        public static string PR_OrderFeed_FileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_OrderFeed_FileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_OrderFeed_FileName"];
                }

                return returnValue;
            }
        }

        public static string PR_ProductFeed_AlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_AlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_AlertAddress"];
                }

                return returnValue;
            }
        }

        public static string PR_ProductFeed_TxtAlertAddress
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ProductFeed_TxtAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ProductFeed_TxtAlertAddress"];
                }

                return returnValue;
            }
        }


        public static string PR_FTP_URL
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_FTP_URL"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_FTP_URL"];
                }

                return returnValue;
            }
        }
        public static string PR_FTP_UID
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_FTP_UID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_FTP_UID"];
                }

                return returnValue;
            }
        }
        public static string PR_FTP_PWD
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_FTP_PWD"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_FTP_PWD"];
                }

                return returnValue;
            }
        }
        public static string PR_ZipFileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ZipFileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ZipFileName"];
                }

                return returnValue;
            }
        }

        public static string PR_TriggerFileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_TriggerFileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_TriggerFileName"];
                }

                return returnValue;
            }
        }


        public static string PR_ReviewSummarySubfolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ReviewSummarySubfolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ReviewSummarySubfolder"];
                }

                return returnValue;
            }
        }

        public static string PR_ReviewSummaryXMLFileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ReviewSummaryXMLFileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ReviewSummaryXMLFileName"];
                }

                return returnValue;
            }
        }
        public static string PR_ReviewSummaryXSDFileName
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PR_ReviewSummaryXSDFileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PR_ReviewSummaryXSDFileName"];
                }

                return returnValue;
            }
        }

        #endregion

        #region Power Reviews Store front switches

        public static string PowerReviewVersion
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PowerReviewVersion"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PowerReviewVersion"];
                }

                return returnValue;
            }
        }

        public static string PowerReviewsZipFolderLocal
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PowerReviewsZipFolderLocal"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PowerReviewsZipFolderLocal"];
                }

                return returnValue;
            }
        }
        public static string PowerReviewsZipFolderDev
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PowerReviewsZipFolderDev"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PowerReviewsZipFolderDev"];
                }

                return returnValue;
            }
        }
        public static string PowerReviewsZipFolderProd
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["PowerReviewsZipFolderProd"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PowerReviewsZipFolderProd"];
                }

                return returnValue;
            }
        }


        #endregion


        #region Rakuten LinkShare tracking settings for storefront

        public static bool RLSAffiliateNetworkActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["RLSAffiliateNetworkActive"]);
                }

                return returnValue;
            }
        }

        public static string RLSAffiliateNetworkMID
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkMID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLSAffiliateNetworkMID"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLSAffiliateNetworkIDParameter
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkIDParameter"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLSAffiliateNetworkIDParameter"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLSAffiliateNetworkPublisherIDParameter
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkPublisherIDParameter"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLSAffiliateNetworkPublisherIDParameter"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLSAffiliateNetworkCookieKey
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkCookieKey"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLSAffiliateNetworkCookieKey"].ToString();
                }

                return returnValue;
            }
        }

        public static int RLSAffiliateNetworkCookieExpirationDays
        {
            get
            {
                if (ConfigurationManager.AppSettings["RLSAffiliateNetworkCookieExpirationDays"] != null)
                {
                    return int.Parse(ConfigurationManager.AppSettings["RLSAffiliateNetworkCookieExpirationDays"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }


        public static string RLS_MID
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_MID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_MID"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLS_FTP_URL
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_FTP_URL"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_FTP_URL"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLS_FTP_UID
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_FTP_UID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_FTP_UID"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLS_FTP_PWD
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_FTP_PWD"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_FTP_PWD"].ToString();
                }

                return returnValue;
            }
        }



        #endregion




        #region Google Affiliate Network tracking settings for storeffront

        //
        //  google affiliate network settings
        //
        public static bool GoogleAffiliateNetworkActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["GoogleAffiliateNetworkActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["GoogleAffiliateNetworkActive"]);
                }

                return returnValue;
            }
        }

        public static string GoogleAffiliateNetworkIDParameter
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GoogleAffiliateNetworkIDParameter"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GoogleAffiliateNetworkIDParameter"].ToString();
                }

                return returnValue;
            }
        }

        public static string GoogleAffiliateNetworkPublisherIDParameter
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GoogleAffiliateNetworkPublisherIDParameter"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GoogleAffiliateNetworkPublisherIDParameter"].ToString();
                }

                return returnValue;
            }
        }

        public static string GoogleAffiliateNetworkCookieKey
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GoogleAffiliateNetworkCookieKey"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GoogleAffiliateNetworkCookieKey"].ToString();
                }

                return returnValue;
            }
        }

        public static int GoogleAffiliateNetworkCookieExpirationDays
        {
            get
            {
                if (ConfigurationManager.AppSettings["GoogleAffiliateNetworkCookieExpirationDays"] != null)
                {
                    return int.Parse(ConfigurationManager.AppSettings["GoogleAffiliateNetworkCookieExpirationDays"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        #endregion


        #region GAN internal report settings


        public static string GAN_TempFolder
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_TempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_TempFolder"].ToString();
                }

                return returnValue;
            }
        }

        public static string GAN_FromAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_FromAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string GAN_ToAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_ToAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string GAN_CCAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_CCAddress"].ToString();
                }

                return returnValue;
            }
        }





        #endregion

        #region BSDC internal report settings job: BlindsSetDefaultCollectionIdOnStylesBasedOnLowestPrice


        public static string BSDC_ExcludedCollectionIDs
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["BSDC_ExcludedCollectionIDs"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BSDC_ExcludedCollectionIDs"].ToString();
                }

                return returnValue;
            }
        }

        public static string BSDC_TempFolder
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["BSDC_TempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BSDC_TempFolder"].ToString();
                }

                return returnValue;
            }
        }

        public static string BSDC_FromAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["BSDC_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BSDC_FromAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string BSDC_ToAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["BSDC_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BSDC_ToAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string BSDC_CCAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["BSDC_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BSDC_CCAddress"].ToString();
                }

                return returnValue;
            }
        }





        #endregion

        #region Process AMAZON drop settings


        public static string AMAZON_RootDataFeedPath
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AMAZON_RootDataFeedPath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AMAZON_RootDataFeedPath"].ToString();
                }

                return returnValue;
            }
        }

        public static string AMAZON_DROP_FOLDER
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AMAZON_DROP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AMAZON_DROP_FOLDER"].ToString();
                }

                return returnValue;
            }
        }
        public static string AMAZON_DROP_ALERT_FROM
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AMAZON_DROP_ALERT_FROM"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AMAZON_DROP_ALERT_FROM"].ToString();
                }

                return returnValue;
            }
        }

        public static string AMAZON_DROP_ALERT_TO
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AMAZON_DROP_ALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AMAZON_DROP_ALERT_TO"].ToString();
                }

                return returnValue;
            }
        }


        #endregion

        #region Process GAN drop settings


        public static string GAN_RootDataFeedPath
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_RootDataFeedPath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_RootDataFeedPath"].ToString();
                }

                return returnValue;
            }
        }

        public static string GAN_DROP_FOLDER
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_DROP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_DROP_FOLDER"].ToString();
                }

                return returnValue;
            }
        }
        public static string GAN_DROP_ALERT_FROM
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_DROP_ALERT_FROM"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_DROP_ALERT_FROM"].ToString();
                }

                return returnValue;
            }
        }

        public static string GAN_DROP_ALERT_TO
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["GAN_DROP_ALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["GAN_DROP_ALERT_TO"].ToString();
                }

                return returnValue;
            }
        }

        #endregion

        #region Process RLS drop settings


        public static string RLS_RootDataFeedPath
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_RootDataFeedPath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_RootDataFeedPath"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLS_DROP_FOLDER
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_DROP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_DROP_FOLDER"].ToString();
                }

                return returnValue;
            }
        }
        public static string RLS_DROP_ALERT_FROM
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_DROP_ALERT_FROM"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_DROP_ALERT_FROM"].ToString();
                }

                return returnValue;
            }
        }

        public static string RLS_DROP_ALERT_TO
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RLS_DROP_ALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RLS_DROP_ALERT_TO"].ToString();
                }

                return returnValue;
            }
        }

        #endregion

        #region RPT_DateRangeSales

        public static string RPT_DateRangeSales_TempFolder
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RPT_DateRangeSales_TempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RPT_DateRangeSales_TempFolder"].ToString();
                }

                return returnValue;
            }
        }

        public static string RPT_DateRangeSales_FromAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RPT_DateRangeSales_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RPT_DateRangeSales_FromAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string RPT_DateRangeSales_ToAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RPT_DateRangeSales_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RPT_DateRangeSales_ToAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string RPT_DateRangeSales_CCAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["RPT_DateRangeSales_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["RPT_DateRangeSales_CCAddress"].ToString();
                }

                return returnValue;
            }
        }

        #endregion

        #region Process Vendor Tracking Information

        public static string sVendorTrackingInformationTempFolder
        {
            get
            {
                string returnValue = "";
                if (ConfigurationManager.AppSettings["VendorTrackingInformationTempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["VendorTrackingInformationTempFolder"];

                }
                return returnValue;

            }
        }
        public static string sVendorTrackingInformationInputFolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["VendorTrackingInformationInputFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["VendorTrackingInformationInputFolder"];
                }

                return returnValue;
            }
        }



        #endregion
        #region Value Wallpaper Job Settings

        public static string ValueWallpaperTempFolder
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["ValueWallpaperTempFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["ValueWallpaperTempFolder"];
                }

                return returnValue;
            }
        }

        public static string WallpaperCloseoutInputFilePath
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WallpaperCloseoutInputFilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WallpaperCloseoutInputFilePath"];
                }

                return returnValue;
            }
        }
        public static string WallpaperCloseoutOutputFilePath
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath"];
                }

                return returnValue;
            }
        }

        public static string WallpaperCloseoutOutputFilePath_NoInOurSystem
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath_NoInOurSystem"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath_NoInOurSystem"];
                }

                return returnValue;
            }
        }

        public static string WallpaperCloseoutOutputFilePath_NoImage
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath_NoImage"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WallpaperCloseoutOutputFilePath_NoImage"];
                }

                return returnValue;
            }
        }

        public static string Wallpaper_FromAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Wallpaper_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_FromAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string Wallpaper_ToAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Wallpaper_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_ToAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string Wallpaper_CCAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Wallpaper_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_CCAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string Wallpaper_CloseoutBooks
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Wallpaper_Closeoutbooks"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_Closeoutbooks"].ToString();
                }
                return returnValue;
            }
        }

        public static string Wallpaper_Closeout_trigger_filename
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Wallpaper_Closeout_trigger_filename"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Wallpaper_Closeout_trigger_filename"].ToString();
                }
                return returnValue;
            }
        }

        #endregion

        #region Catalog and samples fullfillment

        public static string Fullfillment_FromAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Fullfillment_FromAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Fullfillment_FromAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string Fullfillment_ToAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Fullfillment_ToAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Fullfillment_ToAddress"].ToString();
                }

                return returnValue;
            }
        }
        public static string Fullfillment_CCAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Fullfillment_CCAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Fullfillment_CCAddress"].ToString();
                }

                return returnValue;
            }
        }
        public static string Fullfillment_FilePath
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["Fullfillment_FilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Fullfillment_FilePath"].ToString();
                }

                return returnValue;
            }
        }


        public static string CatalogAndSampleRequestDropFilePath
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["CatalogAndSampleRequestDropFilePath"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CatalogAndSampleRequestDropFilePath"].ToString();
                }

                return returnValue;
            }
        }
        public static string CatalogAndSampleRequestDropFolder
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["CatalogAndSampleRequestDropFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["CatalogAndSampleRequestDropFolder"].ToString();
                }

                return returnValue;
            }
        }

        #endregion

        public static string AlertTextingAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AlertTextingAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AlertTextingAddress"].ToString();
                }

                return returnValue;
            }
        }




        #region Amazon Checkout Settings

        /// <summary>
        /// Is Amazon Checkout Turned on?
        /// </summary>
        public static bool AmazonCheckoutIsActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["AmazonCheckoutIsActive"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["AmazonCheckoutIsActive"], out returnValue);
                }

                return returnValue;
            }
        }

        public static string AmazonCheckoutIsLiveOrDev
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["AmazonCheckoutIsLiveOrDev"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AmazonCheckoutIsLiveOrDev"];
                }

                return returnValue;
            }
        }

        public static string AmazonCheckoutOrderCallbackEndpoint
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["AmazonCheckoutOrderCallbackEndpoint"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AmazonCheckoutOrderCallbackEndpoint"];
                }

                return returnValue;
            }
        }

        /// <summary>
        /// Returns the Amazon Merchant ID (live and sandbox)
        /// </summary>
        public static string AmazonMerchantID
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["AmazonMerchantID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AmazonMerchantID"];
                }

                return returnValue;
            }
        }

        public static string AmazonAWSAccessKeyID
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["AmazonAWSAccessKeyID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AmazonAWSAccessKeyID"];
                }

                return returnValue;
            }
        }


        #endregion


        #region Wallpaper Inventory Drop settings

        public static string WALLPAPER_INVENTORY_DROP_FOLDER
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_FOLDER"];
                }

                return returnValue;
            }
        }

        public static string WALLPAPER_INVENTORY_DROP_ALERT_FROM
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_ALERT_FROM"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_ALERT_FROM"];
                }

                return returnValue;
            }
        }
        public static string WALLPAPER_INVENTORY_DROP_ALERT_TO
        {
            get
            {
                string returnValue = "";

                if (ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_ALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["WALLPAPER_INVENTORY_DROP_ALERT_TO"];
                }

                return returnValue;
            }
        }


        #endregion


        #region Monitored Error Email Job



        public static string MEE_account
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_account"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_account"].ToString();
                }

                return returnValue;
            }
        }

        public static string MEE_address
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_address"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_address"].ToString();
                }

                return returnValue;
            }
        }

        public static string MEE_password
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_password"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_password"].ToString();
                }

                return returnValue;
            }
        }

        public static string MEE_SubfolderToMontior
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_SubfolderToMontior"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_SubfolderToMontior"].ToString();
                }

                return returnValue;
            }
        }

        public static int MEE_TenMinuteThreshold
        {
            get
            {
                if (ConfigurationManager.AppSettings["MEE_TenMinuteThreshold"] != null)
                {
                    return int.Parse(ConfigurationManager.AppSettings["MEE_TenMinuteThreshold"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        public static int MEE_SixtyMinuteThreshold
        {
            get
            {
                if (ConfigurationManager.AppSettings["MEE_SixtyMinuteThreshold"] != null)
                {
                    return int.Parse(ConfigurationManager.AppSettings["MEE_SixtyMinuteThreshold"].ToString());
                }
                else
                {
                    return 0;
                }
            }
        }

        public static string MEE_AlertAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_AlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_AlertAddress"].ToString();
                }

                return returnValue;
            }
        }

        public static string MEE_TxtAlertAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MEE_TxtAlertAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MEE_TxtAlertAddress"].ToString();
                }

                return returnValue;
            }
        }



        #endregion


        #region Process Catalog Order Request

        public static string PCOR_DROP_FOLDER
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["PCOR_DROP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PCOR_DROP_FOLDER"].ToString();
                }

                return returnValue;
            }
        }

        public static string PCOR_DROP_ALERT_FROM
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["PCOR_DROP_ALERT_FROM"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PCOR_DROP_ALERT_FROM"].ToString();
                }

                return returnValue;
            }
        }
        public static string PCOR_DROP_ALERT_TO
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["PCOR_DROP_ALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PCOR_DROP_ALERT_TO"].ToString();
                }

                return returnValue;
            }
        }

        public static string PCOR_DROP_TXTALERT_TO
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["PCOR_DROP_TXTALERT_TO"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PCOR_DROP_TXTALERT_TO"].ToString();
                }

                return returnValue;
            }
        }

        public static string PCOR_DROP_SalesAddress
        {
            get
            {
                string returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["PCOR_DROP_SalesAddress"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["PCOR_DROP_SalesAddress"].ToString();
                }

                return returnValue;
            }
        }



        #endregion

        #region hi conversion

        public static bool EnableHiConversionScript
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["EnableHiConversionScript"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["EnableHiConversionScript"]);
                }

                return returnValue;
            }
        }


        #endregion

        #region worksheet switches


        public static bool WorkSheetEnabled
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["WorkSheetEnabled"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["WorkSheetEnabled"]);
                }

                return returnValue;
            }
        }

        #endregion

        #region EDI Switches

        public static string EDI_PROCESSING_FOLDER
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_PROCESSING_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_PROCESSING_FOLDER"].ToString();
                }
                return returnValue;
            }
        }

        public static string MariakConfirmation_File
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Mariak_Confirmation_File"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Mariak_Confirmation_File"].ToString();
                }
                return returnValue;
            }
        }


        public static string MariakInvoice_and_Shipping_File
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Mariak_Invoice_and_Shipping_File"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Mariak_Invoice_and_Shipping_File"].ToString();
                }
                return returnValue;
            }
        }

        public static string PatricianInvoice_and_Shipping_File
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Patrician_Invoice_and_Shipping_File"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Patrician_Invoice_and_Shipping_File"].ToString();
                }
                return returnValue;
            }
        }
        public static string PatricianConfirmation_File
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Patrician_Confirmation_File"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Patrician_Confirmation_File"].ToString();
                }
                return returnValue;
            }
        }

        public static int PatricianDistributorId
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Patrician_DistributorId"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Patrician_DistributorId"].ToString();
                }
                return Convert.ToInt32(returnValue);
            }
        }


        public static int MariakDistributorId
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["Mariak_DistributorId"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["Mariak_DistributorId"].ToString();
                }
                return Convert.ToInt32(returnValue);
            }
        }

        public static string EDI_FROM_ADDRESS
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_FROM_ADDRESS"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_FROM_ADDRESS"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_TO_ADDRESSES
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_TO_ADDRESSES"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_TO_ADDRESSES"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_CC_ADDRESSES
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_CC_ADDRESSES"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_CC_ADDRESSES"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_TO_TXT_ADDRESSES
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_TO_TXT_ADDRESSES"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_TO_TXT_ADDRESSES"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_DEV_EMAIL
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_DEV_EMAIL"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_DEV_EMAIL"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_CS_EMAIL
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_CS_EMAIL"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_CS_EMAIL"].ToString();
                }
                return returnValue;
            }
        }

        public static bool EDI_BALI_TEST_MODE
        {
            get
            {
                bool returnValue = true;

                if (ConfigurationManager.AppSettings["EDI_BALI_TEST_MODE"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["EDI_BALI_TEST_MODE"], out returnValue);
                }

                return returnValue;
            }
        }

        public static string EDI_VENDOR_EMAIL_ADDRESS_MARIAK
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_VENDOR_EMAIL_ADDRESS_MARIAK"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_VENDOR_EMAIL_ADDRESS_MARIAK"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_MARIAK_FTP_URL
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_MARIAK_FTP_URL"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_MARIAK_FTP_URL"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_MARIAK_FTP_USER_ID
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_MARIAK_FTP_USER_ID"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_MARIAK_FTP_USER_ID"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_MARIAK_FTP_PASSWORD
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_MARIAK_FTP_PASSWORD"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_MARIAK_FTP_PASSWORD"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_MARIAK_DROPS
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_MARIAK_DROPS"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_MARIAK_DROPS"].ToString();
                }
                return returnValue;
            }
        }

        public static string EDI_UPS_DROPS
        {
            get
            {
                string returnValue = string.Empty;
                if (ConfigurationManager.AppSettings["EDI_UPS_DROPS"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["EDI_UPS_DROPS"].ToString();
                }
                return returnValue;
            }
        }


        public static decimal EDI_VARIANCE_AMOUNT
        {
            get
            {
                decimal returnValue = decimal.MinValue;

                if (ConfigurationManager.AppSettings["EDI_VARIANCE_AMOUNT"] != null)
                {
                    decimal.TryParse(ConfigurationManager.AppSettings["EDI_VARIANCE_AMOUNT"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static bool SpringsGraberEDIActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["SpringsGraberEDIActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["SpringsGraberEDIActive"]);
                }

                return returnValue;
            }
        }


        #endregion

        #region throttle settings

        public static bool RequestRateThrottleActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["RequestRateThrottleActive"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["RequestRateThrottleActive"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }
        public static bool ErrorRateThrottleActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["ErrorRateThrottleActive"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["ErrorRateThrottleActive"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static int RequestsPerSecondSpanSeconds
        {
            get
            {
                int returnValue = 0;

                if (ConfigurationManager.AppSettings["RequestsPerSecondSpanSeconds"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["RequestsPerSecondSpanSeconds"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static decimal RequestsPerSecond
        {
            get
            {
                decimal returnValue = decimal.MinValue;

                if (ConfigurationManager.AppSettings["RequestsPerSecond"] != null)
                {
                    decimal.TryParse(ConfigurationManager.AppSettings["RequestsPerSecond"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static decimal RequestsPerSecondWithErrors
        {
            get
            {
                decimal returnValue = decimal.MinValue;

                if (ConfigurationManager.AppSettings["RequestsPerSecondWithErrors"] != null)
                {
                    decimal.TryParse(ConfigurationManager.AppSettings["RequestsPerSecondWithErrors"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static decimal RequestsWithErrorsCountThreshold
        {
            get
            {
                decimal returnValue = decimal.MinValue;

                if (ConfigurationManager.AppSettings["RequestsWithErrorsCountThreshold"] != null)
                {
                    decimal.TryParse(ConfigurationManager.AppSettings["RequestsWithErrorsCountThreshold"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static int RequestsWithErrorsBlockedForMinutes
        {
            get
            {
                int returnValue = 0;

                if (ConfigurationManager.AppSettings["RequestsWithErrorsBlockedForMinutes"] != null)
                {
                    int.TryParse(ConfigurationManager.AppSettings["RequestsWithErrorsBlockedForMinutes"].ToString(), out returnValue);
                }


                return returnValue;
            }
        }

        public static string BlockedNotifyList
        {
            get
            {
                string returnValue = "support@stevesblinds.com";

                if (ConfigurationManager.AppSettings["BlockedNotifyList"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BlockedNotifyList"].ToString();
                }


                return returnValue;
            }
        }

        public static string BlockedNotifyListTxt
        {
            get
            {
                string returnValue = "2483103635@vtext.com";

                if (ConfigurationManager.AppSettings["BlockedNotifyListTxt"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["BlockedNotifyListTxt"].ToString();
                }


                return returnValue;
            }
        }

        #endregion


        #region Mariak EDI

        public static bool MariakEDIActive
        {
            get
            {
                bool returnValue = false;

                if (ConfigurationManager.AppSettings["MariakEDIActive"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["MariakEDIActive"]);
                }

                return returnValue;
            }
        }

        public static bool AdobeTrackingEnabled
        {
            get
            {
                var returnValue = false;

                if (ConfigurationManager.AppSettings["AdobeTrackingEnabled"] != null)
                {
                    returnValue = bool.Parse(ConfigurationManager.AppSettings["AdobeTrackingEnabled"]);
                }

                return returnValue;
            }
        }

        public static string AdobeSourceLocation
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["AdobeSourceLocation"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["AdobeSourceLocation"];
                }

                return returnValue;
            }

        }

        #endregion



        #region Mariak Full Shipped Items


        public static string MK_FIS_ExpectedFileName
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_ExpectedFileName"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_ExpectedFileName"];
                }

                return returnValue;
            }

        }

        // Apr/2016 Added by Gus Roa.
        /// <summary>
        /// Gets the config value for the folder where the full shiped items files are located and awaiting to be processed
        /// </summary>
        public static string MK_FIS_InboxFolder
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_InboxFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_InboxFolder"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the folder where the full shiped items files droped when they had been sucessfully processed
        /// </summary>
        public static string MK_FIS_ProcessedFolder
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_ProcessedFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_ProcessedFolder"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the folder where the full shiped items files droped when they had been sucessfully processed and at least one error occurred
        /// </summary>
        public static string MK_FIS_FailedFolder
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_FailedFolder"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_FailedFolder"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the sender email for the report of failed items in the full shiped items
        /// </summary>
        public static string MK_FIS_From
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_From"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_From"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the recipient of the email for the report of failed items in the full shiped items
        /// </summary>
        public static string MK_FIS_To
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_To"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_To"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the CC recipients of the email for the report of failed items in the full shiped items
        /// </summary>
        public static string MK_FIS_CC
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FIS_CC"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FIS_CC"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the folder where is placed the report for full shiped items files sucessfully processed
        /// </summary>
        public static string MK_SuccessfulFilesRerport_NamePattern
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_SuccessfulFilesRerport_NamePattern"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_SuccessfulFilesRerport_NamePattern"];
                }

                return returnValue;
            }

        }
        /// <summary>
        /// Gets the config value for the pattern file name for the failed files report
        /// </summary>
        public static string MK_FailedFilesReport_NamePattern
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MK_FailedFilesReport_NamePattern"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MK_FailedFilesReport_NamePattern"];
                }

                return returnValue;
            }

        }

        public static bool FtpEnabledSilverPop
        {
            get
            {
                var returnValue = false;

                if (ConfigurationManager.AppSettings["FtpEnabledSilverPop"] != null)
                {
                    returnValue = (ConfigurationManager.AppSettings["FtpEnabledSilverPop"] == "1");
                }

                return returnValue;
            }

        }

        #endregion


        #region Emails for Marketing
        // Jun/2016 Added by Gus Roa.
        /// <summary>
        /// Gets the config value for the FTP address
        /// </summary>
        public static string MKT_FTP_ADDRESS
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MKT_FTP_ADDRESS"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MKT_FTP_ADDRESS"];
                }

                return returnValue;
            }

        }        
        
        /// <summary>
        /// Gets the config value for the FTP User name
        /// </summary>
        public static string MKT_FTP_USERNAME
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MKT_FTP_USERNAME"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MKT_FTP_USERNAME"];
                }

                return returnValue;
            }

        }

        /// <summary>
        /// Gets the config value for the folder for all the files
        /// </summary>
        public static string MKT_FTP_FOLDER
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MKT_FTP_FOLDER"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MKT_FTP_FOLDER"];
                }

                return returnValue;
            }

        }        
        
        /// <summary>
        /// Gets the config value for the Log file path
        /// </summary>
        public static string MKT_FTP_LOGFILE_PATH
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MKT_FTP_LOGFILE_PATH"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MKT_FTP_LOGFILE_PATH"];
                }

                return returnValue;
            }

        }        
        
        /// <summary>
        /// Gets the config value for the FTP User password
        /// </summary>
        public static string MKT_FTP_PASSWORD
        {
            get
            {
                var returnValue = string.Empty;

                if (ConfigurationManager.AppSettings["MKT_FTP_PASSWORD"] != null)
                {
                    returnValue = ConfigurationManager.AppSettings["MKT_FTP_PASSWORD"];
                }

                return returnValue;
            }

        }

        public static int SendEmailToCustomerFromFullShippedJob
        {
            get
            {
                var returnValue = 0;

                if (ConfigurationManager.AppSettings["SendEmailToCustomerFromFullShippedJob"] != null)
                {
                    returnValue = Convert.ToInt32(ConfigurationManager.AppSettings["SendEmailToCustomerFromFullShippedJob"]);
                }

                return returnValue;
            }
        }

        public static bool SendEmailViaDatabase
        {
            get
            {
                var returnValue = false; // default to FALSE

                if (ConfigurationManager.AppSettings["SendEmailViaDatabase"] != null)
                {
                    bool.TryParse(ConfigurationManager.AppSettings["SendEmailViaDatabase"], out returnValue);
                }

                return returnValue;
            }
        }

        #endregion

    }

    public enum WallpaperFreightDistributionType : int
    {
        TotalQuantity = 1,
        CaseQuantityEachQuantity = 2
    }









}



    */
