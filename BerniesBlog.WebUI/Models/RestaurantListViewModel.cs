using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BerniesBlog.WebUI.Models
{
    public class RestaurantListViewModel : RestaurantViewModel
    {
        public List<RestaurantViewModel> Restaurants { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCatagory { get; set; }
       

    }


}