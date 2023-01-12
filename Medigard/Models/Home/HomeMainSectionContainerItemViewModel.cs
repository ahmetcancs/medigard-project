using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionContainerItemViewModel
    {
        public string Item { get; set; }

        public string Description { get; set; }



        public static HomeMainSectionContainerItemViewModel GetViewModel(HomeMainSectionContainerItem model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionContainerItemViewModel
            {

                Item = model.Item1,
                Description = model.Description
            };
        }
    }
}
