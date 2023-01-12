using CMS.DocumentEngine.Types.Medigard;
using DocumentFormat.OpenXml.EMMA;
using Medigard.Helpers;
using Medigard.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Medigard.Repositories.Menu
{
    public class MenuRepository
    {
        public MenuItemViewModel GetMenuItems(Guid guid, string culture, string siteName)
        {
            MenuItemViewModel menuItems = MenuItemProvider.GetMenuItem(guid, culture, siteName)
                .Published()
                .Select(
                x => new MenuItemViewModel
                {
                    Title = x.Title,
                    Description = x.Description,
                    Target = x.Target,
                    HasSocialMediaIcon = x.HasSocialMediaIcon,
                    HasImage = x.HasImage,
                    Image = MedigardAttachmentHelper.GetFullPath(x.MenuItemImage),
                   
                    Link = x.MenuLinkIsExternal ? x.MenuLinkExternal : MedigardUrlHelper.GetPageUrl(x.MenuLink, MultilanguageHelper.CultureCode),
                    MenuItems = GetMenuItems(x.NodeID, culture)
                })
                .FirstOrDefault();
            return menuItems;
        }
        private List<MenuItemViewModel> GetMenuItems(int nodeID, string culture)
        {
            var menuItems = MenuItemProvider.GetMenuItems().Published().Culture(culture).WhereEquals(nameof(CMS.DocumentEngine.TreeNode.NodeParentID), nodeID).OrderBy("NodeOrder").Select(
                x => new MenuItemViewModel
                {
                    Title = x.Title,
                    Description = x.Description,
                    Target = x.Target,
                    HasSocialMediaIcon = x.HasSocialMediaIcon,
                    HasImage = x.HasImage,
                    Image = MedigardAttachmentHelper.GetFullPath(x.MenuItemImage),
                    Link = x.MenuLinkIsExternal ? x.MenuLinkExternal : MedigardUrlHelper.GetPageUrl(x.MenuLink, MultilanguageHelper.CultureCode),
                    MenuItems = GetMenuItems(x.NodeID, culture)
                }).ToList();
            return menuItems;
        }
    }
}
