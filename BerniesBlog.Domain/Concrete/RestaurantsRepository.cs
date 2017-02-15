using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Concrete
{
    public class RestaurantsRepository : IRestaurantRepository2
    {
        private RestaurantReviewsDB context = new RestaurantReviewsDB();

        public IEnumerable<Restaurant> Restaurants
        {
            get
            {
                return context.Restaurants;
            }
        }
    }
    }
}
