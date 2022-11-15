using Autofac;
using EasyBlog.Data;
using System.Linq;

namespace EasyBlog.Web.Core
{
	public class RepositoryRegistrationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			var easyBlog = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Code\\Pluralsight\\autofac-aspnet-implementing\\02\\demos\\Starter\\EasyBlog\\EasyBlog.Web\\App_Data\\connStrName.mdf;Integrated Security=True";

			builder.RegisterAssemblyTypes(typeof(BlogPostRepository).Assembly)
				.Where(t => t.Name.EndsWith("Repository"))
				.As(t => t.GetInterfaces()?.FirstOrDefault(
					i => i.Name == "I" + t.Name))
				.InstancePerRequest()
				.WithParameter(new TypedParameter(typeof(string), easyBlog));

			base.Load(builder);
		}
	}
}