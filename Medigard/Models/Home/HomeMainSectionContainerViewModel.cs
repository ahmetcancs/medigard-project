using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionContainerViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public string Image2 { get; set; }

        public IEnumerable<HomeMainSectionContainerItemViewModel> ItemList { get; set; }

        public static HomeMainSectionContainerViewModel GetViewModel(HomeMainSectionContainer model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionContainerViewModel
            {

                Image = MedigardAttachmentHelper.GetFullPath(model.Image),
                Image2 = MedigardAttachmentHelper.GetFullPath(model.Image2),
                Title = model.Title,
                Description = model.Description,
                ItemList = homeRepository
                .GetHomeMainSectionsContainersItem("/home/home-main-section-container")
                .Select(x => HomeMainSectionContainerItemViewModel
                .GetViewModel(x))
            };
        }
    }
}
