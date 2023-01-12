using CMS.DocumentEngine.Types.Detail;
using CMS.DocumentEngine.Types.Medigard;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Medigard.Controllers;
using Medigard.Models.Detail;
using Medigard.Repositories.Detail;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: RegisterPageRoute(Detail.CLASS_NAME, typeof(DetailController), ActionName = "Index")]

namespace Medigard.Controllers
{
    public class DetailController : Controller
    {
        private readonly IPageDataContextRetriever pageDataContextRetriever;
        private readonly IPageUrlRetriever pageUrlRetriever;
        private readonly IPageAttachmentUrlRetriever attachmentUrlRetriever;
        private readonly DetailRepository detailRepository;

        public DetailController(IPageDataContextRetriever pageDataContextRetriever, IPageUrlRetriever pageUrlRetriever, IPageAttachmentUrlRetriever attachmentUrlRetriever, DetailRepository detailRepository)
        {
            this.pageDataContextRetriever = pageDataContextRetriever;
            this.pageUrlRetriever = pageUrlRetriever;
            this.attachmentUrlRetriever = attachmentUrlRetriever;
            this.detailRepository = detailRepository;
        }
        public IActionResult Index()
        {
            var detailSlider = detailRepository.GetDetailSliders("/detail/detail-slider").FirstOrDefault();
            var detailContent = detailRepository.GetDetailContents("/detail/detail-content").FirstOrDefault();
            var viewModel = new DetailViewModel();

            viewModel.DetailSlider = DetailSliderViewModel.GetViewModel(detailSlider);
            viewModel.DetailContent = DetailContentViewModel.GetViewModel(detailContent,detailRepository);
            return View("Detail",viewModel);
        }
    }
}
