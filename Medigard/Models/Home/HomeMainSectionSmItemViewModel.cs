using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionSmItemViewModel
    {
        public string Image { get; set; }
        public string Explanation { get; set; }
        public string Comment { get; set; }
        public string Like { get; set; }
        public string Icon { get; set; }


        public static HomeMainSectionSmItemViewModel GetViewModel(HomeMainSectionSmItem model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionSmItemViewModel
            {

                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                Explanation = model.Explanation,
                Comment = model.Comment,
                Like = model.Like,
                Icon = MedigardAttachmentHelper.GetFullPath(model.Icon1),
            };
        }
    }
}
