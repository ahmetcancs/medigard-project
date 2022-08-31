using CMS.Core;
using CMS.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Helpers
{
    public class MedigardAttachmentHelper
    {
        private static Uri siteURL = new Uri("http://localhost:49433/Kentico13_1_Admin/");
        

        /// <summary>
        /// GetFullPath
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFullPath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {

                    if (!URLHelper.CheckPrefixes(ref path, new string[] { "http", "https" }, false))
                    {
                        return new Uri(siteURL+ path.Replace("~", string.Empty)).AbsoluteUri;
                    }
                }
                catch (Exception ex)
                {
                    Service.Resolve<IEventLogService>().LogException("MedigardAttachmentHelper", "GetFullPath", ex);
                }
                return path;

            }
            return string.Empty;
        }
        
    }
}

