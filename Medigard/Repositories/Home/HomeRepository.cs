using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Home;
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

        public IEnumerable<HomeSlider> GetHomeSections(string nodeAliasPath)
        {
            return HomeSliderProvider.GetHomeSliders();
    
                   
        }
        public IEnumerable<HomeMainSection> GetHomeMainSections(string nodeAliasPath)
        {
            return HomeMainSectionProvider.GetHomeMainSections();


        }
        public IEnumerable<HomeMainSectionItem> GetHomeMainSectionsItem(string nodeAliasPath)
        {
            return HomeMainSectionItemProvider.GetHomeMainSectionItems();


        }
        public IEnumerable<HomeMainSectionContainer> GetHomeMainSectionsContainers(string nodeAliasPath)
        {
            return HomeMainSectionContainerProvider.GetHomeMainSectionContainers();


        }
        public IEnumerable<HomeMainSectionContainerItem> GetHomeMainSectionsContainersItem(string nodeAliasPath)
        {
            return HomeMainSectionContainerItemProvider.GetHomeMainSectionContainerItems();


        }
        public IEnumerable<HomeMainSectionGraphic> GetHomeMainSectionsGraphics(string nodeAliasPath)
        {
            return HomeMainSectionGraphicProvider.GetHomeMainSectionGraphics();
        }

        public IEnumerable<HomeMainSectionBanner> GetHomeMainSectionsBanners(string nodeAliasPath)
        {
            return HomeMainSectionBannerProvider.GetHomeMainSectionBanners();
        }

        public IEnumerable<HomeMainSectionExplanation> GetHomeMainSectionsExplanations(string nodeAliasPath)
        {
            return HomeMainSectionExplanationProvider.GetHomeMainSectionExplanations();
        }

        public IEnumerable<HomeMainSectionSecondary> GetHomeMainSectionsSecondaries()
        {
            return HomeMainSectionSecondaryProvider.GetHomeMainSectionSecondaries();
        }

        public IEnumerable<HomeMainSectionSecondaryItem> GetHomeMainSectionsSecondariesItem(string nodeAliasPath)
        {
            var items = HomeMainSectionSecondaryItemProvider.GetHomeMainSectionSecondaryItems().Path(nodeAliasPath,PathTypeEnum.Children);
            return items;


        }

        public IEnumerable<HomeMainSectionChildItems> GetHomeMainSectionChildsItem(string nodeAliasPath)
        {
            var items = HomeMainSectionChildItemsProvider.GetHomeMainSectionChildItems().Path(nodeAliasPath, PathTypeEnum.Children);
            return items;
        }

        public IEnumerable<HomeMainSectionFaq> GetHomeMainSectionsFaqs(string nodeAliasPath)
        {
            return HomeMainSectionFaqProvider.GetHomeMainSectionFaqs();
        }

        public IEnumerable<HomeMainSectionFaqItem> GetHomeMainSectionFaqItems(string nodeAliasPath)
        {
            return HomeMainSectionFaqItemProvider.GetHomeMainSectionFaqItems();
        }

        public IEnumerable<HomeMainSectionSm> GetHomeMainSectionsSms(string nodeAliasPath)
        {
            return HomeMainSectionSmProvider.GetHomeMainSectionSms();
        }

        public IEnumerable<HomeMainSectionSmItem> GetHomeMainSectionSmItems(string nodeAliasPath)
        {
            return HomeMainSectionSmItemProvider.GetHomeMainSectionSmItems();
        }
        public IEnumerable<HomeMainSectionSmIcon> GetHomeMainSectionSmIcons(string nodeAliasPath)
        {
            return HomeMainSectionSmIconProvider.GetHomeMainSectionSmIcons();
        }
    }
}
