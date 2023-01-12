using CMS.SiteProvider;
using Medigard.Helpers;
using Medigard.Repositories.Menu;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Medigard.Components.ViewComponents.Menu.Header
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly MenuRepository menuRepository;
        private readonly string siteName = SiteContext.CurrentSite.SiteName;
        private readonly string culture = MultilanguageHelper.CultureCode;
        public HeaderViewComponent(MenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }
        public IViewComponentResult Invoke()
        {
            var menuItems = menuRepository.GetMenuItems(new Guid("fdfd5361-1cf5-407f-839c-926ac91ed874"), culture, siteName);
            return View($"~/Components/ViewComponents/Menu/Header/Header.cshtml", menuItems);
        }
    }
}
