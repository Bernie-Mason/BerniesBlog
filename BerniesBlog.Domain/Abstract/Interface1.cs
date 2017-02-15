using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BerniesBlog.Domain.Entities;

namespace BerniesBlog.Domain.Abstract
{
    public interface IRestaurantRepository2
    {
        IEnumerable<Restaurant> Restaurants { get; }
    }
}
