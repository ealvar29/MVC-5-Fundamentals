using Autofac;
using Autofac.Integration.Mvc;
using OdeToFood.Data.Services;

namespace OdeToFood
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerConfig();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<InMemoryRestaurantData>()
                .As<IRestaurantData>()
                .SingleInstance();
        }
    }
}