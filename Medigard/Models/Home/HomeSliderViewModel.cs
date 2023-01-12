using CMS.DocumentEngine.Types.Medigard;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeSliderViewModel
    {
        public string MainImage { get; set; }

        public string Image1 { get; set; }

        public string Image2 { get; set; }

        public static HomeSliderViewModel GetViewModel(HomeSlider model )
        {
            if (model == null)
            {
                return null;
            }

            return new HomeSliderViewModel
            {
                Image1 = MedigardAttachmentHelper.GetFullPath(model.Image1),
                Image2 = MedigardAttachmentHelper.GetFullPath(model.Image2),
                MainImage = MedigardAttachmentHelper.GetFullPath(model.MainImage),
            };
        }
    }
}
