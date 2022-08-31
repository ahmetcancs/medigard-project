using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionSmIconViewModel
    {
        public string SocialIcon { get; set; }


        public static HomeMainSectionSmIconViewModel GetViewModel(HomeMainSectionSmIcon model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionSmIconViewModel
            {

                SocialIcon = model.SocialIcon
            };
        }
    }
}
