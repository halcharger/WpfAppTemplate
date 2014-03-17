using Autofac;

namespace WpfAppTemplate.Autofac
{
    public static class Extensions
    {
        public static ContainerBuilder RegisterSingleton<TInterface, TImplementation>(this ContainerBuilder builder)
            where TImplementation : TInterface
        {
            builder.RegisterType<TImplementation>().As<TInterface>().SingleInstance();
            return builder;
        }

        public static ContainerBuilder RegisterSingleton<T>(this ContainerBuilder builder)
        {
            builder.RegisterType<T>().SingleInstance();
            return builder;
        }
    }
}