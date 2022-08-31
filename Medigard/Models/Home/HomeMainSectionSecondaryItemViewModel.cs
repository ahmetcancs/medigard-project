using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionSecondaryItemViewModel
    {
        public string Title { get; set; }


        public IEnumerable<HomeMainSectionChildItemsViewModel> ItemList  { get; set; }

    public static HomeMainSectionSecondaryItemViewModel GetViewModel(HomeMainSectionSecondaryItem model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionSecondaryItemViewModel
            {
                Title = model.Title,
                ItemList = homeRepository.GetHomeMainSectionChildsItem(model.NodeAliasPath).Select(x => HomeMainSectionChildItemsViewModel.GetViewModel(x))

            };
        }
    }
}
