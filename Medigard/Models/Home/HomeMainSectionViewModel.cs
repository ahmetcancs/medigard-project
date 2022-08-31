using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionViewModel
    {
        public string Image { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public IEnumerable<HomeMainSectionItemViewModel> IconList { get; set; }
        public static HomeMainSectionViewModel GetViewModel(HomeMainSection model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionViewModel
            {
                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                Title = model.Title,
                Description = model.Description,
                IconList = homeRepository.GetHomeMainSectionsItem("/home/home-main-section").Select(x => HomeMainSectionItemViewModel.GetViewModel(x))
            };
        }
    }
}
