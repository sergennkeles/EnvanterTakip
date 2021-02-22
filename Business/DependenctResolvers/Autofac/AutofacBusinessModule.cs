using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependenctResolvers.Autofac
{
   public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<DebitManager>().As<IDebitService>().SingleInstance();
            builder.RegisterType<EfDebitDal>().As<IDebitDal>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategorDal>().As<ICategoryDal>().SingleInstance();

            builder.RegisterType<PersonalManager>().As<IPersonalService>().SingleInstance();
            builder.RegisterType<EfPersonalDal>().As<IPersonalDal>().SingleInstance();
        }
    }
}
