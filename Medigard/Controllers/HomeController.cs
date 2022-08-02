using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Medigard;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Medigard.Controllers;
using Medigard.Repositories.Home;
using Microsoft.AspNetCore.Mvc;

[assembly: RegisterPageRoute(Home.CLASS_NAME, typeof(HomeController),ActionName = "Index")] 

namespace Medigard.Controllers
{

    public class HomeController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly HomeRepository homeSectionRepository;

        public HomeController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, HomeRepository homeSectionRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.homeSectionRepository = homeSectionRepository;
        }

        public IActionResult Index()
        {
            
            var homeSections = homeSectionRepository.GetHomeSectionsAsync("/home");

            return View();
        }
    }
}
