using HomeWork2019._12._14_1_.AbstractModels;
using HomeWork2019._12._14_1_.DataAccess;
using HomeWork2019._12._14_1_.Models;
using HomeWork2019._12._14_1_.Services;
using Ninject.Modules;

namespace HomeWork2019._12._14_1_.Web.Ninject
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IRepository<Post>>().To<DbRepository<Post>>().WithConstructorArgument("context", new PostContext());
        }
    }
}