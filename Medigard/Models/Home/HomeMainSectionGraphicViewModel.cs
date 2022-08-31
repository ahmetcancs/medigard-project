using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionGraphicViewModel
    {
        public string Title { get; set; }

        public string Description1 { get; set; }

        public string Image { get; set; }

        public string Description2 { get; set; }

        public string SubTitle { get; set; }


        public static HomeMainSectionGraphicViewModel GetViewModel(HomeMainSectionGraphic model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionGraphicViewModel
            {
                Title = model.Title,
                Description1 = model.Description1,
                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                Description2 = model.Description2,
                SubTitle = model.SubTitle
                
            };
        }



    }

}
