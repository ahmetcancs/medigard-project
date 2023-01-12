using CMS.DocumentEngine.Types.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Home
{
    public class HomeMainSectionChildItemsViewModel
    {
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Description { get; set; }

        public bool SecondaryTab { get; set; }

        public bool Active { get; set; }
        public static HomeMainSectionChildItemsViewModel GetViewModel(HomeMainSectionChildItems model)
        {
            if (model == null)
            {
                return null;
            }

            return new HomeMainSectionChildItemsViewModel
            {
                
                Title = model.Title,
                SubTitle = model.SubTitle,
                Description = model.Description,
                SecondaryTab = model.SecondaryTab,
                Active = model.Active
               
            };
        }
    }
}
