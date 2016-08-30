using System;
namespace Interfaces
{
	public class Banana : IBanana
	{
		public string GetColour()
		{
			return FruitColours.BananaColour;
		}

		public void HowToMakeMilkshake()
		{
			throw new NotImplementedException();
		}
	}
}

