using CMS.DocumentEngine;
using System.Linq;
using CMS.DocumentEngine.Types.Medigard;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Medigard.Controllers;
using Medigard.Models.Home;
using Medigard.Repositories.Home;
using Microsoft.AspNetCore.Mvc;
using CMS.DocumentEngine.Types.Home;

[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController),ActionName = "Index")] 

namespace Medigard.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly HomeRepository homeRepository;

        public HomeController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, HomeRepository homeRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.homeRepository = homeRepository;
        }

        public IActionResult Index()
        {
            
            var homeSections = homeRepository.GetHomeSections("/home/home-slider").FirstOrDefault();
            var homeMainSection = homeRepository.GetHomeMainSections("/home/home-main-section").FirstOrDefault();
            var homeMainSectionContainer = homeRepository.GetHomeMainSectionsContainers("/home/home-main-section-container").FirstOrDefault();
            var homeMainSectionGraphic = homeRepository.GetHomeMainSectionsGraphics("/home/home-main-section-graphic").FirstOrDefault();
            var homeMainSectionBanner = homeRepository.GetHomeMainSectionsBanners("/home/home-main-section-banner").FirstOrDefault();
            var homeMainSectionExplanation = homeRepository.GetHomeMainSectionsExplanations("/home/home-main-section-explanation").FirstOrDefault();
            var homeMainSectionSecondary = homeRepository.GetHomeMainSectionsSecondaries().FirstOrDefault();
            var homeMainSectionFaq = homeRepository.GetHomeMainSectionsFaqs("/home/home-main-section-faq").FirstOrDefault();
            var homeMainSectionSm = homeRepository.GetHomeMainSectionsSms("/home/home-main-section-sm").FirstOrDefault();
            var viewModel = new HomeViewModel();

            viewModel.HomeMainSectionSm = HomeMainSectionSmViewModel.GetViewModel(homeMainSectionSm, homeRepository);
            viewModel.HomeMainSectionFaq = HomeMainSectionFaqViewModel.GetViewModel(homeMainSectionFaq, homeRepository);
            viewModel.HomeMainSectionSecondary = HomeMainSectionSecondaryViewModel.GetViewModel(homeMainSectionSecondary, homeRepository);
            viewModel.HomeMainSectionExplanation = HomeMainSectionExplanationViewModel.GetViewModel(homeMainSectionExplanation);
            viewModel.HomeMainSectionBanner = HomeMainSectionBannerViewModel.GetViewModel(homeMainSectionBanner);
            viewModel.HomeMainSectionGraphic = HomeMainSectionGraphicViewModel.GetViewModel(homeMainSectionGraphic);
            viewModel.HomeMainSectionContainer = HomeMainSectionContainerViewModel.GetViewModel(homeMainSectionContainer, homeRepository);
            viewModel.HomeMainSection = HomeMainSectionViewModel.GetViewModel(homeMainSection,homeRepository);
            viewModel.HomeSlider = HomeSliderViewModel.GetViewModel(homeSections);



            return View("Home",viewModel);
        }
    }
}
