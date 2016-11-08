using System;
using Microsoft.Practices.Unity;

namespace WpfPlayground.IoC
{
    public class IoCContainer
    {
        public static Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            return container;
        });

        public static IUnityContainer Instance = Container.Value;
    }
}
