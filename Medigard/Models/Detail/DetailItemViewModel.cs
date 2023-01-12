using CMS.DocumentEngine.Types.Detail;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Detail
{
    public class DetailItemViewModel
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public static DetailItemViewModel GetViewModel(DetailItem model)
        {
            if (model == null)
            {
                return null;
            }

            return new DetailItemViewModel
            {
                
                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                Title = model.Title,
                Description = model.Description
            };
        }
    }
}
