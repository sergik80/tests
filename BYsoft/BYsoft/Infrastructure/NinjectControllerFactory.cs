using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using Model.Interfaces;
using Model.InterfaceImplements;





namespace BYsoft.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            addBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void addBindings()
        {
            ninjectKernel.Bind<IRepository>().To<DataRepository>();

        }
    }
}