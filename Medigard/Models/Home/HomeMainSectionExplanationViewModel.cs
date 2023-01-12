using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionExplanationViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string SubTitle { get; set; }

        public static HomeMainSectionExplanationViewModel GetViewModel(HomeMainSectionExplanation model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionExplanationViewModel
            {
                
                Title = model.Title,
                Description = model.Description,
                SubTitle = model.SubTitle
            };
        }
    }
}
