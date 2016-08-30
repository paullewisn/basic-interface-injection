using System;
namespace Interfaces
{
	public class Apple : IApple
	{
		public string GetColour()
		{
			return FruitColours.AppleColour;
		}

		public void HowToMakeFruitPie()
		{
			throw new NotImplementedException();
		}
	}
}

