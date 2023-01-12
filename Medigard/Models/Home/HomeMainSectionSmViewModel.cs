using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionSmViewModel
    {
        public string  Description { get; set; }


        public IEnumerable<HomeMainSectionSmItemViewModel> ItemList { get; set; }
        public IEnumerable<HomeMainSectionSmIconViewModel> IconList { get; set; }

        public static HomeMainSectionSmViewModel GetViewModel(HomeMainSectionSm model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionSmViewModel
            {

                Description = model.Description,
                IconList = homeRepository.GetHomeMainSectionSmIcons("/home/home-main-section-sm").Select(x => HomeMainSectionSmIconViewModel.GetViewModel(x)),
                ItemList = homeRepository.GetHomeMainSectionSmItems("/home/home-main-section-sm").Select(x => HomeMainSectionSmItemViewModel.GetViewModel(x))
            };
        }
    }
}
