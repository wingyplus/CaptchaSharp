using NUnit.Framework;
using Captcha;

namespace CaptchaTest
{
	[TestFixture ()]
	public class NumberStringOperandTest
	{
		[Test ()]
		public void ToString_WhenGiven1_ShouldBeReturn1 ()
		{
			var operand = new NumberStringOperand (1);
			Assert.That (operand.ToString (), Is.EqualTo("1"));
		}

		[Test]
		public void ToString_WhenGiven2_ShouldBeReturn2() 
		{
			var operand = new NumberStringOperand (2);
			Assert.That(operand.ToString(), Is.EqualTo("2"));
		}
	}
}

