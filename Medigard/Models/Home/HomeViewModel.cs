using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeViewModel
    {
        public HomeSliderViewModel HomeSlider { get; set; }

        public HomeMainSectionViewModel HomeMainSection { get; set; }
        public HomeMainSectionContainerViewModel HomeMainSectionContainer { get; set; }

        public HomeMainSectionGraphicViewModel HomeMainSectionGraphic { get; set; }

        public HomeMainSectionBannerViewModel HomeMainSectionBanner { get; set; }

        public HomeMainSectionExplanationViewModel HomeMainSectionExplanation { get; set; }

        public HomeMainSectionSecondaryViewModel HomeMainSectionSecondary { get; set; }

        public HomeMainSectionFaqViewModel HomeMainSectionFaq { get; set; }
        public HomeMainSectionSmViewModel HomeMainSectionSm { get; set; }
    }
}
