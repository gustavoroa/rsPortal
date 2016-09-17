using Ninject;
using RoaSystems.Server.Services;

namespace RoaSystems.Server.Infrastructure
{
    public static class NinjectConfig
    {
        public static void Apply(IKernel kernel)
        {
            kernel.Bind<IAplicacionService>().To<AplicacionService>();
            //kernel.Bind<ITopicService>().To<TopicService>();
            //kernel.Bind<ICacheManager>().To<CacheManager>();
        }
    }
}

