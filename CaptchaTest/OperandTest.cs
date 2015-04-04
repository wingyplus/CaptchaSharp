using System;
using NUnit.Framework;
using Captcha;

namespace CaptchaTest
{
	[TestFixture]
	public class OperandTest
	{
		[Test]
		public void ToString_WhenGivenValue1AndMode1_ShouldReturn1() {
			var operand = new Operand(1, 1);
			Assert.That (operand.ToString (), Is.EqualTo ("1"));
		}

		[Test]
		public void ToString_WhenGivenValue2AndMode1_ShouldReturn2() {
			var operand = new Operand (2, 1);
			Assert.That (operand.ToString (), Is.EqualTo ("2"));
		}

		[Test]
		public void ToString_WhenGivenValue1AndMode2_ShouldReturnOne() {
			var operand = new Operand (1, 2);
			Assert.That (operand.ToString (), Is.EqualTo ("One"));
		}
	}
}

