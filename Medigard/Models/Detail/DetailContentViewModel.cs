using CMS.DocumentEngine.Types.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medigard.Models.Detail
{
    public class DetailContentViewModel
    {
        

        public IEnumerable<DetailItemViewModel> ItemList { get; set; }
        public static DetailContentViewModel GetViewModel(DetailContent model, Repositories.Detail.DetailRepository detailRepository)
        {
            if (model == null)
            {
                return null;
            }

            return new DetailContentViewModel
            {
                
                ItemList = detailRepository.GetDetailItems("/detail/detail-content").Select(x => DetailItemViewModel.GetViewModel(x))
            };
        }
    }
}
