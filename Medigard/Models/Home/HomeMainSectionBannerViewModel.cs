using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionBannerViewModel
    {
        public string Image { get; set; }

        public static HomeMainSectionBannerViewModel GetViewModel(HomeMainSectionBanner model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionBannerViewModel
            {
                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                
            };
        }
    }
}
