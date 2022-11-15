using Autofac;

namespace EasyBlog.Web.Core
{
	public class ComponentLocator : IComponentLocator
	{
		ILifetimeScope container;

		public ComponentLocator(ILifetimeScope container)
		{
			this.container = container;
		}

		public T ResolveComponent<T>()
		{
			return container.Resolve<T>();
		}
	}

	public interface IComponentLocator
	{
		T ResolveComponent<T>();
	}
}