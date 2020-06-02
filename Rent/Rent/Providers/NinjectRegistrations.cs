using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rent.Interfaces;
using Rent.Services;
using Ninject.Modules;

namespace Rent.Providers
{
    public class NinjectRegistrations: NinjectModule
    {
        public override void Load()
        {
            Bind<IRentService>().To<EntityRentService>();
        }
    }
}