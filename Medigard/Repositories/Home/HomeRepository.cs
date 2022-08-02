using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Medigard;
using Kentico.Content.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Repositories.Home
{
    public class HomeRepository
    {
        private readonly IPageRetriever pageRetriever;

        public HomeRepository(IPageRetriever pageRetriever)
        {
            this.pageRetriever = pageRetriever;
        }

        public IEnumerable<HomeSlider> GetHomeSectionsAsync(string nodeAliasPath)
        {
            return pageRetriever.Retrieve<HomeSlider>(
                query => query
                    .Path(nodeAliasPath, PathTypeEnum.Children)
                    .OrderBy("NodeOrder"));
    
                   
        }
    }
}
