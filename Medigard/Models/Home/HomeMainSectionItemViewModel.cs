using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionItemViewModel
    {
        public string Description { get; set; }

        public string Icon { get; set; }



        public static HomeMainSectionItemViewModel GetViewModel(HomeMainSectionItem model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionItemViewModel
            {
          
                Description= model.Description,
                Icon = model.Icon1
            };
        }
    }
}

