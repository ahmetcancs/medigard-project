using CMS.DocumentEngine.Types.Detail;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Repositories.Detail
{
    public class DetailRepository
    {
        private readonly IPageRetriever pageRetriever;

        public DetailRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }

        public IEnumerable<DetailItem> GetDetailItems(string nodeAliasPath)
        {
            return DetailItemProvider.GetDetailItems();


        }
        public IEnumerable<DetailSlider> GetDetailSliders(string nodeAliasPath)
        {
            return DetailSliderProvider.GetDetailSliders();


        }
        public IEnumerable<DetailContent> GetDetailContents(string nodeAliasPath)
        {
            return DetailContentProvider.GetDetailContents();
        }
    }
}
