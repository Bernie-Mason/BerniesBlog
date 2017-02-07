using BerniesBlog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerniesBlog.Domain.Abstract
{
    interface IRestaurantRepository
    {
        IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
