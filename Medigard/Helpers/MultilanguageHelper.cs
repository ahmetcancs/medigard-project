using CMS.Helpers;
using System;

namespace Medigard.Helpers
{
    public static class MultilanguageHelper
    {

        public static string CultureCode { get => GetCultureCode(); }

        public static string GetCultureCode(string defaultCulture = "tr-TR")
        {
            var langCookie = CookieHelper.GetValue("CMSPreferredCulture");
            if (string.IsNullOrEmpty(langCookie))
            {
                langCookie = defaultCulture;
                CookieHelper.SetValue("CMSPreferredCulture", langCookie, DateTime.Now.AddYears(1));
            }
            return langCookie;
        }
    }
}
