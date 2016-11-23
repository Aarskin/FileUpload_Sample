using Ninject;
using System.Reflection;
using System.Web.Mvc;

namespace FileUpload
{
    internal class NinjectControllerBuilderFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllerBuilderFactory()
        {
            var thisAssembly = Assembly.GetExecutingAssembly().FullName;
            _ninjectKernel = new StandardKernel();
        
            _ninjectKernel.Load(thisAssembly);
        }
    }
}