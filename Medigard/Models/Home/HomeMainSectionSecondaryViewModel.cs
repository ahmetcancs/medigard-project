using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionSecondaryViewModel
    {


        public IEnumerable<HomeMainSectionSecondaryItemViewModel> ItemList { get; set; }
        

        public static HomeMainSectionSecondaryViewModel GetViewModel(HomeMainSectionSecondary model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }
            var itemList = homeRepository.GetHomeMainSectionsSecondariesItem(model.NodeAliasPath);
            var returnModel = itemList.Select(x => HomeMainSectionSecondaryItemViewModel.GetViewModel(x, homeRepository));

            return new HomeMainSectionSecondaryViewModel
            {

                ItemList = returnModel
            };
        }
    }
}
