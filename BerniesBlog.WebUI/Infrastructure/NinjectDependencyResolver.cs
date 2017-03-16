
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BerniesBlog.Domain.Concrete;
using BerniesBlog.Domain.Abstract;
using BerniesBlog.WebUI.Infrastructure.Abstract;
using BerniesBlog.WebUI.Infrastructure.Concrete;

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
            kernel.Bind<IBlogPost>().To<BlogPostRepo>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
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