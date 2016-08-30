using NUnit.Framework;
using System;
namespace Interfaces.Test
{
	[TestFixture]
	public class FruitTest
	{
		[Test]
		public void AppleName()
		{
			FruitProgram fruitProgram = new FruitProgram();
			Assert.That(fruitProgram.GetFruitColour<IApple>(),Is.EqualTo(FruitColours.AppleColour));
		}


	}
}

