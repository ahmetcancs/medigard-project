using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionFaqItemViewModel
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public static HomeMainSectionFaqItemViewModel GetViewModel(HomeMainSectionFaqItem model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionFaqItemViewModel
            {

                Question = model.Question,
                Answer = model.Answer
            };
        }
    }
}
