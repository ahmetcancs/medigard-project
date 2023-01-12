using CMS.DocumentEngine.Types.Detail;
using Medigard.Helpers;
using Medigard.Repositories.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Detail
{
    public class DetailSliderViewModel
    {
        public string Banner { get; set; }

        

        public static DetailSliderViewModel GetViewModel(DetailSlider model)
        {
            if (model == null)
            {
                return null;
            }

            return new DetailSliderViewModel
            {

                Banner = MedigardAttachmentHelper.GetFullPath(model.Banner),
                

            };
        }
    }
}
