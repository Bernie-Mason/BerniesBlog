using BerniesBlog.Domain.Abstract;
using BerniesBlog.Domain.Concrete;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BerniesBlog.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        IKernel kernel = new StandardKernel();

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IRestaurantRepository>().To<RestaurantReviewsDB>();
            //kernel.Bind<IRestaurantRepository2>().To<RestaurantsRepository>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);

        }
    }
}