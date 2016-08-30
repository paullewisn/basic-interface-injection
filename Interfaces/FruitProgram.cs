using System;
using Autofac;

namespace Interfaces
{
	public class FruitProgram
	{
		public IContainer Container { get; set;}

		public FruitProgram() {
			var autoFacBuilder = new AutoFacBuilder();
			Container = autoFacBuilder.GetContainer();
		}

		public string GetFruitColour<T>() where T : IFruit
		{
			using (var scope = Container.BeginLifetimeScope()) 
			{
				var fruit = scope.Resolve<T>();
				return fruit.GetColour();
			}


		}
	}
}

