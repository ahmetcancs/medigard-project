using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Medigard.Models.Menu
{
    public class MenuItemViewModel
    {
        

            public string Title { get; set; }
            public string Description { get; set; }
            public string Target { get; set; }
            public string Link { get; set; }
            public bool HasImage { get; set; }
            public bool HasSocialMediaIcon { get; set; }
            private string _Image { get; set; }
            public string Image
            {
                get => _Image;
                set => _Image = value?.Replace("~", string.Empty);
            }
            
            public IEnumerable<MenuItemViewModel> MenuItems { get; set; }

            
        
    }
}

