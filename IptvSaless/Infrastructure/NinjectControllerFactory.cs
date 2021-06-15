using Iptv.Domain.Abstract;
//using IptvSales.Domain;
using Iptv.Domain.Concrete;
using Ninject;
using System;
using System.Web.Mvc;

namespace IptvSaless.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel kernal;
        public NinjectControllerFactory()
        {
            kernal = new StandardKernel();
            addBinding();
        }


        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernal.Get(controllerType);
        }
        private void addBinding()
        {
            kernal.Bind<IPlanRepository>().To<EFdbRepository>();
            kernal.Bind<IBalanceRepository>().To<EFdbRepository>();
            kernal.Bind<ICartRepository>().To<EFdbRepository>();
        }
    }
}