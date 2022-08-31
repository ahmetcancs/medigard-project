using CMS.DocumentEngine.Types.Home;
using Medigard.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionFaqViewModel
    {
        public string Image1 { get; set; }

        public string Image2 { get; set; }


        public IEnumerable<HomeMainSectionFaqItemViewModel> ItemList { get; set; }

        public static HomeMainSectionFaqViewModel GetViewModel(HomeMainSectionFaq model, Repositories.Home.HomeRepository homeRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionFaqViewModel
            {

                Image1 = MedigardAttachmentHelper.GetFullPath(model.Image1),
                Image2 = MedigardAttachmentHelper.GetFullPath(model.Image2),
                ItemList = homeRepository.GetHomeMainSectionFaqItems("/home/home-main-section-faq").Select(x => HomeMainSectionFaqItemViewModel.GetViewModel(x))
            };
        }
    }
}