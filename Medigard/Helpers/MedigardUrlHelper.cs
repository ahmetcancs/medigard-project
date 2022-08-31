using CMS.DocumentEngine;
using CMS.SiteProvider;
using System.Linq;

namespace Medigard.Helpers
{

        public static class MedigardUrlHelper
        {
            private static string siteURL = SiteInfoProvider.ProviderObject.Get(SiteContext.CurrentSiteName).SitePresentationURL;
            public static string GetPageUrl(TreeNode node)
            {
                return (node != null) ? DocumentURLProvider.GetAbsoluteUrl(node).Replace(siteURL, string.Empty) : string.Empty;
            }
            public static string GetPageUrl(string nodeGUID, string culture = "tr-TR")
            {
                if (!string.IsNullOrEmpty(nodeGUID) && !string.IsNullOrEmpty(culture))
                {
                    TreeNode _node = DocumentHelper.GetDocuments()
                        .WhereEquals("NodeGUID", nodeGUID)
                        .Culture(culture)
                        .FirstOrDefault();

                    var url = GetPageUrl(_node);
                    return url;
                }
                return string.Empty;
            
        }
    }
}