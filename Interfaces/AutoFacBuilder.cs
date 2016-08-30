using System;
using Autofac;

namespace Interfaces
{
	public class AutoFacBuilder
	{
		public IContainer GetContainer()
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<Apple>().As<IApple>();
			builder.RegisterType<Banana>().As<IBanana>();
			return builder.Build();
		}
	}
}
