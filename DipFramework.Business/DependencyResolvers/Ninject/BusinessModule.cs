using DipFramework.Business.Abstract;
using DipFramework.Business.Concrete.Managers;
using DipFramework.DataAccess.EntityFramework.Abstract;
using DipFramework.DataAccess.EntityFramework.Concrete;
using DipFramework.DataAccess.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipFramework.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();

            //Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepositoryBase<>));
            Bind<DbContext>().To<NorthwindContext>();

            //Bind<NhibernateHelper>().To<SqlServerHelper>();
        }
    }
}
